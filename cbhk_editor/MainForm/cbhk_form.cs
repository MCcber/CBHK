using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Reflection;
using System.Text;
using System.Drawing.Imaging;
using cbhk_editor.welcome_form;
using System.Linq;
using Timer = System.Windows.Forms.Timer;
using cbhk_editor.ToolClasses;

namespace cbhk_editor.MainForm
{
    public partial class Cbhk_form : Form
    {
        //按钮图像
        Image btnImg = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //启动项设置
        List<string> StartSettings = new List<string> { };
        //个性化设置
        List<string> IndiviSettings = new List<string> { };
        //获取生成器图片列表
        string[] SpawnerBgPathes;
        //轮播图当前索引
        int LinkPlayerIndex = 0;
        //标签页图片链表
        List<Image> mainTabImgs = new List<Image> { };
        //轮播图图片链表
        List<PictureBox> LinkImages = new List<PictureBox> { };
        //判断字符串是否为网址
        Regex IsUrlWithoutHttp = new Regex(@"^([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$");
        Regex IsUrl = new Regex(@"^(http(s)?)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$");
        //生成器图片链表
        List<Image> SpawnerBgImages = new List<Image> { };
        //音效对象
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        //是否改变了样式
        bool SizeChanging = false;
        //当前字体
        Font CurrentFont;
        //当前选中的链接按钮索引
        int SelectedButtonIndex = 0;
        //图片按钮框
        TableLayoutPanel button_frame;
        //保存主页行数据
        private int spawner_row = 0;

        //保存图片路径
        public List<string> ImageLinksPathes = new List<string> { };
        //保存链接
        public List<string> UrlInfo = new List<string> { };
        //保存描述
        public List<string> ImageLinksDescription = new List<string> { };
        //保存指令语法树
        public static TreeView Commands = new TreeView();
        //保存方块id集合
        public static TreeView Blocks = new TreeView();
        //保存注册表
        public static TreeView register = new TreeView();
        //保存实体NBT数据
        public static TreeView EntityNBTs = new TreeView();

        public Cbhk_form()
        {
            InitializeComponent();

            if (SystemInformation.Network)
            {
                #region 初始化登录窗体
                //SignIn signIn = new SignIn();
                //ShowInTaskbar = false;
                //cbhk_notify.Visible = false;
                //WindowState = FormWindowState.Minimized;
                //if (signIn.ShowDialog() == DialogResult.OK)
                //{

                //    #region 绑定头像框点击事件
                //    link_tip.SetToolTip(user_head_box, signIn.user_name_string + "的主页");
                //    user_head_box.Click += (a, b) =>
                //    {
                //        Process.Start("https://mc.metamo.cn/u/" + signIn.user_id + "/");
                //    };
                //    signIn.Dispose();
                //    #endregion
                //}
                //else
                //    Environment.Exit(0);
                #endregion
            }

            #region 开启欢迎窗体
            WelcomeForm welcome = new WelcomeForm();
            if (welcome.ShowDialog() == DialogResult.OK)
            {
                #region 引用所提供的TreeView
                foreach (TreeNode item in welcome.register.Nodes[0].Nodes)
                    register.Nodes.Add(item);
                foreach (TreeNode item in welcome.command.Nodes[0].Nodes)
                    Commands.Nodes.Add(item);
                foreach (TreeNode item in welcome.block.Nodes[0].Nodes)
                    Blocks.Nodes.Add(item);
                foreach (TreeNode item in welcome.EntityNBT.Nodes[0].Nodes)
                    EntityNBTs.Nodes.Add(item);

                #endregion

                #region 开启主窗体窗体
                ShowInTaskbar = true;
                cbhk_notify.Visible = true;
                WindowState = FormWindowState.Normal;
                TopMost = true;
                Show();
                TopMost = false;
                #endregion

                #region 自动解析msi包
                //string strInput = @"msiexec /i " + Application.StartupPath + "\\cbhk.setup.msi" + " /qn";
                //Process p = new Process();
                //p.StartInfo.FileName = "cmd.exe";
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardInput = true;
                //p.StartInfo.RedirectStandardOutput = true;
                //p.StartInfo.RedirectStandardError = true;
                //p.StartInfo.CreateNoWindow = true;
                //p.Start();
                //p.StandardInput.WriteLine(strInput + "&exit");
                //p.StandardInput.AutoFlush = true;
                //p.WaitForExit();
                //p.Close();
                #endregion

                #region 自动提取下载直链
                //该网址为自动解析直链API
                //UpdateForm uf = new UpdateForm("https://api.xinac.net/lanzous?url=", Application.StartupPath+"\\downloadurl.txt");
                //if(uf.ShowDialog() == DialogResult.OK)
                //{
                //    MessageBox.Show("success");
                //}
                #endregion
            }
            #endregion

            //初始化命令管家UI
            InitUISettings();
            //初始化命令管家启动项
            InitStartUpSetting();

            #region 开机自启
            AutoStart.SetMeStart(cbhk_properties.AutoStart);
            #endregion

            #region 自动更新
            #endregion
        }

