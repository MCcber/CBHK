using cbhk_editor.ItemSpawner;
using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.WrittrenBookSpawner
{
    public partial class written_book_spawner : Form
    {
        Form parent;
        //颜色链表
        List<Color> Colors = new List<Color> { Color.Aqua, Color.Black, Color.Blue, Color.FromArgb(0, 170, 170), Color.DarkBlue, Color.DarkGray, Color.DarkGreen, Color.FromArgb(170, 0, 170), Color.DarkRed, Color.Gold, Color.Gray, Color.Green, Color.FromArgb(255, 85, 255), Color.Red, Color.White, Color.Yellow };
        //样式链表
        List<int> FontStyleIndex = new List<int> { 0,1,2,3,4};
        Panel color_panel = new Panel()
        {
            Size = new Size(50,50),
            Visible = false
        };
        //预览文本
        Label display_txt = new Label()
        {
            Text = "Minecraft",
            ForeColor = Color.White,
            AutoSize = true
        };
        Point MousePos = new Point();
        SoundPlayer SoundPlayer = new SoundPlayer();
        Image btn_img = Image.FromFile(Application.StartupPath+ "\\ButtonsBgImages\\button.png");
        public written_book_spawner(Form this_obj,SoundPlayer click)
        {
            InitializeComponent();
            Controls.Add(color_panel);
            parent = this_obj;
            SoundPlayer = click;
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            click_to_return.Click += (a,b) => 
            {
                SoundPlayer.Play();
                this_obj.WindowState = FormWindowState.Normal;
                this_obj.TopMost = true;
                this_obj.Show();
                this_obj.TopMost = false;
                this_obj.ShowInTaskbar = true;
                Close();
            };
            InitUISettings();
        }

        public void InitUISettings()
        {
            //清空页
            page_tab.TabPages.Clear();
            //新建页
            Add_page_title_menu_Click(null,null);
            BackColor = Color.FromArgb(50, 50, 50);
            foreach (ToolStripMenuItem item in writtenbook_rclick_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.FromArgb(255,255,255);
            }
            foreach (ToolStripMenuItem item in writtenbook_title_menu.Items)
            {
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.BackgroundImage = btn_img;
                item.Click += ClickSound;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.DropDownOpened += ItemDropOpened;
                item.DropDownClosed += ItemDropClosed;
                for (int i = 0; i < item.DropDownItems.Count; i++)
                {
                    item.DropDownItems[i].ForeColor = Color.FromArgb(255, 255, 255);
                    item.DropDownItems[i].BackgroundImage = btn_img;
                    item.DropDownItems[i].Click += ClickSound;
                    item.DropDownItems[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            SoundPlayer.Play();
        }

        private void ItemDropOpened(object sender,EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(0,0,0);
        }

        private void ItemDropClosed(object sender,EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(255,255,255);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.每一句的事件只会生效已选中的标签页内容\r\n" +
                "2.而字体属性会全部生效\r\n"+
                "3.长按字体属性区可显示预览效果");
        }

        private void Add_page_title_menu_Click(object sender, EventArgs e)
        {
            page a_page = new page();
            page_tab.TabPages.Add(a_page.page_tab.SelectedTab);
            page_tab.SelectedIndex = page_tab.TabPages.Count-1;
            page_tab.SelectedTab.Text = "第" + page_tab.TabPages.Count + "页";

            #region 动态显示文本效果
            a_page.font_property_box.MouseDown += (a,b) => {
                CheckedListBox this_obj = a as CheckedListBox;

                //更新预览文本
                TextBox current_text_box =  page_tab.SelectedTab.Controls.Find("sentence_content", true)[0] as TextBox;
                display_txt.Text = current_text_box.Text.Trim() == ""?"Minecraft": Regex.Match(current_text_box.Text,@"(.*)").ToString();

                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y+30);
                color_panel.AutoSize = true;
                color_panel.Height = 30;
                if (display_txt.Parent != color_panel)
                    color_panel.Controls.Add(display_txt);
                display_txt.Font = new Font(Font,FontStyle.Bold | FontStyle.Italic);
                color_panel.BringToFront();
                color_panel.Visible = true;
            };

            a_page.font_property_box.MouseUp += (a,b) => {
                color_panel.Visible = false;
            };

            a_page.font_property_box.MouseMove += (a, b) => {
                CheckedListBox this_obj = a as CheckedListBox;
                CheckedListBox color_box = this_obj.Parent.Controls.Find("font_color_box", true)[0] as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y+30);
                FontStyle display_style = FontStyle.Regular;
                foreach (string item in this_obj.CheckedItems)
                {
                    if(item == "bold")
                        display_style |= FontStyle.Bold;
                    if (item == "italic")
                        display_style |= FontStyle.Italic;
                    if(item == "underlined")
                        display_style |= FontStyle.Underline;
                    if(item == "strikethrough")
                        display_style |= FontStyle.Strikeout;
                }

                if (color_box.SelectedIndex >= 0 && color_box.SelectedIndex < (color_box.Items.Count - 1))
                    display_txt.ForeColor = Colors[color_box.SelectedIndex];
                display_txt.Font = new Font(Font,display_style);
                color_panel.BackColor = Color.Empty;
                color_panel.BringToFront();
            };
            #endregion

            #region 动态显示颜色
            a_page.font_color_box.MouseMove += (a,b) => 
            {
                CheckedListBox this_obj = a as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X+this_obj.Location.X+30, MousePos.Y);
                if(this_obj.SelectedIndex>=0 && this_obj.SelectedIndex<(this_obj.Items.Count-1))
                color_panel.BackColor = Colors[this_obj.SelectedIndex];
            };
            
            a_page.font_color_box.MouseUp += (a,b) => {
                color_panel.Visible = false;
            };
            
            a_page.font_color_box.MouseDown += (a, b) =>
            {
                CheckedListBox this_obj = a as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X+30, MousePos.Y);
                if (this_obj.SelectedIndex >= 0 && this_obj.SelectedIndex < (this_obj.Items.Count - 1))
                    color_panel.BackColor = Colors[this_obj.SelectedIndex];
                color_panel.Size = new Size(50, 50);
                color_panel.Controls.Clear();
                color_panel.Visible = true;
                color_panel.BringToFront();
            };

            a_page.font_color_box.SelectedIndexChanged += (a,b) => {
                CheckedListBox this_obj = a as CheckedListBox;
                this_obj.Parent.Parent.Controls.Add(color_panel);
                if (this_obj.SelectedIndex >= 0 && this_obj.SelectedIndex < (this_obj.Items.Count - 1))
                    color_panel.BackColor = Colors[this_obj.SelectedIndex];
            };
            #endregion
        }

        private void Add_sentence_title_menu_Click(object sender, EventArgs e)
        {
            sentence sen = new sentence();
            TabControl sentence_tc = page_tab.SelectedTab.Controls.Find("sentence_page",true)[0] as TabControl;

            #region 动态显示文本效果
            sen.font_property_box.MouseDown += (a, b) => {
                //更新预览文本
                TextBox current_text_box = page_tab.SelectedTab.Controls.Find("sentence_content", true)[0] as TextBox;
                display_txt.Text = current_text_box.Text.Trim() == "" ? "Minecraft" : Regex.Match(current_text_box.Text, @"(.*)").ToString();

                CheckedListBox this_obj = a as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y + 30);
                color_panel.AutoSize = true;
                color_panel.Height = 30;
                if (display_txt.Parent != color_panel)
                    color_panel.Controls.Add(display_txt);
                display_txt.Font = new Font(Font, FontStyle.Bold | FontStyle.Italic);
                color_panel.BringToFront();
                color_panel.Visible = true;
            };

            sen.font_property_box.MouseUp += (a, b) => {
                color_panel.Visible = false;
            };

            sen.font_property_box.MouseMove += (a, b) => {
                CheckedListBox this_obj = a as CheckedListBox;
                CheckedListBox color_box = this_obj.Parent.Controls.Find("font_color_box", true)[0] as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y + 30);
                FontStyle display_style = FontStyle.Regular;
                foreach (string item in this_obj.CheckedItems)
                {
                    if (item == "bold")
                        display_style |= FontStyle.Bold;
                    if (item == "italic")
                        display_style |= FontStyle.Italic;
                    if (item == "underlined")
                        display_style |= FontStyle.Underline;
                    if (item == "strikethrough")
                        display_style |= FontStyle.Strikeout;
                }

                if (color_box.SelectedIndex >= 0 && color_box.SelectedIndex < (color_box.Items.Count - 1))
                    display_txt.ForeColor = Colors[color_box.SelectedIndex];
                display_txt.Font = new Font(Font, display_style);
                color_panel.BackColor = Color.Empty;
                color_panel.BringToFront();
            };
            #endregion

            #region 动态显示颜色
            sen.font_color_box.MouseMove += (a, b) =>
            {
                CheckedListBox this_obj = a as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y);
                if (this_obj.SelectedIndex >= 0 && this_obj.SelectedIndex < this_obj.Items.Count)
                    color_panel.BackColor = Colors[this_obj.SelectedIndex];
            };

            sen.font_color_box.MouseUp += (a, b) => {
                color_panel.Visible = false;
            };

            sen.font_color_box.MouseDown += (a, b) =>
            {
                CheckedListBox this_obj = a as CheckedListBox;
                MousePos = this_obj.PointToClient(this_obj.PointToScreen(b.Location));
                color_panel.Location = new Point(MousePos.X + this_obj.Location.X + 30, MousePos.Y);
                if (this_obj.SelectedIndex >= 0 && this_obj.SelectedIndex < this_obj.Items.Count)
                    color_panel.BackColor = Colors[this_obj.SelectedIndex];
                color_panel.Size = new Size(50,50);
                color_panel.Visible = true;
                color_panel.BringToFront();
            };

            sen.font_color_box.SelectedIndexChanged += (a, b) => {
                CheckedListBox this_obj = a as CheckedListBox;
                color_panel.Controls.Clear();
                this_obj.Parent.Parent.Controls.Add(color_panel);
                if (this_obj.SelectedIndex >= 0 && this_obj.SelectedIndex < this_obj.Items.Count)
                    color_panel.BackColor = Colors[this_obj.SelectedIndex];
            };
            #endregion
            
            sentence_tc.TabPages.Add(sen.sentence_page.SelectedTab);
            sentence_tc.SelectedIndex++;
            sentence_tc.SelectedTab.Text = "第"+sentence_tc.TabPages.Count+"句";
        }

        private void Delete_page_title_menu_Click(object sender, EventArgs e)
        {
            page_tab.TabPages.RemoveAt(page_tab.SelectedIndex);
        }

        private void Delete_sentence_title_menu_Click(object sender, EventArgs e)
        {
            TabControl sentence_tc = page_tab.SelectedTab.Controls.Find("sentence_page", true)[0] as TabControl;
            sentence_tc.TabPages.RemoveAt(sentence_tc.SelectedIndex);
        }

        private void Clear_page_title_menu_Click(object sender, EventArgs e)
        {
            page_tab.TabPages.Clear();
        }

        private void Clear_sentence_title_menu_Click(object sender, EventArgs e)
        {
            TabControl sentence_tc = page_tab.SelectedTab.Controls.Find("sentence_page", true)[0] as TabControl;
            sentence_tc.TabPages.Clear();
        }

        private void Add_page_rclick_menu_Click(object sender, EventArgs e)
        {
            Add_page_title_menu_Click(null,null);
        }

        private void Add_sentence_rclick_menu_Click(object sender, EventArgs e)
        {
            Add_sentence_title_menu_Click(null,null);
        }

        private void Delete_page_rclick_menu_Click(object sender, EventArgs e)
        {
            Delete_page_title_menu_Click(null,null);
        }

        private void Delete_sentence_rclick_menu_Click(object sender, EventArgs e)
        {
            Delete_sentence_title_menu_Click(null,null);
        }

        private void Clear_page_rclick_menu_Click(object sender, EventArgs e)
        {
            Clear_page_title_menu_Click(null,null);
        }

        private void Clear_sentence_rclick_menu_Click(object sender, EventArgs e)
        {
            Clear_sentence_title_menu_Click(null,null);
        }

        private void Version1_12_Click(object sender, EventArgs e)
        {
            version1_13.Checked = !version1_12.Checked;
        }

        private void Version1_13_Click(object sender, EventArgs e)
        {
            version1_12.Checked = !version1_13.Checked;
        }

        private string SpawnEvent(TabPage event_page)
        {
            string result = "";
            switch (event_page.Name)
            {
                case "click_event_tab":
                    {
                        result = ",\\\"clickEvent\\\":{";
                        //获取指令内容引用
                        TextBox cmd_content = event_page.Controls.Find("command_box", true)[0] as TextBox;
                        //获取运行命令引用
                        RadioButton run_btn = event_page.Controls.Find("run_btn", true)[0] as RadioButton;
                        //获取建议命令引用
                        RadioButton suggest_btn = event_page.Controls.Find("suggest_btn", true)[0] as RadioButton;
                        //获取链接文本框引用
                        TextBox url_box = event_page.Controls.Find("url_box", true)[0] as TextBox;
                        //获取换页文本框引用
                        NumericUpDown page_index = event_page.Controls.Find("page_index", true)[0] as NumericUpDown;
                        string cmd_action = "\\\"action\\\":" + (suggest_btn.Checked ? "suggest" : (run_btn.Checked ? "run" : "")) + "_command,\\\"value\\\":";
                        if (cmd_content.Enabled)
                        {
                            string cmd_value = "\\\"/"+Regex.Escape(cmd_content.Text).Replace("\\ "," ") +"\\\"";
                            result += cmd_action + cmd_value+"}";
                        }
                        if(url_box.Enabled)
                        {
                            cmd_action = "\\\"action\\\":\\\"open_url\\\",\\\"value\\\":";
                            string url_value = "\\\"/"+Regex.Escape(url_box.Text) +"\\\"";
                            result += cmd_action + url_value + "}";
                        }
                        if(page_index.Enabled)
                        {
                            cmd_action = "\\\"action\\\":\\\"change_page\\\",\\\"value\\\":";
                            string page_value = "\\\""+page_index.Value+"\\\"";
                            result += cmd_action + page_value + "}";
                        }
                        return result;
                    }
                case "hover_event_tab":
                    {
                        result = ",\\\"hoverEvent\\\":{";
                        string cmd_action = "\\\"action\\\":\\\"show_";
                        //获取显示文本的引用
                        RadioButton display_text = event_page.Controls.Find("show_text", true)[0] as RadioButton;
                        //获取显示物品的引用
                        RadioButton display_item = event_page.Controls.Find("show_item", true)[0] as RadioButton;
                        //获取显示实体的引用
                        RadioButton display_entity = event_page.Controls.Find("show_entity", true)[0] as RadioButton;
                        //获取显示内容的引用
                        TextBox display_box = event_page.Controls.Find("display_box", true)[0] as TextBox;
                        if (display_text.Checked)
                            cmd_action += "text\\\",\\\"value\\\":";
                        if (display_item.Checked)
                            cmd_action += "item\\\",\\\"contents\\\":{";
                        if (display_entity.Checked)
                            cmd_action += "entity\\\",\\\"contents\\\":{";
                        string cmd_value = "";
                        if(display_item.Checked)
                        cmd_value = "\\\"id\\\":\\\""+Regex.Match(display_box.Text, "(.*)") +"\\\"}}";
                        if (display_entity.Checked)
                            cmd_value = "\\\"type\\\":\\\"" + Regex.Match(display_box.Text, "(.*)") + "\\\",\\\"id\\\":\\\""+UuidHelper.NewUuidString()+"\\\"}}";
                        if(display_text.Checked)
                            cmd_value = "\\\"" + Regex.Match(display_box.Text, "(.*)") + "\\\"}";
                        result += cmd_action + cmd_value;
                        return result;
                    }
                case "insert_text_tab":
                    {
                        //获取插入的控件引用
                        TextBox insert_box = event_page.Controls.Find("insert_box", true)[0] as TextBox;
                        result = ",\\\"insertion\\\":\\\""+Regex.Escape(insert_box.Text)+"\\\"";
                        return result;
                    }
            }
            return result;
        }

        private void Click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存成书标题
            string title_value = title_box.Text;
            //保存成书作者名
            string author_value = auchor_box.Text;
            //保存每一页的数据
            List<string> page_info = new List<string> { };
            #region 遍历每一页
            foreach (TabPage a_page in page_tab.TabPages)
            {
                //搜索句子控件的引用
                TabControl sentence_tab = a_page.Controls.Find("sentence_page", true)[0] as TabControl;
                //保存每一句的数据
                List<string> sentence_info = new List<string> { };
                foreach (TabPage a_sen in sentence_tab.TabPages)
                {
                    //搜索内容文本框的引用
                    TextBox content_text_box = a_sen.Controls.Find("sentence_content", true)[0] as TextBox;
                    //搜索字体样式控件的引用
                    CheckedListBox font_style = a_sen.Controls.Find("font_property_box", true)[0] as CheckedListBox;
                    //搜索字体颜色控件的引用
                    CheckedListBox font_color = a_sen.Controls.Find("font_color_box",true)[0] as CheckedListBox;
                    //保存字体样式信息
                    string font_style_string = "";
                    //保存字体颜色信息
                    string font_color_string = font_color.CheckedItems.Count>0? ",\\\"color\\\":" + "\\\"" + font_color.CheckedItems[0].ToString() + "\\\"" :"";
                    //遍历样式控件成员,合并字符串
                    foreach (string item in font_style.CheckedItems)
                    {
                        font_style_string += ",\\\""+item +"\\\""+ ":true";
                    }
                    //合并样式信息
                    string style_string = font_style_string .Trim()!=""|| font_color_string.Trim()!=""? font_style_string + font_color_string :"";

                    //搜索字体标签页控件
                    TabControl property_tab = a_sen.Controls.Find("sentence_property_tab", true)[0] as TabControl;
                    string event_string = "";
                    if (property_tab.SelectedIndex != 0)
                        event_string = SpawnEvent(property_tab.SelectedTab);
                    sentence_info.Add((sentence_tab.TabPages.IndexOf(a_sen) == 0?"\\\"\\\",":"") + "{\\\"text\\\":\\\""+ Regex.Match(content_text_box.Text,@"(.*)").ToString()+"\\\""+ style_string+event_string+"},");
                }
                sentence_info[sentence_info.Count - 1] = sentence_info[sentence_info.Count - 1].TrimEnd(',');
                string sentences = "";
                foreach (string a_sen in sentence_info)
                {
                    sentences += a_sen;
                }
                    page_info.Add("\"["+ sentences + "]\",");
            }
            
            #region 生成成书
            string result;
            command_result wb_result;
            if(version1_12.Checked)
            {
                result = "/give @p minecraft:written_book 1 0 ";
                string page_string = "";
                foreach (string item in page_info)
                {
                    page_string += item;
                }
                page_string = page_string.TrimEnd(',');
                string nbt_string = "{title:\""+ title_value + "\",author:\""+author_value+"\",pages:["+ page_string + "]}";
                result += nbt_string;
                wb_result = new command_result("成书命令",new List<string> { result });
                wb_result.Show();
            }
            if(version1_13.Checked)
            {
                result = "/give @p minecraft:written_book";
                string page_string = "";
                foreach (string item in page_info)
                {
                    page_string += item;
                }
                page_string = page_string.TrimEnd(',');
                string nbt_string = "{title:\"" + title_value + "\",author:\"" + author_value + "\",pages:[" + page_string + "]}";
                result += nbt_string;
                wb_result = new command_result("成书命令", new List<string> { result });
                wb_result.Show();
            }
            #endregion
            
            #endregion
        }
    }
}
