using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.RecipeSpawner
{
    public partial class recipe_spawner : Form
    {
        Form parent = null;
        SoundPlayer click_sound = null;
        TreeView RootNode;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //需要给经验的槽位
        List<int> exp_index = new List<int>() {0, 1, 4, 5 };
        //需要改变槽位编辑权限的索引
        List<int> change_index = new List<int> { 2, 3 };

        public recipe_spawner(Form this_obj,SoundPlayer soundPlayer)
        {
            InitializeComponent();
            MaximumSize = Size;
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            parent = this_obj;
            click_sound = soundPlayer;
            RootNode = Cbhk_form.register;
            InitUISettigs();
        }

        private void InitUISettigs()
        {
            click_to_return.Click += (a,b) => 
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            recipe_tab.TabPages.Clear();
            add_recipe_title_menu_Click(null,null);
            BackColor = Color.FromArgb(50, 50, 50);
            recipe_title_menu.BackColor = Color.FromArgb(50, 50, 50);
            foreach (ToolStripMenuItem item in recipe_title_menu.Items)
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

        private void add_recipe_title_menu_Click(object sender, EventArgs e)
        {
            recipe_page page = new recipe_page();
            recipe_tab.TabPages.Add(page.recipe_tab.SelectedTab);
            recipe_tab.SelectedIndex = recipe_tab.TabPages.Count - 1;
        }

        private void delete_recipe_title_menu_Click(object sender, EventArgs e)
        {
            recipe_tab.TabPages.RemoveAt(recipe_tab.SelectedIndex);
        }

        private void clear_recipe_title_menu_Click(object sender, EventArgs e)
        {
            recipe_tab.TabPages.Clear();
        }

        private void add_recipe_Click(object sender, EventArgs e)
        {
            add_recipe_title_menu_Click(null,null);
        }

        private void delete_recipe_Click(object sender, EventArgs e)
        {
            delete_recipe_title_menu_Click(null,null);
        }

        private void clear_recipe_Click(object sender, EventArgs e)
        {
            clear_recipe_title_menu_Click(null,null);
        }

        private TabPage GetTabPageByTab(Point point, TabControl this_obj)
        {
            for (int i = 0; i < this_obj.TabPages.Count; i++)
            {
                if (this_obj.GetTabRect(i).Contains(point))
                {
                    return this_obj.TabPages[i];
                }
            }
            return null;
        }

        private void rename_Click(object sender, EventArgs e)
        {
            TextBox rename_box = new TextBox()
            {
                Name = "rename_box",
                Size = new Size(80,25)
            };
            TabPage rename_page =  GetTabPageByTab(recipe_tab.GetTabRect(recipe_tab.SelectedIndex).Location,recipe_tab);
            Point pos = recipe_tab.GetTabRect(recipe_tab.SelectedIndex).Location;
            rename_box.Location = new Point(pos.X,pos.Y+recipe_tab.Location.Y);
            rename_box.KeyDown += (a,b) => 
            {
                if(b.KeyCode == Keys.Enter)
                {
                    rename_page.Text = rename_box.Text+".json";
                    Controls.Remove(rename_box);
                }
                if (b.KeyCode == Keys.Escape)
                    Controls.Remove(rename_box);
            };
            rename_box.LostFocus += (a,b) => { Controls.Remove(rename_box); };
            Controls.Add(rename_box);
            rename_box.BringToFront();
            rename_box.Focus();
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存最终结果
            List<string> results = new List<string> { };
            foreach (TabPage a_recipe in recipe_tab.TabPages)
            {
                //搜索配方类型控件引用
                ComboBox recipe_type = a_recipe.Controls.Find("recipe_type", true)[0] as ComboBox;
                //搜索所需经验值
                NumericUpDown reward_xp = a_recipe.Controls.Find("reward_xp", true)[0] as NumericUpDown;
                //搜索所需烧制时间
                NumericUpDown firing_time = a_recipe.Controls.Find("firing_time", true)[0] as NumericUpDown;
                //搜索所需数量
                NumericUpDown recipe_count = a_recipe.Controls.Find("recipe_count", true)[0] as NumericUpDown;
                //搜索所需结果
                ComboBox recipe_result = a_recipe.Controls.Find("recipe_result", true)[0] as ComboBox;
                //搜索组标识符
                TextBox group_name = a_recipe.Controls.Find("group_name", true)[0] as TextBox;
                //搜索键值标签页控件引用
                TabControl recipe_value_tab = a_recipe.Controls.Find("recipe_value_tab", true)[0] as TabControl;
                //搜索键表控件引用
                TableLayoutPanel recipe_content = a_recipe.Controls.Find("recipe_content", true)[0] as TableLayoutPanel;

                //保存配方类型
                string RecipeType = "\"type\":\"minecraft:"+Regex.Match(recipe_type.Text,@"[A-z_]+").ToString()+"\",\n";
                //保存组标识符
                string group_string = group_name.Text.Trim() != "" ? "\"group\":\""+group_name +"\",\n":"";
                //保存九宫格数据
                List<string> data_table = new List<string> { };
                //依次添加数据
                for (int i = recipe_content.Controls.Count-1; i >= 0; i--)
                {
                    data_table.Add(recipe_content.Controls[i].Text.Trim()!=""? recipe_content.Controls[i].Text :" ");
                }

                //保存物品id和tag
                List<string> ItemId = new List<string> { };
                List<string> ItemTag = new List<string> { };
                foreach (TabPage page in recipe_value_tab.TabPages)
                {
                    TextBox item_id = page.Controls.Find("key_id", true)[0] as TextBox;
                    TextBox item_tag = page.Controls.Find("key_tag", true)[0] as TextBox;
                    ItemId.Add(item_id.Text);
                    ItemTag.Add(Regex.Escape(item_tag.Text).Replace("\\ "," "));
                }

                //不为有序和无序
                string content = "";
                if (exp_index.Find(obj=>recipe_type.SelectedIndex == obj) != 0 || recipe_type.SelectedIndex == 0)
                {
                    content = "\"ingredient\":{\n\"item\":\"minecraft:"+ (data_table[0].Trim()!=""? data_table[0] :ItemId[0]) + "\",\n\"tag\":\""+ItemTag[0]+"\"\n},\n";
                    results.Add("{\n" + RecipeType + group_string + content + (recipe_result.Text.Trim() != "" ? "\"result\":\"minecraft:" + recipe_result.Text + "\"" : "") + (reward_xp.Value != 0 ? ",\n\"experience\":" + reward_xp.Value : "") + (firing_time.Value != 0 ? ",\n\"cookingtime\":" + firing_time.Value : "") + (recipe_count.Value != 0 ? ",\n\"count\":" + recipe_count.Value : "") + "\n}");
                }

                //有序合成
                if(recipe_type.SelectedIndex == 2)
                {
                    string model = "\"pattern\":[\n\""+data_table[0].Substring(0, 1) + data_table[1].Substring(0, 1)+ data_table[2].Substring(0, 1) + "\",\n\""+ data_table[3].Substring(0, 1) + data_table[4].Substring(0, 1) + data_table[5].Substring(0, 1) + "\",\n\""+ data_table[6].Substring(0, 1)+ data_table[7].Substring(0, 1)+ data_table[8].Substring(0, 1) + "\"\n]";
                    string key_item = "";
                    for (int i = 0; i < data_table.Count; i++)
                    {
                        if(data_table[i].Trim()!="")
                        {
                            key_item += "\""+data_table[i].Substring(0,1)+"\":{\n\"item\":\"minecraft:"+ItemId[i]+"\""+(ItemTag[i].Trim()!=""?"\n,\"tag\":\""+ItemTag[i].Trim()+"\"":"")+"\n},\n";
                        }
                    }
                    key_item = key_item.Substring(0,key_item.Length-2);
                    //保存键值解释
                    string key_info = ",\n\"key\":{\n"+key_item+"\n},\n";
                    //保存结果
                    string RecipeResult = "\"result\":{\n\"item\":\"minecraft:" + recipe_result.Text+"\"" + (recipe_count.Value != 0 ? "\n,\"count\":" + recipe_count.Value : "")+"}\n";

                    results.Add("{\n"+RecipeType+group_string+model+ key_info+ RecipeResult+"\n}");
                }

                //无序合成
                if(recipe_type.SelectedIndex == 3)
                {
                    string ingredient = "";
                    for (int i = 0; i < data_table.Count; i++)
                    {
                        if(data_table[i].Trim()!="")
                            ingredient += "{\n\"item\": \"minecraft:"+(data_table[i].Trim()!=""? data_table[i] :ItemId[i].Trim()) +"\"\n"+(ItemTag[i].Trim()!=""?",\"tag\":"+ ItemTag[i].Trim():"") +"},\n";
                    }
                    ingredient = ingredient.Substring(0,ingredient.Length-2);
                    string ingredients = "\"ingredients\":[\n"+ingredient+"\n],\n";

                    results.Add(RecipeType+group_string+ ingredients + (recipe_result.Text.Trim() != "" ? "\"result\":\"minecraft:" + recipe_result.Text + "\"" : "") + (reward_xp.Value != 0 ? "\n,\"experience\":" + reward_xp.Value : "") + (firing_time.Value != 0 ? "\n,\"cookingtime\":" + firing_time.Value : "") + (recipe_count.Value != 0 ? "\n,\"count\":" + recipe_count.Value : "") + "\n}");
                }
            }
            FolderBrowserDialog recipe_path = new FolderBrowserDialog()
            {
                Description="请选择配方生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true
            };
            if(recipe_path.ShowDialog() == DialogResult.OK && Directory.Exists(recipe_path.SelectedPath))
            {
                for (int i = 0; i < results.Count; i++)
                {
                    File.WriteAllText(recipe_path.SelectedPath + "\\" + recipe_tab.TabPages[i].Text,results[i],new UTF8Encoding(false));
                }
                Process.Start(recipe_path.SelectedPath);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.右击配方页面设置文件名\r\n2.下方标签页与九宫格一 一对应");
        }

        private void version1_12_Click(object sender, EventArgs e)
        {
            version1_13.Checked = !version1_12.Checked;
        }

        private void version1_13_Click(object sender, EventArgs e)
        {
            version1_12.Checked = !version1_13.Checked;
        }
    }
}