        /// <summary>
        /// 初始化UI设置
        /// </summary>
        private void InitUISettings()
        {
            cbhk_notify.Icon = Icon;
            cbhk_notify.BalloonTipText = "命令管家";
            cbhk_title_menu.BackColor = Color.FromArgb(50, 50, 50);
            spawners_button_area.BackColor = link_page.BackColor = Color.FromArgb(50, 50, 50);
            if(File.Exists(Application.StartupPath + "\\UserHeadImages\\user_head.png"))
            user_head_box.BackgroundImage = Image.FromFile(Application.StartupPath + "\\UserHeadImages\\user_head.png");
            else
                user_head_box.BackgroundImage = Image.FromFile(Application.StartupPath+ "\\UserHeadImages\\command_block.png");
            CurrentFont = Font;

            //计算主页行列数据
            int spawner_count = Directory.GetFiles(Application.StartupPath+ "\\MainSpawnersBgImages").Length;
            int option_number = 0;
            if (spawner_count % 3 != 0)
                option_number = -1;
            spawner_row = spawner_count % 3 + spawner_count / 3 + option_number;
            string[] files = Directory.GetFiles(Application.StartupPath + "\\MainSpawnersBgImages");

            //订阅字体变色和点击事件
            foreach (ToolStripMenuItem item in cbhk_title_menu.Items)
            {
                item.Click += Title_button_Clicked;
                item.DropDownOpened += Title_button_DropOpened;
                item.DropDownClosed += Title_button_DropClosed;
                foreach (ToolStripMenuItem subItem in item.DropDownItems)
                    subItem.Click += Title_button_Clicked;
            }
            //订阅标签页前景图
            string[] mainImagesArray = Directory.GetFiles(Application.StartupPath + "\\MainTabPageBgImages\\");
            foreach (string img in mainImagesArray)
            {
                Image a_img = Image.FromFile(img);
                mainTabImgs.Add(a_img);
            }
            //订阅重绘
            main_tab.DrawItem += Main_tab_DrawItem;

            //设置教程链接
            List<string> class_links = new List<string> { };
            string[] links = Directory.GetFiles(Application.StartupPath+ "\\ClassLinks");
            for (int i = 0; i < cb_class.DropDownItems.Count; i++)
            {
                string url = File.ReadAllText(links[i]);
                cb_class.DropDownItems[i].Click += (a,b) => {
                    Process.Start(url);
                };
            }
            //获取生成器图片列表
            SpawnerBgPathes = Directory.GetFiles(Application.StartupPath + "\\MainSpawnersBgImages");
            List<FileNameString> spawnerBgPathSorter = new List<FileNameString> { };
            //分配值给比较器
            for (int i = 0; i < SpawnerBgPathes.Length; i++)
                spawnerBgPathSorter.Add(new FileNameString() { FileName = Path.GetFileNameWithoutExtension(SpawnerBgPathes[i]), FilePath = SpawnerBgPathes[i],FileIndex = i });
            FileNameComparer fileNameComparer = new FileNameComparer { };
            spawnerBgPathSorter.Sort(fileNameComparer);
            
            foreach (FileNameString item in spawnerBgPathSorter)
            {
                SpawnerBgImages.Add(Image.FromFile(item.FilePath));
            }

            //设置列的数量
            int columnCount = 3;

            //生成器编号
            int index = 0;
            //放置生成器按钮
            for (int i = 0; i < spawner_row; i++)
            {
                //判断是否需要增加行
                if (i > (spawners_button_area.RowCount - 1))
                    spawners_button_area.RowCount++;
                for (int j = 0; j < columnCount; j++)
                {
                    //不生成多余的按钮
                    if (i>=1 && (i*3 + j+1) > SpawnerBgImages.Count)
                        break;
                    if (j > (spawners_button_area.ColumnCount - 1))
                        spawners_button_area.ColumnCount++;
                    Button a_spawner = new Button() {
                    Text = "",
                    Name = "spawner"+index,
                    BackgroundImage = index<SpawnerBgImages.Count? SpawnerBgImages[index] :null,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                    };
                    index++;
                    a_spawner.FlatAppearance.BorderSize = 0;
                    a_spawner.FlatAppearance.MouseDownBackColor = a_spawner.FlatAppearance.MouseOverBackColor = Color.Transparent;
                    //订阅点击事件
                    
                    a_spawner.Click += SpawnerClick;
                    spawners_button_area.Controls.Add(a_spawner,j,i);
                }
            }
            //调用尺寸变化结束事件自动排版
            SizeChanging = true;
            Cbhk_form_ResizeEnd(null, null);
        }

