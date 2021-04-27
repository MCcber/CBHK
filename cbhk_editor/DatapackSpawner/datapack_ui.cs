using cbhk_editor.ToolClasses;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.DatapackSpawner
{
    public partial class Datapack_ui : Form
    {
        //管家主页
        Form parent_form;
        //在数据包页按下鼠标右键
        bool ModifyPack = false;
        //按钮图片
        Image btn_img = Image.FromFile(Application.StartupPath+ "\\ButtonsBgImages\\button.png");
        //点击音效
        SoundPlayer click_sound;
        //历史路径
        string history_path = "";
        //是否允许重命名
        bool rename = true;
        //重命名时鼠标按下所在的标签页坐标
        Point PageLocation;
        //保存鼠标按下时数据包所在的标签页
        TabPage DPMouseDownPage = null;
        //保存鼠标按下时函数所在的标签页
        TabPage FunctionMouseDownPage = null;
        public Datapack_ui(Form this_obj, SoundPlayer soundplayer)
        {
            InitializeComponent();
            parent_form = this_obj;
            click_sound = soundplayer;
            InitUISetting();
        }

        private void InitUISetting()
        {
            BackColor = Color.FromArgb(50,50,50);
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            datapack_tc.TabPages.Clear();
            Add_pack_title_menu_Click(null,null);
            click_to_return.Click += (a,b) => 
            {
                parent_form.TopMost = true;
                parent_form.WindowState = FormWindowState.Normal;
                parent_form.Show();
                parent_form.TopMost = false;
                Close();
            };
            foreach (ToolStripMenuItem item in dp_title_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.White;
                item.Click += ClickSound;
                item.DropDownOpened += Item_DropDownOpened;
                item.DropDownClosed += Item_DropDownClosed;
                foreach (ToolStripMenuItem SubItem in item.DropDownItems)
                {
                    SubItem.BackgroundImage = btn_img;
                    SubItem.BackgroundImageLayout = ImageLayout.Stretch;
                    SubItem.ForeColor = Color.White;
                    SubItem.Click += ClickSound;
                    foreach (ToolStripMenuItem SubSubItem in SubItem.DropDownItems)
                    {
                        SubSubItem.BackgroundImage = btn_img;
                        SubSubItem.BackgroundImageLayout = ImageLayout.Stretch;
                        SubSubItem.ForeColor = Color.White;
                        SubSubItem.Click += ClickSound;
                    }
                }
            }

            #region 引用历史文件路径
            if (File.Exists(Application.StartupPath + "\\Settings\\datapack_history_path.ini"))
                history_path = File.ReadAllText(Application.StartupPath + "\\Settings\\datapack_history_path.ini", new UTF8Encoding(false));
            #endregion

            if (File.Exists(Application.StartupPath + "\\Settings\\datapack.ini"))
            {
                
                #region 导入历史数据包
                string[] RecentFiles = Array.Empty<string>();
                RecentFiles = File.ReadAllLines(Application.StartupPath + "\\Settings\\datapack.ini", new UTF8Encoding(false));
                for (int i = 0; i < RecentFiles.Length; i++)
                {
                    ToolStripMenuItem a_recent_file = new ToolStripMenuItem()
                    {
                        Text = RecentFiles[i]
                    };
                    a_recent_file.Click += (a, b) =>
                    {
                        if (Directory.Exists(a_recent_file.Text))
                            Open_a_datapack(a_recent_file.Text);
                        else
                        {
                            recent_packs.DropDownItems.Remove(a_recent_file);
                        }
                    };
                    if (Directory.Exists(a_recent_file.Text))
                        recent_packs.DropDownItems.Add(a_recent_file);
                }
                #endregion

                #region 更新文件路径
                string UpdateRecentFiles = "";
                foreach (ToolStripMenuItem item in recent_packs.DropDownItems)
                {
                    UpdateRecentFiles += item.Text + "\r\n";
                }
                File.WriteAllText(Application.StartupPath + "\\Settings\\datapack.ini", UpdateRecentFiles, new UTF8Encoding(false));
                #endregion
            }
        }

        private void Item_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.White;
        }

        private void Item_DropDownOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.Black;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void Add_pack_title_menu_Click(object sender, EventArgs e)
        {
            #region 新建数据包头信息区
            datapack_head dp_head = new datapack_head(click_sound);
            TableLayoutPanel this_obj = null;
            foreach (Control tb in dp_head.Controls)
            {
                if(tb is TableLayoutPanel)
                {
                    this_obj = tb as TableLayoutPanel;
                    break;
                }
            }
            this_obj.Dock = DockStyle.Top;
            this_obj.BackColor = Color.FromArgb(50,50,50);
            TabPage new_pack = new TabPage()
            {
                Text = "newpack"+(datapack_tc.TabPages.Count+1)
            };
            new_pack.Controls.Add(this_obj);
            datapack_tc.TabPages.Add(new_pack);
            datapack_tc.SelectedTab = new_pack;
            this_obj.Height = datapack_tc.SelectedTab.Height / 2;
            #endregion

            #region 新建数据包导航
            ToolStripMenuItem a_pack = new ToolStripMenuItem()
            {
                Text = new_pack.Text,
                ForeColor = Color.FromArgb(255, 255, 255),
                BackColor = Color.Transparent,
                BackgroundImage = btn_img,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            a_pack.Click += PackNavigation;
            Navigation.DropDownItems.Add(a_pack);
            #endregion

            //新建函数页
            Add_function_title_menu_Click(null,null);
        }

        private void Add_function_title_menu_Click(object sender, EventArgs e)
        {
            if (datapack_tc.SelectedTab == null)
                return;

            #region 新建函数页
            TabControl function_tab = new TabControl()
            {
                Name = "function_tab",
                Location = new Point(0, datapack_tc.SelectedTab.Height / 2),
                Size = new Size(datapack_tc.SelectedTab.Width, datapack_tc.SelectedTab.Height / 2),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(255, 255, 255)
            };
            //搜索当前数据包是否有函数页
            bool HaveFunctions = false;
            foreach (Control item in datapack_tc.SelectedTab.Controls)
            {
                if(item is TabControl)
                {
                    function_tab = item as TabControl;
                    HaveFunctions = true;
                    break;
                }
            }
            function_tab.MouseDown += (a, b) => {
                ModifyPack = false;
                Cursor = Cursors.Hand;
                PageLocation.X = 10;
                PageLocation.Y = datapack_tc.Height / 2+35;
                FunctionMouseDownPage = GetTabPageByTab(b.Location, a as TabControl);
            };
            function_tab.MouseUp += (a,b) => {
                Cursor = Cursors.Default;
                TabPage MouseUpPage = GetTabPageByTab(b.Location, a as TabControl);
                if (FunctionMouseDownPage != null && MouseUpPage != null)
                {
                    //保存索引
                    int DownIndex = function_tab.TabPages.IndexOf(FunctionMouseDownPage);
                    int UpIndex = function_tab.TabPages.IndexOf(MouseUpPage);
                    //保存引用
                    TabPage NewDownPage = FunctionMouseDownPage;
                    TabPage NewUpPage = MouseUpPage;
                    //交换覆盖
                    function_tab.TabPages[DownIndex] = NewUpPage;
                    function_tab.TabPages[UpIndex] = NewDownPage;
                    function_tab.SelectedTab = NewDownPage;
                }
            };
            TabPage function_page = new TabPage()
            {
                Text = "new_func"+(function_tab.TabPages.Count+1)+".mcfunction",
                Name = "function_page",
                BackColor = Color.Transparent,
            };
            
            #region 为初始化函数和高频函数添加成员
            ComboBox init_function = datapack_tc.SelectedTab.Controls.Find("init_function", true)[0] as ComboBox;
            ComboBox loop_function = datapack_tc.SelectedTab.Controls.Find("loop_function", true)[0] as ComboBox;
            init_function.Items.Add(function_page.Text);
            loop_function.Items.Add(function_page.Text);
            #endregion

            RichTextBox function_box = new RichTextBox()
            {
                Name = "function_box",
                Multiline = true,
                Dock = DockStyle.Fill,
                Font = Font,
                BackColor = Color.FromArgb(50,50,50),
                ForeColor = Color.FromArgb(255,255,255)
            };
            function_page.Controls.Add(function_box);
            function_tab.TabPages.Add(function_page);
            if(!HaveFunctions)
            datapack_tc.SelectedTab.Controls.Add(function_tab);
            #endregion

            #region 新建函数导航
            ToolStripMenuItem function_navigation = new ToolStripMenuItem()
            {
                Text = function_page.Text,
                ForeColor = Color.FromArgb(255, 255, 255),
                BackColor = Color.Transparent,
                BackgroundImage = btn_img,
                BackgroundImageLayout = ImageLayout.Stretch
            };
            function_navigation.Click += FunctionNavigation;
            //遍历导航,搜索当前的数据包并添加新的函数导航
            foreach (ToolStripMenuItem item in Navigation.DropDownItems)
            {
                if(item.Text == datapack_tc.SelectedTab.Text)
                {
                    item.DropDownItems.Add(function_navigation);
                    return;
                }
            }
            #endregion

            #region 为初始化函数和高频函数添加成员
            init_function =  datapack_tc.SelectedTab.Controls.Find("init_function", true)[0] as ComboBox;
            loop_function = datapack_tc.SelectedTab.Controls.Find("loop_function", true)[0] as ComboBox;
            init_function.Items.Add(function_page.Text);
            loop_function.Items.Add(function_page.Text);
            #endregion
        }

        /// <summary>
        /// 根据坐标获取对应的标签页
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        private TabPage GetTabPageByTab(Point point,TabControl this_obj)
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

        private void Datapack_tc_MouseDown(object sender, MouseEventArgs e)
        {
            ModifyPack = true;
            Cursor = Cursors.Hand;
            PageLocation = datapack_tc.GetTabRect(datapack_tc.SelectedIndex).Location;
            PageLocation.Y += datapack_tc.Location.Y;
            DPMouseDownPage = GetTabPageByTab(e.Location,sender as TabControl);
        }
        private void Datapack_tc_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            TabPage MouseUpPage = GetTabPageByTab(e.Location,sender as TabControl);
            if(DPMouseDownPage != null && MouseUpPage!=null)
            {
                //保存索引
                int DownIndex = datapack_tc.TabPages.IndexOf(DPMouseDownPage);
                int UpIndex = datapack_tc.TabPages.IndexOf(MouseUpPage);
                //保存引用
                TabPage NewDownPage = DPMouseDownPage;
                TabPage NewUpPage = MouseUpPage;
                //交换覆盖
                datapack_tc.TabPages[DownIndex] = NewUpPage;
                datapack_tc.TabPages[UpIndex] = NewDownPage;
                datapack_tc.SelectedTab = NewDownPage;
            }
        }

        private void Add_new_Click(object sender, EventArgs e)
        {
            if (ModifyPack)
            {
                Add_pack_title_menu_Click(null, null);
            }
            else
                Add_function_title_menu_Click(null,null);
        }

        private void Delete_current_Click(object sender, EventArgs e)
        {
            if(ModifyPack)
            {
                //移除对应的导航
                foreach (ToolStripMenuItem item in Navigation.DropDownItems)
                {
                    if (item.Text == datapack_tc.SelectedTab.Text)
                    {
                        Navigation.DropDownItems.Remove(item);
                        break;
                    }
                }
                //移除数据包
                datapack_tc.TabPages.Remove(datapack_tc.SelectedTab);
            }
            else
            {
                TabControl tc;
                foreach (Control item in datapack_tc.SelectedTab.Controls)
                {
                    if(item is TabControl)
                    {
                        tc = item as TabControl;
                        #region 移除初始化函数与高频函数成员
                        ComboBox init_function = datapack_tc.SelectedTab.Controls.Find("init_function", true)[0] as ComboBox;
                        ComboBox loop_function = datapack_tc.SelectedTab.Controls.Find("loop_function", true)[0] as ComboBox;
                        foreach (string func in init_function.Items)
                        {
                            if (func == tc.SelectedTab.Text)
                            {
                                init_function.Items.Remove(func);
                                break;
                            }
                        }
                        foreach (string func in loop_function.Items)
                        {
                            if (func == tc.SelectedTab.Text)
                            {
                                loop_function.Items.Remove(func);
                                break;
                            }
                        }
                        #endregion
                        //移除对应的导航
                        foreach (ToolStripMenuItem menu_item in Navigation.DropDownItems)
                        {
                            if (menu_item.Text == datapack_tc.SelectedTab.Text)
                            {
                                foreach (ToolStripMenuItem sub_item in menu_item.DropDownItems)
                                {
                                    if (sub_item.Text == tc.SelectedTab.Text)
                                    {
                                        menu_item.DropDownItems.Remove(sub_item);
                                        break;
                                    }
                                }
                            }
                        }
                        if (tc.TabPages.Count>0)
                        tc.TabPages.Remove(tc.SelectedTab);
                    }
                }
            }
        }

        private void Clear_current_Click(object sender, EventArgs e)
        {
            if (ModifyPack)
            {
                datapack_tc.TabPages.Clear();
                //移除对应的导航
                Navigation.DropDownItems.Clear();
            }
            else
            {
                TabControl tc;
                foreach (Control item in datapack_tc.SelectedTab.Controls)
                {
                    if (item is TabControl)
                    {
                        tc = item as TabControl;
                        ComboBox init_function = datapack_tc.SelectedTab.Controls.Find("init_function", true)[0] as ComboBox;
                        ComboBox loop_function = datapack_tc.SelectedTab.Controls.Find("loop_function", true)[0] as ComboBox;
                        init_function.Items.Clear();
                        loop_function.Items.Clear();
                        //移除对应的导航
                        foreach (ToolStripMenuItem menu_item in Navigation.DropDownItems)
                        {
                            if (menu_item.Text == datapack_tc.SelectedTab.Text)
                            {
                                menu_item.DropDownItems.Clear();
                                break;
                            }
                        }
                        tc.TabPages.Clear();
                    }
                }
            }
        }

        private void Open_a_datapack(string SelectedPath)
        {
            #region 调用添加数据包事件
            Add_pack_title_menu_Click(null, null);
            #endregion

            #region 获取数据包的所有文件
            List<FileInformation> pack_file_list = DirectoryAllFiles.GetAllFiles(new DirectoryInfo(SelectedPath), NeedAdd: false);
            //去重
            pack_file_list = pack_file_list.Distinct(new CompareFile()).ToList();
            #endregion

            #region 更改标题菜单的按钮前景色
            save_as.ForeColor = close_pack.ForeColor = close_all_pack.ForeColor = save.ForeColor = save_all.ForeColor = Color.White;
            #endregion

            datapack_tc.SelectedTab.Text = Path.GetFileName(SelectedPath);
            datapack_tc.SelectedTab.Name = "extern_file";
            datapack_tc.SelectedTab.Tag = SelectedPath;
            Navigation.DropDownItems[datapack_tc.SelectedIndex].Text = datapack_tc.SelectedTab.Text;

            #region 搜索各类文件控件引用
            TextBox NBT_files = datapack_tc.SelectedTab.Controls.Find("nbt_file_pathes",  true)[0] as TextBox;
            TextBox adv_files = datapack_tc.SelectedTab.Controls.Find("adv_file_pathes",  true)[0] as TextBox;
            TextBox lt_files = datapack_tc.SelectedTab.Controls.Find("lt_file_pathes",  true)[0] as TextBox;
            TextBox recipe_files = datapack_tc.SelectedTab.Controls.Find("recipe_file_pathes",  true)[0] as TextBox;
            TextBox tag_files = datapack_tc.SelectedTab.Controls.Find("tag_file_pathes",  true)[0] as TextBox;
            NumericUpDown pack_version = datapack_tc.SelectedTab.Controls.Find("pack_version",  true)[0] as NumericUpDown;
            TextBox pack_description = datapack_tc.SelectedTab.Controls.Find("pack_description",  true)[0] as TextBox;
            ComboBox init_func = datapack_tc.SelectedTab.Controls.Find("init_function",  true)[0] as ComboBox;
            ComboBox loop_func = datapack_tc.SelectedTab.Controls.Find("loop_function",  true)[0] as ComboBox;
            TabControl functions = datapack_tc.SelectedTab.Controls.Find("function_tab",  true)[0] as TabControl;
            functions.SelectedIndex = 0;
            #endregion

            //保存函数名
            List<string> function_files = new List<string> { };

            string TheMainFolder = "";
            string[] mainFolderPath = Directory.GetDirectories(SelectedPath + "\\data\\");
            string[] array = mainFolderPath;
            foreach (string path in array)
            {
                if (Directory.Exists(path + "\\advancements") || Directory.Exists(path + "\\functions") || Directory.Exists(path + "\\loot_tables") || Directory.Exists(path + "\\recipes") || Directory.Exists(path + "\\structures"))
                {
                    TheMainFolder = Path.GetFileName(path);
                }
            }
            TextBox MainFolder = datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0] as TextBox;
            MainFolder.Text = TheMainFolder;
            MainFolder.Enabled = false;
            click_to_spawn.Enabled = false;
            foreach (FileInformation item in pack_file_list)
            {
                if (Regex.Match("structures",Regex.Escape(item.FilePath)).Success)
                {
                    NBT_files.Text += item.FilePath + ";";
                }
                if (Regex.Match("advancements", Regex.Escape(item.FilePath)).Success)
                {
                    adv_files.Text += item.FilePath + ";";
                }
                if (Regex.Match("loot_tables", Regex.Escape(item.FilePath)).Success)
                {
                    lt_files.Text += item.FilePath + ";";
                }
                if (Regex.Match("recipes", Regex.Escape(item.FilePath)).Success)
                {
                    MessageBox.Show("here");
                    recipe_files.Text += item.FilePath + ";";
                }
                if (Regex.Match("tags", Regex.Escape(item.FilePath)).Success && !Regex.Match("minecraft", Regex.Escape(item.FilePath)).Success)
                {
                    tag_files.Text += item.FilePath + ";";
                }
                DirectoryInfo root_path = new DirectoryInfo(SelectedPath);
                FileInfo[] pack_meta = root_path.GetFiles();
                FileInfo[] array2 = pack_meta;
                foreach (FileInfo meta in array2)
                {
                    if (Path.GetExtension(Path.GetFileName(meta.FullName)) == ".mcmeta")
                    {
                        FileInfo meta_file = new FileInfo(meta.FullName);
                        try
                        {
                            StreamReader meta_reader = meta_file.OpenText();
                            JObject meta_data = JObject.Parse(meta_reader.ReadToEnd());
                            meta_reader.Close();
                            pack_version.Value = int.Parse(meta_data["pack"]["pack_format"].ToString());
                            pack_version.Tag = pack_version.Value;
                            pack_description.Text = meta_data["pack"]["description"].ToString();
                            pack_description.Tag = pack_description.Text;
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("数据包的pack.mcmeta文件内容可能为空\r\n" + a.Message);
                        }
                    }
                }
                if (Path.GetExtension(item.FileName) == ".mcfunction")
                {
                    FileInfo mcfunc_file = new FileInfo(item.FilePath);
                    StreamReader func_reader = mcfunc_file.OpenText();
                    Add_function_title_menu_Click(null, null);
                    ToolStripMenuItem func_items = Navigation.DropDownItems[datapack_tc.SelectedIndex] as ToolStripMenuItem;
                    func_items.Text = datapack_tc.SelectedTab.Text;
                    functions.SelectedTab.Text = item.FileName;
                    func_items.DropDownItems[functions.SelectedIndex].Text = functions.SelectedTab.Text;
                    RichTextBox funTxt = functions.SelectedTab.Controls.Find("function_box",  true)[0] as RichTextBox;
                    string function_content = func_reader.ReadToEnd();
                    func_reader.Close();
                    funTxt.Text = function_content;
                    functions.SelectedIndex++;
                    function_files.Add(Path.GetFileNameWithoutExtension(item.FileName));
                }
            }
            //清空函数集合并添加外部的函数集合
            init_func.Items.Clear();
            loop_func.Items.Clear();
            foreach (string item in function_files)
            {
                init_func.Items.Add(item);
                loop_func.Items.Add(item);
            }
            init_func.Items.Add("new_func"+(init_func.Items.Count+1)+".mcfunction");
            loop_func.Items.Add("new_func" + (init_func.Items.Count + 1) + ".mcfunction");
        }

        private void Open_datapack_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog select_folder = new FolderBrowserDialog
            {
                Description = "请选择一个数据包",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = false,
                SelectedPath = (history_path != "") ? history_path : ""
            };
            if (select_folder.ShowDialog() == DialogResult.OK && select_folder.SelectedPath.Length > 0)
            {
                history_path = select_folder.SelectedPath;
                //写入历史路径配置
                File.WriteAllText(Application.StartupPath+"\\Settings\\datapack_history_path.ini", select_folder.SelectedPath, new UTF8Encoding(false));
                if (Directory.Exists(select_folder.SelectedPath + "\\data") && File.Exists(select_folder.SelectedPath + "\\pack.mcmeta"))
                {
                    Open_a_datapack(select_folder.SelectedPath);
                }
                else
                {
                    MessageBox.Show("所选的目录不为数据包");
                }
                rename = false;
            }
        }

        private void PackNavigation(object sender , EventArgs e)
        {
            click_sound.Play();
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            foreach (TabPage item in datapack_tc.TabPages)
            {
                if(item.Text == this_obj.Text)
                {
                    datapack_tc.SelectedTab = item;
                    break;
                }
            }
        }

        private void FunctionNavigation(object sender, EventArgs e)
        {
            click_sound.Play();
            //当前对象
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            //当前对象的直接父级
            ToolStripMenuItem parent = this_obj.OwnerItem as ToolStripMenuItem;
            foreach (TabPage item in datapack_tc.TabPages)
            {
                if(item.Text == parent.Text)
                {
                    datapack_tc.SelectedTab = item;
                    //搜索目标数据包页的函数页
                    TabControl function_area = item.Controls.Find("function_tab", true)[0] as TabControl;
                    foreach (TabPage page in function_area.TabPages)
                    {
                        if(page.Text == this_obj.Text)
                        {
                            function_area.SelectedTab = page;
                            return;
                        }
                    }
                }
            }
        }

        private void Rename_rclick_Click(object sender, EventArgs e)
        {
            if (!rename)
                return;
            TabControl functions = datapack_tc.SelectedTab.Controls.Find("function_tab", true)[0] as TabControl;
            TextBox rename_box = new TextBox()
            {
                Location = new Point(PageLocation.X + (functions.ItemSize.Width * functions.SelectedIndex),PageLocation.Y),
                Size = new Size(100,21)
            };
            rename_box.PreviewKeyDown += (a,b) => 
            {
                if (b.KeyCode == Keys.Escape)
                    b.IsInputKey = true;
            };
            if (ModifyPack)
                rename_box.Tag = datapack_tc.SelectedTab.Text;
            else
                rename_box.Tag = functions.SelectedTab.Text;

            rename_box.KeyDown += (a, b) =>
            {
                if (b.KeyCode == Keys.Escape)
                {
                    Controls.Remove(rename_box);
                    return;
                }
                if (b.KeyCode == Keys.Enter)
                {
                    ToolStripMenuItem this_obj = null;
                    ToolStripMenuItem this_func = null;
                    if (ModifyPack)
                    {
                        foreach (ToolStripMenuItem menuitem in Navigation.DropDownItems)
                        {
                            if (menuitem.Text == rename_box.Tag.ToString())
                            {
                                this_obj = menuitem;
                                break;
                            }
                        }
                        foreach (TabPage item in datapack_tc.TabPages)
                        {
                            if (item.Text == rename_box.Tag.ToString())
                            {
                                this_obj.Text = rename_box.Text;
                                item.Text = rename_box.Text;
                                Controls.Remove(rename_box);
                                return;
                            }
                        }
                    }
                    else
                    {
                        
                        #region 搜索对应的导航
                        foreach (ToolStripMenuItem menuitem in Navigation.DropDownItems)
                        {
                            if (menuitem.Text == datapack_tc.SelectedTab.Text)
                            {
                                foreach (ToolStripMenuItem subitem in menuitem.DropDownItems)
                                {
                                    if (subitem.Text == functions.SelectedTab.Text)
                                    {
                                        this_func = subitem;
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        #endregion
                        
                        foreach (TabPage item in functions.TabPages)
                        {
                            if (item.Text == rename_box.Tag.ToString())
                            {
                                #region 修改初始化函数和高频函数
                                ComboBox init_function = datapack_tc.SelectedTab.Controls.Find("init_function", true)[0] as ComboBox;
                                ComboBox loop_function = datapack_tc.SelectedTab.Controls.Find("loop_function", true)[0] as ComboBox;
                                for (int i = 0; i < init_function.Items.Count; i++)
                                {
                                    if (init_function.Items[i].ToString() == item.Text)
                                    {
                                        init_function.Items.RemoveAt(i);
                                        init_function.Items.Add(rename_box.Text + ".mcfunction");
                                    }
                                }
                                for (int i = 0; i < loop_function.Items.Count; i++)
                                {
                                    if (loop_function.Items[i].ToString() == item.Text)
                                    {
                                        loop_function.Items.RemoveAt(i);
                                        loop_function.Items.Add(rename_box.Text + ".mcfunction");
                                    }
                                }
                                #endregion

                                #region 修改导航
                                this_func.Text = rename_box.Text + ".mcfunction";
                                #endregion
                                
                                item.Text = rename_box.Text + ".mcfunction";
                                Controls.Remove(rename_box);
                                return;
                            }
                        }
                    }
                }
            };

            Controls.Add(rename_box);
            rename_box.BringToFront();
            rename_box.Focus();
        }

        private void Head_area_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            TableLayoutPanel this_table = null;
            foreach (Control item in datapack_tc.SelectedTab.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    this_table = item as TableLayoutPanel;
                    break;
                }
            }
            if (this_obj.Checked)
            {
                this_table.Height = datapack_tc.SelectedTab.Height;
            }
            else
                this_table.Height = datapack_tc.SelectedTab.Height / 2;
            this_table.BringToFront();
        }

        private void Function_area_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            TabControl tc = datapack_tc.SelectedTab.Controls.Find("function_tab", true)[0] as TabControl;

            if(this_obj.Checked)
            {
                tc.Location = new Point(tc.Location.X, 0);
                tc.Size = new Size(tc.Size.Width, datapack_tc.SelectedTab.Height);
            }
            else
            {
                tc.Location = new Point(tc.Location.X, datapack_tc.SelectedTab.Height / 2);
                tc.Size = new Size(tc.Size.Width, datapack_tc.SelectedTab.Height/2);
            }
            tc.BringToFront();
        }

        private void MoveFiles(Control textbox, string targetPath)
        {
            string[] array = textbox.Text.Split(';');
            foreach (string item in array)
            {
                if (item.Trim() != "")
                {
                    File.Copy(item, targetPath + "\\" + Path.GetFileName(item));
                }
            }
        }

        private void WriteFileByPath(string FilePath, string content)
        {
            try
            {
                UTF8Encoding uTF8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
                FileStream file_writer = File.Open(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                byte[] file_bytes = uTF8.GetBytes(content);
                file_writer.Write(file_bytes, 0, file_bytes.Length);
                file_writer.Flush();
                file_writer.Dispose();
            }
            catch
            {
            }
        }

        private void StartSpawn(string SelectPath)
        {
            string CanSpawn = datapack_tc.SelectedTab.Name ?? "";
            if (CanSpawn != "extern_file")
            {
                TextBox adv_files = datapack_tc.SelectedTab.Controls.Find("adv_file_pathes",  true)[0] as TextBox;
                TextBox nbt_files = datapack_tc.SelectedTab.Controls.Find("nbt_file_pathes",  true)[0] as TextBox;
                TextBox lt_files = datapack_tc.SelectedTab.Controls.Find("lt_file_pathes",  true)[0] as TextBox;
                TextBox recipe_files = datapack_tc.SelectedTab.Controls.Find("recipe_file_pathes",  true)[0] as TextBox;
                TextBox tag_files = datapack_tc.SelectedTab.Controls.Find("tag_file_pathes",  true)[0] as TextBox;
                NumericUpDown version = datapack_tc.SelectedTab.Controls.Find("pack_version",  true)[0] as NumericUpDown;
                TextBox description = datapack_tc.SelectedTab.Controls.Find("pack_description",  true)[0] as TextBox;
                ComboBox init_func = datapack_tc.SelectedTab.Controls.Find("init_function",  true)[0] as ComboBox;
                ComboBox loop_func = datapack_tc.SelectedTab.Controls.Find("loop_function",  true)[0] as ComboBox;
                TextBox main_folder_txt = datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0] as TextBox;
                TabControl functions = datapack_tc.SelectedTab.Controls.Find("function_tab",  true)[0] as TabControl;
                Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text);
                Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data");
                if (adv_files.Text.Trim() != "" && adv_files.Text.Trim() != "进度文件")
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\advancements");
                }
                if (nbt_files.Text.Trim() != "" && nbt_files.Text.Trim() != "结构文件")
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\structures");
                }
                if (lt_files.Text.Trim() != "" && lt_files.Text.Trim() != "战利品表文件")
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\loot_tables");
                }
                if (recipe_files.Text.Trim() != "" && recipe_files.Text.Trim() != "配方文件")
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\recipes");
                }
                if (tag_files.Text.Trim() != "" && tag_files.Text.Trim() != "标签文件")
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\tags");
                }
                if (functions.TabPages.Count > 0)
                {
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\functions");
                    Directory.CreateDirectory(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions\\");
                }
                if (adv_files.Text.Trim() != "" && adv_files.Text.Trim() != "进度文件")
                {
                    MoveFiles(adv_files, SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\advancements");
                }
                if (nbt_files.Text.Trim() != "" && nbt_files.Text.Trim() != "结构文件")
                {
                    MoveFiles(nbt_files, SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\structures");
                }
                if (lt_files.Text.Trim() != "" && lt_files.Text.Trim() != "战利品表文件")
                {
                    MoveFiles(lt_files, SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\loot_tables");
                }
                if (recipe_files.Text.Trim() != "" && recipe_files.Text.Trim() != "配方文件")
                {
                    MoveFiles(recipe_files, SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\recipes");
                }
                if (tag_files.Text.Trim() != "" && tag_files.Text.Trim() != "标签文件")
                {
                    MoveFiles(tag_files, SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\tags");
                }
                if (Directory.Exists(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions"))
                {
                    using (new FileStream(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions\\load.json", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read | FileShare.Write | FileShare.Delete))
                    {
                        WriteFileByPath(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions\\load.json", "{\"replace\":false,\"values\":[\"" + main_folder_txt.Text + ":" + Path.GetFileNameWithoutExtension(init_func.Text) + "\"]}");
                    }
                    using (new FileStream(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions\\tick.json", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read | FileShare.Write | FileShare.Delete))
                    {
                        WriteFileByPath(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\minecraft\\tags\\functions\\tick.json", "{\"replace\":false,\"values\":[\"" + main_folder_txt.Text + ":" + Path.GetFileNameWithoutExtension(loop_func.Text) + "\"]}");
                    }
                }
                if (Directory.Exists(SelectPath + "\\" + datapack_tc.SelectedTab.Text))
                {
                    using (new FileStream(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\pack.mcmeta", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read | FileShare.Write | FileShare.Delete))
                    {
                        WriteFileByPath(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\pack.mcmeta", "{\r\n\"pack\":{\r\n\"pack_format\":" + version.Value.ToString() + ",\r\n\"description\":\"" + description.Text + "\"}}");
                    }
                }
                if (functions.TabPages.Count > 0)
                {
                    foreach (TabPage func_page in functions.TabPages)
                    {
                        using (new FileStream(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\functions\\" + func_page.Text, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read | FileShare.Write | FileShare.Delete))
                        {
                            WriteFileByPath(SelectPath + "\\" + datapack_tc.SelectedTab.Text + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder", true)[0].Text + "\\functions\\" + func_page.Text, func_page.Controls.Find("function_box",  true)[0].Text);
                        }
                    }
                }
                datapack_tc.SelectedTab.Name = "extern_file";
                datapack_tc.SelectedTab.Tag = SelectPath + "\\" + datapack_tc.SelectedTab.Text;
            }
        }

        private void Click_to_spawn_Click(object sender, EventArgs e)
        {
            string CanSpawn = (datapack_tc.SelectedTab.Name != null) ? datapack_tc.SelectedTab.Name : "";
            if (!(CanSpawn != "extern_file"))
            {
                return;
            }
            FolderBrowserDialog select_folder = new FolderBrowserDialog
            {
                Description = "请选择数据包的生成位置:",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };
            if (select_folder.ShowDialog() == DialogResult.OK && select_folder.SelectedPath.Length > 0 && Directory.Exists(select_folder.SelectedPath))
            {
                ComboBox init_func = datapack_tc.SelectedTab.Controls.Find("init_function",  true)[0] as ComboBox;
                ComboBox loop_func = datapack_tc.SelectedTab.Controls.Find("loop_function",  true)[0] as ComboBox;
                TextBox main_folder_txt = datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0] as TextBox;
                if (init_func.Text.Trim() == "" || loop_func.Text.Trim() == "")
                {
                    MessageBox.Show(datapack_tc.SelectedTab.Text + "的初始化函数文件或高频函数文件为空,此数据包生成失败!");
                    return;
                }
                if (main_folder_txt.Text.Trim() == "")
                {
                    MessageBox.Show(datapack_tc.SelectedTab.Text + "的主文件夹名为空,该数据包生成失败!");
                    return;
                }
                StartSpawn(select_folder.SelectedPath);
                rename = false;
                save.Enabled = save_as.Enabled = close_pack.Enabled = close_all_pack.Enabled = true;
                click_to_return.Enabled = false;
            }
            else if (select_folder.SelectedPath.Length > 0 || Directory.Exists(select_folder.SelectedPath))
            {
                MessageBox.Show("已选择的路径长度为0或选中路径不存在", "生成失败", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Datapack_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(datapack_tc.TabPages.Count>0)
            save_as.ForeColor = close_pack.ForeColor = close_all_pack.ForeColor = save.ForeColor = save_all.ForeColor = datapack_tc.SelectedTab.Name == "extern_file" ? Color.White : Color.Gray;
        }

        private void Close_pack_Click(object sender, EventArgs e)
        {
            if (datapack_tc.SelectedTab.Name == "extern_file")
            {
                ToolStripMenuItem a_recent_file = new ToolStripMenuItem()
                {
                    Text = datapack_tc.SelectedTab.Tag.ToString()
                };
                a_recent_file.Click += (a,b) => 
                {
                    if (Directory.Exists(a_recent_file.Text))
                        Open_a_datapack(a_recent_file.Text);
                    else
                    {
                        recent_packs.DropDownItems.Remove(a_recent_file);
                        MessageBox.Show("该数据包不存在,已删除路径");
                    }
                };
                bool HaveCurrent = true;
                foreach (ToolStripMenuItem item in recent_packs.DropDownItems)
                {
                    if(item.Text == a_recent_file.Text)
                    {
                        HaveCurrent = false;
                        break;
                    }
                }
                if(HaveCurrent)
                recent_packs.DropDownItems.Add(a_recent_file);
                datapack_tc.TabPages.RemoveAt(datapack_tc.SelectedIndex);
            }
        }

        private void Close_all_pack_Click(object sender, EventArgs e)
        {
            foreach (TabPage item in datapack_tc.TabPages)
            {
                datapack_tc.SelectedTab = item;
                Close_pack_Click(null,null);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            if (datapack_tc.SelectedTab.Name == "extern_file")
            {
                List<FileInformation> pack_files = DirectoryAllFiles.GetAllFiles(new DirectoryInfo(datapack_tc.SelectedTab.Tag.ToString()), NeedAdd: true);
                TabControl functions = datapack_tc.SelectedTab.Controls.Find("function_tab",  true)[0] as TabControl;
                List<string> new_func_txts = new List<string>();
                List<string> exist_func_txts = new List<string>();
                foreach (FileInformation item in pack_files)
                {
                    exist_func_txts.Add(item.FileName);
                }
                foreach (TabPage func_page in functions.TabPages)
                {
                    new_func_txts.Add(func_page.Text);
                }
                new_func_txts = new_func_txts.Except(exist_func_txts).ToList();
                foreach (string new_func in new_func_txts)
                {
                    foreach (TabPage func_page in functions.TabPages)
                    {
                        if (func_page.Text == new_func)
                        {
                            WriteFileByPath(datapack_tc.SelectedTab.Tag.ToString() + "\\data\\" + datapack_tc.SelectedTab.Controls.Find("main_folder",  true)[0].Text + "\\functions\\" + new_func, func_page.Controls.Find("function_box",  true)[0].Text);
                        }
                    }
                }
                foreach (FileInformation file in pack_files)
                {
                    if (Path.GetExtension(file.FileName) == ".mcfunction")
                    {
                        foreach (TabPage a_func in functions.TabPages)
                        {
                            if (a_func.Text == file.FileName)
                            {
                                WriteFileByPath(file.FilePath, a_func.Controls.Find("function_box",  true)[0].Text);
                            }
                        }
                    }
                    if (Path.GetExtension(file.FileName) == ".mcmeta")
                    {
                        StreamReader file_reader = File.OpenText(file.FilePath);
                        TreeNode pack_meta = new TreeNode();
                        Bind_TreeView pack_file = new Bind_TreeView();
                        pack_file.BindTreeView(pack_meta, file_reader.ReadToEnd());
                        NumericUpDown version = datapack_tc.SelectedTab.Controls.Find("pack_version",  true)[0] as NumericUpDown;
                        TextBox description = datapack_tc.SelectedTab.Controls.Find("pack_description",  true)[0] as TextBox;
                        foreach (TreeNode pack in pack_meta.Nodes)
                        {
                            if (pack.Text.Trim() == "pack")
                            {
                                foreach (TreeNode pack_info in pack.Nodes)
                                {
                                    if (pack_info.Text.Contains("pack_format"))
                                    {
                                        pack_info.Text = "packformat:" + version.Value.ToString();
                                    }
                                    if (pack_info.Text.Contains("description"))
                                    {
                                        pack_info.Text = "description:" + description.Text;
                                    }
                                }
                            }
                        }
                        string new_meta_string = "{\r\n\"pack\":{\r\n";
                        foreach (TreeNode pack in pack_meta.Nodes)
                        {
                            if (pack.Text.Trim() == "pack")
                            {
                                foreach (TreeNode pack_info in pack.Nodes)
                                {
                                    if (pack_info.Text.Contains("pack_format"))
                                    {
                                        new_meta_string+=  "packformat:" + version.Value.ToString() + ",\r\n";
                                    }
                                    if (pack_info.Text.Contains("description"))
                                    {
                                        new_meta_string+=  "description:\"" + description.Text + "\"";
                                    }
                                }
                            }
                        }
                        new_meta_string += "}}";
                        WriteFileByPath(file.FilePath, new_meta_string);
                    }
                }
            }
        }

        private void Save_as_Click(object sender, EventArgs e)
        {
            Click_to_spawn_Click(null,null);
        }

        private void Save_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datapack_tc.TabPages.Count; i++)
            {
                datapack_tc.SelectedIndex = i;
                Save_Click(null,null);
            }
        }

        private void Datapack_ui_FormClosing(object sender, FormClosingEventArgs e)
        {
            string RecentFiles="";
            foreach (ToolStripMenuItem item in recent_packs.DropDownItems)
            {
                RecentFiles += item.Text + "\r\n";
            }
            //写入历史数据包配置
            File.WriteAllText(Application.StartupPath+ "\\Settings\\datapack.ini", RecentFiles,new UTF8Encoding(false));
        }

        private void Spawner_all_Click(object sender, EventArgs e)
        {
            int current_index = datapack_tc.SelectedIndex;
            FolderBrowserDialog select_folder = new FolderBrowserDialog
            {
                Description = "请选择数据包的生成位置:",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = (history_path != "") ? history_path : ""
            };
            if (select_folder.ShowDialog() == DialogResult.OK && select_folder.SelectedPath.Length > 0)
            {
                foreach (TabPage dp_page in datapack_tc.TabPages)
                {
                    if (dp_page.Name == "extern_file")
                        continue;
                    datapack_tc.SelectedTab = dp_page;
                    ComboBox init_func = datapack_tc.SelectedTab.Controls.Find("init_function", searchAllChildren: true)[0] as ComboBox;
                    ComboBox loop_func = datapack_tc.SelectedTab.Controls.Find("loop_function", searchAllChildren: true)[0] as ComboBox;
                    TextBox main_folder_txt = datapack_tc.SelectedTab.Controls.Find("main_folder", searchAllChildren: true)[0] as TextBox;
                    if (init_func.Text.Trim() == "" || loop_func.Text.Trim() == "")
                    {
                        MessageBox.Show(datapack_tc.SelectedTab.Text + "的初始化函数文件或高频函数文件为空,此数据包生成失败!");
                    }
                    else if (main_folder_txt.Text.Trim() == "")
                    {
                        MessageBox.Show(datapack_tc.SelectedTab.Text + "的主文件夹名为空,该数据包生成失败!");
                    }
                    else
                    {
                        StartSpawn(select_folder.SelectedPath);
                        datapack_tc.SelectedTab.Name = "extern_file";
                    }
                }
                rename = false;
                datapack_tc.SelectedIndex = current_index;
            }
        }
    }
}
