using cbhk_editor.ItemSpawner;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.VillagerSpawner
{
    public partial class villager_page : UserControl
    {
        //言论按钮集合
        List<Button> speech_btns = new List<Button> { new Button() {Text = ">major_negative" }
        ,new Button() { Text = ">minor_negative" },
         new Button() { Text = ">major_positive" },
         new Button() { Text = ">minor_positive" },
         new Button() { Text = ">trading" },
         new Button() { Text = ">golem" } };

        //坐标按钮集合
        List<Button> position_btns = new List<Button> { new Button() { Text = ">聚集点坐标",Name = "meeting_point" }, new Button() { Text = ">床坐标", Name ="home" }, new Button() { Text = ">工作点坐标",Name = "job_site" } };

        //按钮图像
        Image btnImg = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //保存注册表
        TreeView register = new TreeView();
        SoundPlayer click;
        public villager_page(TreeView root,SoundPlayer soundPlayer)
        {
            InitializeComponent();
            register = root;
            click = soundPlayer;
            InitUISettings(root);
        }

        private void InitUISettings(TreeView rootnode)
        {
            villager_type_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            villager_type_box.AutoCompleteSource = AutoCompleteSource.CustomSource;

            villager_professional.AutoCompleteMode = AutoCompleteMode.Suggest;
            villager_professional.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (TreeNode item in rootnode.Nodes)
            {
                #region 村民类型
                if (item.Text.Contains("villager_type"))
                {
                    foreach (TreeNode subitem in item.Nodes[2].Nodes)
                    {
                        villager_type_box.Items.Add(subitem.Text);
                        villager_type_box.AutoCompleteCustomSource.Add(subitem.Text);
                    }
                }
                #endregion

                #region 村民职业
                if (item.Text.Contains("villager_profession"))
                {
                    foreach (TreeNode subitem in item.Nodes[2].Nodes)
                    {
                        villager_professional.Items.Add(subitem.Text);
                        villager_professional.AutoCompleteCustomSource.Add(subitem.Text);
                    }
                }
                #endregion
            }

            version_box.SelectedIndex = 1;
            speech_btn_box.Scrollable = memory_btn_box.Scrollable = true;
            speech_btn_box.BackColor = memory_btn_box.BackColor = Color.FromArgb(50,50,50);
            //为言论和坐标绑定点击事件
            int index = 0;
            foreach (Button item in speech_btns)
            {
                item.Location = new Point(0, 0 + item.Size.Height * index);
                item.Dock = DockStyle.Top;
                item.ForeColor = Color.White;
                item.Cursor = Cursors.Hand;
                item.BackgroundImage = btnImg;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.FlatStyle = FlatStyle.Flat;
                item.FlatAppearance.BorderSize = 0;
                item.FlatAppearance.MouseDownBackColor = Color.Transparent;
                item.FlatAppearance.MouseOverBackColor = Color.Transparent;
                item.Click += ClickSound;
                item.Click += (a, b) =>
                {
                    string targetuid = "";
                    targetuid = version_box.SelectedIndex == 0 ? "TargetMost:" + targetmost_box.Text.Trim() + "," + "TargetLeast:" + targetleast_box.Text.Trim() : (version_box.SelectedIndex == 1? "Target:" + target_box.Text.Trim() : "");
                    item.Tag = value_box.Value != 0 ? "{Type:\"" + Regex.Match(item.Text,@"[A-z_]+").ToString()+"\"," + "Value:" + value_box.Value+"," +targetuid +"}," : "";
                };
                speech_btn_box.Controls.Add(item);
                index++;
            }
            //为坐标按钮绑定点击事件
            index = 0;
            foreach (Button item in position_btns)
            {
                item.Location = new Point(0, 0 + item.Size.Height * index);
                item.Dock = DockStyle.Top;
                item.ForeColor = Color.White;
                item.Cursor = Cursors.Hand;
                item.BackgroundImage = btnImg;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.FlatStyle = FlatStyle.Flat;
                item.FlatAppearance.BorderSize = 0;
                item.FlatAppearance.MouseDownBackColor = Color.Transparent;
                item.FlatAppearance.MouseOverBackColor = Color.Transparent;
                item.Click += ClickSound;
                item.Click += (a, b) =>
                {
                    item.Tag = "\"minecraft:"+item.Name+"\":{pos:["+ pos_x_box.Text.Trim()+"d,"+pos_y_box.Text.Trim()+"d,"+pos_z_box.Text.Trim()+ "d],dimension:\""+ dimension_box.Text.Trim()+ "\"},";
                };
                memory_btn_box.Controls.Add(item);
                index++;
            }

            //为文本框绑定限制键入
            position_area.BackColor = Color.FromArgb(50,50,50);
            foreach (Control item in position_area.Controls)
            {
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
                if (item is TextBox)
                {
                    item.KeyPress += Number_KeyPress;
                    item.KeyUp += Number_KeyUp;
                }
            }

            villager_table.BackColor = Color.FromArgb(50, 50, 50);
            villager_table.ForeColor = Color.White;
            foreach (Control item in villager_table.Controls)
            {
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
            }

            foreach (Control item in speech_area.Controls)
            {
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
            }

            transaction_page tp = new transaction_page(click,register);
            transaction_tab.SelectedTab.Controls.Add(tp.transaction_table);
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click.Play();
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox this_obj = sender as TextBox;

            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
                e.Handled = true;
            if (e.KeyChar == '-' && this_obj.Text.Trim() =="")
            {
                if (this_obj.Name.Contains("pos"))
                    if (this_obj.Text.Trim() == "")
                    {
                        this_obj.Text = "-";
                        this_obj.Select(this_obj.Text.Length, 0);
                        e.Handled = true;
                    }
                    else
                        if (this_obj.Text.Contains("."))
                        e.Handled = true;
                    else
                        e.Handled = false;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {

                if (this_obj.Text == "")
                {
                    this_obj.Text = "0.";
                    this_obj.Select(this_obj.Text.Length, 0);
                    e.Handled = true;
                }
                else if (this_obj.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }

        private void Number_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if(e.KeyData == (Keys.Control|Keys.V))
            {
                this_obj.SelectedText = Regex.Match(Clipboard.GetText(),@"\d+").ToString();
            }
        }

        private void random_targetmost_Click(object sender, EventArgs e)
        {
            click.Play();
            targetmost_box.Text = UuidHelper.NewUuidString();
        }

        private void random_targetleast_Click(object sender, EventArgs e)
        {
            click.Play();
            targetleast_box.Text = UuidHelper.NewUuidString();
        }

        private void random_target_Click(object sender, EventArgs e)
        {
            click.Play();
            target_box.Text = UuidHelper.NewUuidString();
        }

        private void dimension_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void transaction_level_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