        /// <summary>
        /// 初始化启动项与个性化
        /// </summary>
        private void InitStartUpSetting()
        {
            #region 个性化
            if(File.Exists(Application.StartupPath + "\\Settings\\indivi_sets.ini"))
            {
                string[] Settings = File.ReadAllText(Application.StartupPath + "\\Settings\\indivi_sets.ini", new UTF8Encoding(false)).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string a_set in Settings)
                {
                    int StartPoint = a_set.Split(':')[0].Length + 1;
                    string content = a_set.Substring(StartPoint, a_set.Length - StartPoint);

                    //设置标题
                    if (a_set.Contains("Text:") && IndiviSettings.FindIndex(obj => obj.Contains("Text")) == -1)
                    {
                        Text = "命令管家|" + content;
                        cbhk_properties.Title = Text;
                    }

                    //设置轮播图播放速度
                    if (a_set.Contains("CarouselMapSpeed:") && IndiviSettings.FindIndex(obj => obj.Contains("CarouselMapSpeed")) == -1)
                    {
                        cbhk_properties.CarouseMapSpeed = int.Parse(content);
                        links_playing.Interval = cbhk_properties.CarouseMapSpeed;
                    }
                    else
                        links_playing.Interval = 1000;

                    //设置是否开机自启
                    if (a_set.Contains("AutoStart:") && IndiviSettings.FindIndex(obj => obj.Contains("AutoStart")) == -1)
                    {
                        cbhk_properties.AutoStart = bool.Parse(content);
                    }
                }
            }
            #endregion

