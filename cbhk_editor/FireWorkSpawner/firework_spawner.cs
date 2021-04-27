using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.FireWorkSpawner
{
    public partial class firework_spawner : Form
    {
        Point CurrentPos = new Point();
        Panel panel = new Panel()
        {
            Size = new Size(50, 50)
        };
        List<Color> ColorList = new List<Color> { Color.FromArgb(0, 0, 0), Color.FromArgb(255, 0, 0), Color.FromArgb(0, 255, 0), Color.FromArgb(165, 42, 42), Color.FromArgb(0, 0, 255), Color.FromArgb(160, 32, 240), Color.FromArgb(0, 255, 255), Color.FromArgb(211, 211, 211), Color.FromArgb(190, 190, 190), Color.FromArgb(255, 192, 203), Color.FromArgb(34, 139, 34), Color.FromArgb(255, 255, 0), Color.FromArgb(173, 216, 230), Color.FromArgb(207, 0, 112), Color.FromArgb(255, 140, 0), Color.FromArgb(255, 255, 255) };
        Form parent;
        SoundPlayer click_sound;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        public firework_spawner(Form obj,SoundPlayer click)
        {
            InitializeComponent();
            Controls.Add(panel);
            parent = obj;
            click_sound = click;
            InitUISettings();
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            click_to_return.Click += (a, b) =>
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            firework_tab.TabPages.Clear();
            add_firework_menu_Click(null, null);
            BackColor = Color.FromArgb(50, 50, 50);
            firework_title_menu.BackColor = Color.FromArgb(50, 50, 50);
            foreach (ToolStripMenuItem item in firework_title_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.DropDownOpened += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(0, 0, 0);
                };
                item.DropDownClosed += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(255, 255, 255);
                };
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    subitem.Click += ClickSound;
                }
            }
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void add_firework_menu_Click(object sender, EventArgs e)
        {
            firework_page page = new firework_page(click_sound);
            firework_tab.TabPages.Add(page.firework_tab.SelectedTab);
            firework_tab.SelectedIndex = firework_tab.TabPages.Count - 1;
            firework_tab.SelectedTab.Text = "第"+firework_tab.TabPages.Count+"个";
            CheckedListBox color_box = firework_tab.SelectedTab.Controls.Find("color_box",true)[0] as CheckedListBox;
            color_box.MouseDown += (a,b) => {
                CheckedListBox this_obj = a as CheckedListBox;
                CurrentPos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                panel.Location = new Point(CurrentPos.X + this_obj .Location.X + 30,CurrentPos.Y);
                panel.Visible = true;
            };
            color_box.MouseMove += (a, b) => 
            {
                CheckedListBox this_obj = a as CheckedListBox;
                if (color_box.SelectedIndex >= 0 && color_box.SelectedIndex <= (color_box.Items.Count - 1))
                {
                    CurrentPos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                    panel.BackColor = ColorList[color_box.SelectedIndex];
                    panel.Location = new Point(CurrentPos.X + this_obj.Location.X + 30, CurrentPos.Y);
                    panel.BringToFront();
                }
            };
            color_box.MouseUp += (a,b) => 
            {
                panel.Visible = false;
            };
        }

        private void delete_firework_menu_Click(object sender, EventArgs e)
        {
            firework_tab.TabPages.RemoveAt(firework_tab.SelectedIndex);
        }

        private void clear_firework_menu_Click(object sender, EventArgs e)
        {
            firework_tab.TabPages.Clear();
        }

        private void add_firework_Click(object sender, EventArgs e)
        {
            add_firework_menu_Click(null,null);
        }

        private void delete_firework_Click(object sender, EventArgs e)
        {
            delete_firework_menu_Click(null,null);
        }

        private void clear_firework_Click(object sender, EventArgs e)
        {
            clear_firework_menu_Click(null,null);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.如果自定义颜色和随机颜色都开启,最终结果会在自定义后接着所有随机的颜色\n2.点击颜色列表成员完成删除操作");
        }

        private void random_style_menu_Click(object sender, EventArgs e)
        {
            CheckBox random_color = firework_tab.SelectedTab.Controls.Find("random_color", true)[0] as CheckBox;
            random_color.Checked = true;
            CheckBox random_fade_color = firework_tab.SelectedTab.Controls.Find("random_fade_color", true)[0] as CheckBox;
            random_fade_color.Checked = true;
            //随机颜色数量
            NumericUpDown color_count = firework_tab.SelectedTab.Controls.Find("color_count", true)[0] as NumericUpDown;
            NumericUpDown fade_color_count = firework_tab.SelectedTab.Controls.Find("fade_color_count", true)[0] as NumericUpDown;
            Random random = new Random();
            color_count.Value = random.Next(0,101);
            fade_color_count.Value = random.Next(0, 101);
            //随机形状
            CheckedListBox shape_box = firework_tab.SelectedTab.Controls.Find("shape_box", true)[0] as CheckedListBox;
            shape_box.SetItemChecked(random.Next(0, shape_box.Items.Count - 1), true);
            //随机轨迹
            CheckBox twinkle = firework_tab.SelectedTab.Controls.Find("twinkle", true)[0] as CheckBox;
            CheckBox Procrastination = firework_tab.SelectedTab.Controls.Find("Procrastination", true)[0] as CheckBox;
            twinkle.Checked = Procrastination.Checked = false;
            int select_index = random.Next(0, 2);
            if (select_index == 0)
                twinkle.Checked = true;
            else
                Procrastination.Checked = true;

            //随机飞行时长
            ComboBox duration_box = firework_tab.SelectedTab.Controls.Find("duration_box", true)[0] as ComboBox;
            duration_box.SelectedIndex = random.Next(0,duration_box.Items.Count);
        }

        private void random_style_Click(object sender, EventArgs e)
        {
            random_style_menu_Click(null,null);
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            List<string> results = new List<string> { };
            foreach (TabPage a_firework in firework_tab.TabPages)
            {
                //获取生成模式
                CheckBox give_model = firework_tab.SelectedTab.Controls.Find("give_model", true)[0] as CheckBox;
                CheckBox summon_model = firework_tab.SelectedTab.Controls.Find("summon_model", true)[0] as CheckBox;

                //随机颜色数量
                NumericUpDown color_count = firework_tab.SelectedTab.Controls.Find("color_count", true)[0] as NumericUpDown;
                NumericUpDown fade_color_count = firework_tab.SelectedTab.Controls.Find("fade_color_count", true)[0] as NumericUpDown;

                //颜色列表
                ComboBox color_list = firework_tab.SelectedTab.Controls.Find("color_list", true)[0] as ComboBox;
                ComboBox fade_color_list = firework_tab.SelectedTab.Controls.Find("fade_color_list", true)[0] as ComboBox;

                //形状列表
                CheckedListBox shape_box = firework_tab.SelectedTab.Controls.Find("shape_box", true)[0] as CheckedListBox;
                for (int i = 0; i < shape_box.Items.Count; i++)
                {
                    if(shape_box.GetItemChecked(i))
                    {
                        shape_box.SelectedIndex = i;
                        break;
                    }
                }

                //闪烁和拖尾
                CheckBox twinkle = firework_tab.SelectedTab.Controls.Find("twinkle", true)[0] as CheckBox;
                CheckBox Procrastination = firework_tab.SelectedTab.Controls.Find("Procrastination", true)[0] as CheckBox;

                //飞行时长
                ComboBox duration_box = firework_tab.SelectedTab.Controls.Find("duration_box", true)[0] as ComboBox;

                //是否按角度射出
                CheckBox shotAtAngle_box = firework_tab.SelectedTab.Controls.Find("shotAtAngle_box", true)[0] as CheckBox;

                //合并颜色数据
                string color_data = "";
                foreach (string item in color_list.Items)
                {
                    color_data += item + ",";
                }
                string fade_color_data = "";
                foreach (string item in fade_color_list.Items)
                {
                    fade_color_data += item+",";
                }
                Random random = new Random();

                //创建随机颜色
                if(color_count.Enabled)
                {
                    for (int i = 0; i < color_count.Value; i++)
                    {
                        string front = random.Next(0, 10000).ToString();
                        string back = random.Next(0, 10000).ToString();
                        color_data += front + back + ",";
                    }
                }
                if(fade_color_count.Enabled)
                {
                    for (int i = 0; i < fade_color_count.Value; i++)
                    {
                        string front = random.Next(0, 10000).ToString();
                        string back = random.Next(0, 10000).ToString();
                        fade_color_data += front + back + ",";
                    }
                }
                color_data = color_data.TrimEnd(',');
                fade_color_data = fade_color_data.TrimEnd(',');

                if (give_model.Checked)
                    results.Add("/give @p firework_rocket{Fireworks:{Explosions:[{Type:"+shape_box.SelectedIndex + (twinkle.Checked? ",Flicker:1" :"")+(Procrastination.Checked? ",Trail:1" : "")+",Colors:[I;"+color_data+"],FadeColors:[I;"+fade_color_data+"]}],Flight:"+duration_box.Text+"}}\r\n");

                if (summon_model.Checked)
                    results.Add("/summon firework_rocket ~ ~ ~ {LifeTime:20"+(shotAtAngle_box.Checked? ",ShotAtAngle:true" : "")+",FireworksItem:{id:firework_rocket,Count:1b,tag:{Fireworks:{Explosions:[{Type:"+shape_box.SelectedIndex + (twinkle.Checked? ",Flicker:1" : "")+(Procrastination.Checked? ",Trail:1" : "")+",Colors:[I;"+color_data+"],FadeColors:[I;"+fade_color_data+"]}],Flight:"+duration_box.Text+"}}}}\r\n");
            }

            #region 生成命令
            command_result cmd_result = new command_result("烟花火箭命令",results);
            cmd_result.Show();
            #endregion
        }
    }
}