            #region 启动项
            if (File.Exists(Application.StartupPath + "\\Settings\\startup_sets.ini"))
            {
                string[] Settings = File.ReadAllText(Application.StartupPath + "\\Settings\\startup_sets.ini",new UTF8Encoding(false)).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string a_set in Settings)
                {
                    int StartPoint = a_set.Split(':')[0].Length + 1;
                    string content = a_set.Substring(StartPoint, a_set.Length - StartPoint);
                    //设置启动音乐
                    if (a_set.Contains("Music:") && StartSettings.FindIndex(obj=>obj.Contains("Music"))==-1)
                    {
                        try
                        {
                            SoundPlayer start_music = new SoundPlayer(content);
                            cbhk_properties.Music = content;
                            start_music.Play();
                        }
                        catch(Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                    //设置可见性
                    if (a_set.Contains("Visible:") && StartSettings.FindIndex(obj => obj.Contains("Visible")) == -1)
                    {
                        cbhk_properties.Visible = int.Parse(content);
                    }
                    //设置是否缩小至托盘
                    if (a_set.Contains("NeedBackToNodify:") && StartSettings.FindIndex(obj => obj.Contains("NeedBackToNodify")) == -1)
                    {
                        cbhk_properties.NeedBackToNodify = bool.Parse(content);
                    }
                    //设置是否自动检测更新
                    if (a_set.Contains("AutoCheckUpdate:") && StartSettings.FindIndex(obj => obj.Contains("AutoCheckUpdate")) == -1)
                    {
                        cbhk_properties.AutoCheckUpdate = bool.Parse(content);
                    }
                }
            }
            #endregion
            //读取自定义链接
            if (Directory.Exists(Application.StartupPath+ "\\UrlLinks"))
            {
                string[] link_files = Directory.GetFiles(Application.StartupPath+"\\UrlLinks\\");
                for (int i = 0; i < link_files.Length; i++)
                {
                    if (Path.GetExtension(link_files[i]) == ".png")
                    {
                        ImageLinksPathes.Add(link_files[i]);
                        ImageLinksDescription.Add(Path.GetFileNameWithoutExtension(link_files[i]));
                    }
                    if (Path.GetExtension(link_files[i]) == ".txt")
                    {
                        //FileStream fileStream = new FileStream(link_files[i],FileMode.Open);
                        UrlInfo.Add(File.ReadAllText(link_files[i], new UTF8Encoding(false)));
                    }
                }
                //调用设置链接的方法
                SetCarouselmap();
            }
        }

        /// <summary>
        /// 设置可视化
        /// </summary>
        private void SetVisible()
        {
            switch (cbhk_properties.Visible)
            {
                case 1:
                    {
                        //最小化
                        WindowState = FormWindowState.Minimized;
                        ShowInTaskbar = true;
                        break;
                    }
                case 2:
                    {
                        ShowInTaskbar = false;
                        WindowState = FormWindowState.Minimized;
                        break;
                    }
            }
        }

        private void SpawnerClick(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            //处理生成器打开事件
            int spawnerIndex = int.Parse(Regex.Match(this_obj.Name, @"\d+").ToString());
            //利用反射调用对应的生成器
            var target_class = typeof(SpawnersManager);
            object instance = Activator.CreateInstance(target_class);
            MethodInfo[] methods = target_class.GetMethods();
            click_sound.Play();
            target_class.InvokeMember(methods[spawnerIndex].Name, BindingFlags.InvokeMethod, null, instance, new object[] { FindForm(), click_sound });
            SetVisible();
        }

        /// <summary>
        /// 子级点击后播放音效
        /// </summary>
        private void Title_button_Clicked(object sender,EventArgs e)
        {
            click_sound.Play();
        }

        /// <summary>
        /// 子级展开后变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Title_button_DropOpened(object sender,EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(0,0,0);
        }

        /// <summary>
        /// 子级收起后变色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Title_button_DropClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void Main_tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tc = sender as TabControl;
            SolidBrush backgroundBlack = new SolidBrush(Color.FromArgb(50, 50, 50));//Tab整体背景颜色
            SolidBrush tabPageBlack = new SolidBrush(Color.FromArgb(155, 50, 50, 50));//Tab选项卡背景颜色
            //填充背景色
            e.Graphics.FillRectangle(backgroundBlack, 0, main_tab.TabPages.Count * main_tab.ItemSize.Width, Width, Height);

            //填充选项卡颜色
            Rectangle rec1 = tc.GetTabRect(0);
            e.Graphics.FillRectangle(tabPageBlack, rec1);
            Rectangle rec2 = tc.GetTabRect(1);
            e.Graphics.FillRectangle(tabPageBlack, rec2);
            e.Graphics.DrawImage(mainTabImgs[e.Index], e.Bounds);
        }

        private void Cbhk_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //播放淡出动画
            Win32.AnimateWindow(Handle, 500, Win32.AW_SLIDE | Win32.AW_HIDE | Win32.AW_BLEND);

            #region 保存初始化设置
            //合并配置信息
            string start_sets = "";
            StartSettings = StartSettings.Distinct().ToList();
            foreach (string set in StartSettings)
                start_sets += set + "\r\n";
            //创建配置文件
            if(start_sets.Trim()!="")
            File.WriteAllText(Application.StartupPath + "\\Settings\\startup_sets.ini", start_sets, new UTF8Encoding(false));
            #endregion

            #region 保存自定义设置
            //合并配置信息
            string indivi_sets = "";
            IndiviSettings = IndiviSettings.Distinct().ToList();
            foreach (string set in IndiviSettings)
                indivi_sets += set + "\r\n";
            //创建配置文件
            if (indivi_sets.Trim() != "")
                File.WriteAllText(Application.StartupPath + "\\Settings\\indivi_sets.ini", indivi_sets, new UTF8Encoding(false));
            #endregion

            if (e.CloseReason == CloseReason.UserClosing && !cbhk_properties.NeedBackToNodify)
                cbhk_notify.Icon = null;
            else
            {
                e.Cancel = true;
                ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Cbhk_form_SizeChanged(object sender, EventArgs e)
        {
            #region 调整生成器按钮区域的行,列占比
            ColumnStyle columnStyle = new ColumnStyle(SizeType.Percent, 0.1f * spawners_button_area.ColumnCount);
            RowStyle rowStyle = new RowStyle(SizeType.Percent, 0.1f * spawners_button_area.RowCount);
            spawners_button_area.ColumnStyles.Add(columnStyle);
            spawners_button_area.RowStyles.Add(rowStyle);
            SizeChanging = true;
            #endregion

            #region 调整链接按钮框的位置
            if(button_frame!=null)
            button_frame.Location = new Point(link_page.Width / 2 - (LinkImages.Count * 25 / 2), link_page.Height - 60);
            #endregion
        }

        private void Cbhk_form_ResizeEnd(object sender, EventArgs e)
        {
            if (!SizeChanging)
                return;
            spawners_button_area.ColumnCount = 3;
            spawners_button_area.RowCount = spawner_row;
            spawners_button_area.ColumnStyles.Clear();
            spawners_button_area.RowStyles.Clear();
            for (int i = 0; i < spawners_button_area.ColumnCount; i++)
            {
                spawners_button_area.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.1f * spawners_button_area.ColumnCount));
            }
            for (int i = 0; i < spawners_button_area.RowCount; i++)
            {
                spawners_button_area.RowStyles.Add(new ColumnStyle(SizeType.Percent, 0.1f * spawners_button_area.RowCount));
            }
            SizeChanging = false;
        }

        #region 拦截windows底层消息然后重绘UI
        //const int WM_SYSCOMMAND = 0x112;
        //const int SC_MAXIMIZE = 0xF030;
        //public const int WM_NCLBUTTONDBLCLK = 0xA3;
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_SYSCOMMAND)
        //    {
        //        if (m.WParam.ToInt32() == SC_MAXIMIZE)
        //        {
        //            Cbhk_form_ResizeEnd(null,null);
        //            WindowState = FormWindowState.Maximized;
        //            return;
        //        }
        //    }
        //    if (m.Msg == WM_NCLBUTTONDBLCLK)
        //    {
        //        Cbhk_form_ResizeEnd(null, null);
        //        if (WindowState != FormWindowState.Maximized)
        //            WindowState = FormWindowState.Maximized;
        //        else
        //            WindowState = FormWindowState.Normal;
        //        return;
        //    }
        //    base.WndProc(ref m);
        //}
        #endregion

        private void 进群交流ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            join_group join_Group = new join_group();
        }

        private void 反馈BugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback_bugs feedback_Bugs = new feedback_bugs();
        }

        private void 关于编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_cbhk about = new about_cbhk();
        }

        /// <summary>
        /// 设置轮播图
        /// </summary>
        private void SetCarouselmap()
        {
            #region 设置轮播图数据
            //移除所有网址链接
            link_page.Controls.Clear();
            //添加图片文件至链表
            LinkImages.Clear();

            for (int i = 0; i < ImageLinksPathes.Count; i++)
            {
                if (File.Exists(ImageLinksPathes[i]) && (IsUrl.Match(UrlInfo[i]).Success || IsUrlWithoutHttp.Match(UrlInfo[i]).Success))
                {
                    PictureBox a_picture = new PictureBox()
                    {
                        BackgroundImage = Image.FromFile(ImageLinksPathes[i]),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Location = new Point(0, 0),
                        Dock = DockStyle.Fill,
                        Size = link_page.Size
                    };
                    link_tip.SetToolTip(a_picture,ImageLinksDescription[i]);
                    int currentIndex = i;
                    a_picture.Cursor = Cursors.Hand;
                    a_picture.Click += (a, b) => {
                        Process.Start(UrlInfo[currentIndex]);
                    };
                    LinkImages.Add(a_picture);
                    //创建图片文件
                    if (!File.Exists(Application.StartupPath + "\\UrlLinks\\" + ImageLinksDescription[i] + ".png"))
                    {
                        Image a_image = a_picture.BackgroundImage;
                        FileStream img_steam = new FileStream(Application.StartupPath + "\\UrlLinks\\" + ImageLinksDescription[i] + ".png", FileMode.Create);
                        a_image.Save(img_steam, ImageFormat.Png);
                    }
                    //创建链接文本文件
                    if(!File.Exists(Application.StartupPath + "\\UrlLinks\\" + ImageLinksDescription[i] + ".txt"))
                    File.WriteAllText(Application.StartupPath + "\\UrlLinks\\"+ ImageLinksDescription[i]+".txt", UrlInfo[currentIndex]);
                }
            }

            //添加图像框和按钮系统到链接页面
            //新建按钮框
            button_frame = new TableLayoutPanel
            {
                ColumnCount = LinkImages.Count,
                RowCount = 1,
                BackColor = Color.Transparent,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,
                Location = new Point(link_page.Width / 2 - (LinkImages.Count * 25 / 2), link_page.Height - 60)
            };

            #region 实例化按钮
            for (int i = 0; i < LinkImages.Count; i++)
            {
                link_page.Controls.Add(LinkImages[i]);
                Button img_btn = new Button()
                {
                    Size = new Size(25, 25),
                    Anchor = AnchorStyles.Left,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = i == 0 ? btnImg : null,
                    Cursor = Cursors.Hand
                };
                int currentIndex = i;
                //绑定点击事件
                img_btn.Click += (a, b) => {
                    click_sound.Play();
                    Button LastButton = button_frame.GetControlFromPosition(SelectedButtonIndex, 0) as Button;
                    LastButton.BackgroundImage = null;
                    SelectedButtonIndex = currentIndex;
                    LinkImages[currentIndex].BringToFront();
                    img_btn.BackgroundImage = btnImg;
                    button_frame.BringToFront();
                    Timer stop = new Timer()
                    {
                        Interval = 1000,
                        Enabled = true
                    };
                    links_playing.Enabled = false;
                    stop.Tick += (c, d) => {
                        LinkPlayerIndex = currentIndex;
                        links_playing.Enabled = true;
                        stop.Dispose();
                    };
                };
                button_frame.Controls.Add(img_btn, i, 0);
            }
            #endregion

            button_frame.Size = new Size(LinkImages.Count * 30+5, 30);
            link_page.Controls.Add(button_frame);
            button_frame.BringToFront();
            //轮播图速度
            links_playing.Interval = cbhk_properties.CarouseMapSpeed;
            #endregion
        }

        private void 个性化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            click_sound.Play();
            individualization indivi = new individualization(CurrentFont,click_sound,0);

            #region 设置默认值
            indivi.link_speed.Value = links_playing.Interval / 1000;
            indivi.auto_start.Checked = cbhk_properties.AutoStart;
            #endregion

            if (indivi.ShowDialog() == DialogResult.OK)
            {
                #region 标题文本
                if (indivi.diy_info.ForeColor != Color.FromArgb(168, 168, 168))
                {
                    cbhk_properties.Title = indivi.diy_info.Text;
                    Text = "命令管家|" + cbhk_properties.Title;
                    //标题信息
                    IndiviSettings.Add("Text:" + indivi.diy_info.Text);
                }
                #endregion

                #region 设置轮播图
                if (link_page.Controls.Count == 0)
                {
                    if (indivi.ClearLinks)
                        link_page.Controls.Clear();
                    ImageLinksPathes = indivi.ImageLinksPathes;
                    UrlInfo = indivi.UrlInfo;
                    ImageLinksDescription = indivi.ImageLinksDescription;
                    SetCarouselmap();
                }
                else
                if(link_page.Controls.Count>0)
                {
                    //添加新的链接
                    foreach (string a_path in indivi.ImageLinksPathes)
                        ImageLinksPathes.Add(a_path);
                    foreach (string a_url in indivi.UrlInfo)
                        UrlInfo.Add(a_url);
                    foreach (string a_description in indivi.ImageLinksDescription)
                        ImageLinksDescription.Add(a_description);
                    SetCarouselmap();
                    cbhk_properties.CarouseMapSpeed = indivi.link_speed.Value > 0 ? (int)indivi.link_speed.Value * 1000 : 1000;
                    IndiviSettings.Add("CarouselMapSpeed:" + cbhk_properties.CarouseMapSpeed);
                    links_playing.Interval = cbhk_properties.CarouseMapSpeed;
                }
                #endregion

                #region 设置字体
                if (indivi.load_font.Tag!=null && indivi.load_font.Tag.ToString().Trim()!="")
                {
                    Size current_size = cbhk_title_menu.Size;
                    foreach (ToolStripMenuItem a_item in cbhk_title_menu.Items)
                    {
                        a_item.Font = indivi.target_font;
                        foreach (ToolStripMenuItem subitem in a_item.DropDownItems)
                            subitem.Font = indivi.target_font;
                    }
                    cbhk_title_menu.Size = current_size;
                }
                #endregion

                #region 开机自启
                cbhk_properties.AutoStart = indivi.auto_start.Checked;
                IndiviSettings.Add("AutoStart:" + cbhk_properties.AutoStart);
                #endregion
            }
        }

        private void Main_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            click_sound.Play();
            TabControl tc = sender as TabControl;
            links_playing.Enabled = tc.SelectedIndex == 0;
            //if(!File.Exists(Application.StartupPath+ "\\Settings\\updateinfo.ini"))
            //{
            //    MessageBox.Show("1.对各大需要外接其他生成器的生成器进行了对接\n2.调整了成书生成器的生成逻辑");
            //    File.WriteAllText(Application.StartupPath + "\\Settings\\updateinfo.ini","");
            //}
        }

        private void Links_playing_Tick(object sender, EventArgs e)
        {
            if(button_frame!=null && LinkImages.Count>0)
            {
                LinkPlayerIndex++;
                if (LinkPlayerIndex > (button_frame.ColumnCount - 1))
                    LinkPlayerIndex = 0;
                Button LastButton = button_frame.GetControlFromPosition(SelectedButtonIndex, 0) as Button;
                LastButton.BackgroundImage = null;
                SelectedButtonIndex = LinkPlayerIndex;
                Button CurrentButton = button_frame.GetControlFromPosition(LinkPlayerIndex, 0) as Button;
                CurrentButton.BackgroundImage = btnImg;
                LinkImages[LinkPlayerIndex].BringToFront();
                button_frame.BringToFront();
            }
        }

        private void Exit_cbhk_Click(object sender, EventArgs e)
        {
            cbhk_notify.Icon = null;
            Dispose(true);
        }

        private void Open_cbhk_Click(object sender, EventArgs e)
        {
            TopMost = true;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Show();
            TopMost = false;
        }

        private void Cbhk_form_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(Handle, 500, Win32.AW_BLEND);
        }

        private void start_up_setting_click(object sender, EventArgs e)
        {
            click_sound.Play();
            individualization indivi = new individualization(CurrentFont, click_sound, 1);

            #region 设置默认值
            indivi.close_to_notify.Checked = cbhk_properties.NeedBackToNodify;
            indivi.check_update.Checked = cbhk_properties.AutoCheckUpdate;
            indivi.cbhk_visible.SelectedIndex = cbhk_properties.Visible;
            #endregion

            if (indivi.ShowDialog() == DialogResult.OK)
            {
                if (indivi.set_music.Tag != null)
                {
                    cbhk_properties.Music = indivi.set_music.Tag.ToString();
                    //初始化音乐
                    StartSettings.Add("Music:" + indivi.set_music.Tag.ToString());
                }

                //可见性
                cbhk_properties.Visible = indivi.cbhk_visible.SelectedIndex;
                StartSettings.Add("Visible:" + cbhk_properties.Visible);

                //关闭后缩小到托盘
                cbhk_properties.NeedBackToNodify = indivi.close_to_notify.Checked;
                StartSettings.Add("NeedBackToNodify:" + cbhk_properties.NeedBackToNodify);

                //自动更新
                cbhk_properties.AutoCheckUpdate = indivi.check_update.Checked;
                StartSettings.Add("AutoCheckUpdate:" + cbhk_properties.AutoCheckUpdate);
            }
        }
    }

    public class cbhk_properties
    {
        /// <summary>
        /// 标题
        /// </summary>
        public static string Title { get; set; }

        /// <summary>
        /// 音频文件路径
        /// </summary>
        /// 
        public static string Music { get; set; }
        /// <summary>
        /// 启动器可见性
        /// </summary>
        public static int Visible { get; set; }

        /// <summary>
        /// 是否缩小至托盘
        /// </summary>
        public static bool NeedBackToNodify { get; set; } = false;

        /// <summary>
        /// 自动更新
        /// </summary>
        public static bool AutoCheckUpdate { get; set; } = false;

        /// <summary>
        /// 轮播图播放速度
        /// </summary>
        public static int CarouseMapSpeed { get; set; } = 3000;

        /// <summary>
        /// 开机自启
        /// </summary>
        public static bool AutoStart { get; set; } = false;
    }

    #region 文件路径比较器
    public class FileNameString
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int FileIndex { get; set; }
    }

    public class FileNameComparer : IComparer<FileNameString>
    {
        public int Compare(FileNameString x, FileNameString y)
        {
            int x_number = int.Parse(Regex.Match(x.FileName, @"\d+").ToString());
            int y_number = int.Parse(Regex.Match(y.FileName, @"\d+").ToString());
            if (x_number < y_number)
                return -1;
            return 1;
        }
    }
    #endregion
}
