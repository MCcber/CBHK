using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner
{
    public partial class skill_ui : Form
    {
        Form parent_form;
        SoundPlayer click_sound = null;
        //按钮背景图
        Image btnimg = Image.FromFile(Application.StartupPath+ "\\ButtonsBgImages\\button.png");
        //判断哪些条件需要参数
        //List<int> entity_parameter = new List<int> { 0, 2 };
        //List<int> item_parameter = new List<int> { 0, 1, 2, 4 };

        #region 声明反射变量
        Type manager;
        MethodInfo[] skill_methods;
        #endregion
        public skill_ui(Form obj,SoundPlayer soundPlayer)
        {
            InitializeComponent();
            parent_form = obj;
            InitUISetting();
            click_sound = soundPlayer;
            #region 初始化技能管理器
            manager = Assembly.Load("cbhk_editor").GetType("cbhk_editor.SkillSpawner.SkillManager");
            skill_methods = manager.GetMethods();
            #endregion
        }

        private void InitUISetting()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            BackColor = Color.FromArgb(50, 50, 50);
            skill_tab.TabPages.Clear();
            click_to_return.Click += (a,b) => {
                parent_form.ShowInTaskbar = true;
                parent_form.WindowState = FormWindowState.Normal;
                parent_form.TopMost = true;
                parent_form.Show();
                parent_form.TopMost = false;
                Close();
            };

            foreach (ToolStripMenuItem a_item in skill_title_menu.Items)
            {
                a_item.ForeColor = Color.FromArgb(255, 255, 255);
                a_item.BackgroundImage = btnimg;
                a_item.BackgroundImageLayout = ImageLayout.Stretch;
                a_item.Click += (a, b) => { click_sound.Play(); };
                a_item.DropDownOpened += (a,b) => 
                {
                    a_item.ForeColor = Color.FromArgb(0,0,0);
                };
                a_item.DropDownClosed += (a,b) => 
                {
                    a_item.ForeColor = Color.FromArgb(255,255,255);
                };
                if (a_item.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem subitem in a_item.DropDownItems.OfType<ToolStripMenuItem>())
                    {
                        subitem.Click += (a, b) => { click_sound.Play(); };
                        subitem.ForeColor = Color.FromArgb(255, 255, 255);
                        subitem.BackgroundImage = btnimg;
                        subitem.BackgroundImageLayout = ImageLayout.Stretch;
                        if (subitem.HasDropDownItems)
                        {
                            foreach (ToolStripItem subsubitem in subitem.DropDownItems.OfType<ToolStripMenuItem>())
                            {
                                subsubitem.Click += (a, b) => { click_sound.Play(); };
                                subsubitem.ForeColor = Color.FromArgb(255, 255, 255);
                                subsubitem.BackgroundImage = btnimg;
                                subsubitem.BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }
                    }
                }
            }
        }

        private void ItemCondition_Click(object sender, EventArgs e)
        {
            SkillInforForm skill_info = new SkillInforForm(false,false);
            if(skill_info.ShowDialog() == DialogResult.OK)
            {
                foreach (string page_title in skill_info.result_text)
                {
                    int index = int.Parse(page_title);
                    TabPage item_condition = new TabPage()
                    {
                        Text = index+1+"号物品条件",
                        Tag = "3",
                        BackColor = Color.FromArgb(50,50,50)
                    };
                    skill_tab.TabPages.Add(item_condition);
                    TableLayoutPanel skill_info_table = new TableLayoutPanel()
                    {
                        Name = "skill_info_table",
                        Dock = DockStyle.Fill,
                        RowCount = 2,
                        ColumnCount = 2,
                        AutoScroll = true,
                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(255,255,255)
                    };

                    Label para = new Label()
                    {
                        AutoSize = true,
                        Text = "参数:",
                        BackColor = Color.Transparent,
                        Anchor = AnchorStyles.None
                    };

                    #region 执行反射,添加需要的条件参数
                    //获取目标类体的类型
                    Type component_manager = Assembly.Load("cbhk_editor").GetType("cbhk_editor.SkillSpawner.ComponentsManager");
                    //获取目标类体内部的公开方法集合
                    MethodInfo[] ItemMethods = component_manager.GetMethods();
                    //创建目标类体实例
                    var c_m = Activator.CreateInstance(component_manager);
                    //调用目标类体目标方法
                    UserControl target_control = ItemMethods[index].Invoke(c_m, null) as UserControl;
                    #endregion
                    skill_info_table.Controls.Add(para, 0, 0);
                    skill_info_table.Controls.Add(target_control,1,0);
                    #region 行列自适应
                    skill_info_table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 1));
                    skill_info_table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 1));
                    skill_info_table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 1));
                    skill_info_table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 1));
                    #endregion

                    #region 开启横向纵向滚动条
                    skill_info_table.HorizontalScroll.Enabled = true;
                    skill_info_table.VerticalScroll.Enabled = true;
                    #endregion

                    item_condition.Controls.Add(skill_info_table);
                }
            }
        }

        private void EntityCondition_Click(object sender, EventArgs e)
        {
            SkillInforForm skill_info = new SkillInforForm(true, false);
            if (skill_info.ShowDialog() == DialogResult.OK)
            {
                foreach (string page_title in skill_info.result_text)
                {
                    int index = int.Parse(page_title);
                    TabPage entity_condition = new TabPage()
                    {
                        Text = index + 1 + "号实体条件",
                        Tag = "0",
                        BackColor = Color.FromArgb(50, 50, 50)
                    };
                    skill_tab.TabPages.Add(entity_condition);

                    TableLayoutPanel skill_info_table = new TableLayoutPanel()
                    {
                        Name= "skill_info_table",
                        Dock = DockStyle.Fill,
                        RowCount = 2,
                        ColumnCount = 2,
                        AutoScroll = true,
                        BackColor = Color.Transparent,
                        ForeColor = Color.FromArgb(255, 255, 255)
                    };

                    Label para = new Label()
                    {
                        AutoSize = true,
                        Text = "参数:",
                        BackColor = Color.Transparent,
                        Anchor = AnchorStyles.None
                    };

                    #region 执行反射,添加需要的条件参数
                    //获取目标类体的类型
                    Type component_manager = Assembly.Load("cbhk_editor").GetType("cbhk_editor.SkillSpawner.EntityComponentsManager");
                    //获取目标类体内部的公开方法集合
                    MethodInfo[] ItemMethods = component_manager.GetMethods();
                    //创建目标类体实例
                    var c_m = Activator.CreateInstance(component_manager);
                    //调用目标类体目标方法
                    UserControl target_control = ItemMethods[index+7].Invoke(c_m, null) as UserControl;
                    #endregion

                    #region 添加文本提示和条件块
                    skill_info_table.Controls.Add(para, 0, 0);
                    if(target_control!=null)
                    skill_info_table.Controls.Add(target_control, 1, 0);
                    else
                    {
                        Label empty_para = new Label()
                        {
                            Text = "无",
                            Anchor = AnchorStyles.Left
                        };
                        skill_info_table.Controls.Add(empty_para,1,0);
                    }
                    #endregion

                    #region 行列自适应
                    skill_info_table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 1));
                    skill_info_table.RowStyles.Add(new RowStyle(SizeType.AutoSize, 1));
                    skill_info_table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 1));
                    skill_info_table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 1));
                    #endregion

                    #region 开启横向纵向滚动条
                    skill_info_table.HorizontalScroll.Enabled = true;
                    skill_info_table.VerticalScroll.Enabled = true;
                    #endregion

                    entity_condition.Controls.Add(skill_info_table);
                }
            }
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
                SkillInforForm skill_info = new SkillInforForm(false, true);
            if (skill_info.ShowDialog() == DialogResult.OK)
            {
                if (skill_tab.SelectedTab == null)
                    return;
                foreach (string page_title in skill_info.result_text)
                {
                    int index = int.Parse(page_title);
                    TabPage a_event = new TabPage()
                    {
                        Text = index+1+"号事件",
                        Tag = "9",
                        BackColor = Color.FromArgb(50, 50, 50)
                    };
                    TabControl event_tab = new TabControl()
                    {
                        Name = "event_tab",
                        Dock = DockStyle.Fill
                    };

                    Control[] target_area = skill_tab.SelectedTab.Controls.Find("skill_info_table", true);
                    if (target_area.Length > 0)
                    {
                        //获取当前选中项的表格对象
                        TableLayoutPanel skill_info_table = target_area[0] as TableLayoutPanel;
                        //搜索当前页的事件TabControl控件
                        Control[] sub_ctls = skill_info_table.Controls.Find("event_tab", true);
                        TabControl EventTab = null;
                        if (sub_ctls.Length>0)
                        {
                            foreach (Control ctl in sub_ctls)
                            {
                                if(ctl is TabControl)
                                {
                                    EventTab = ctl as TabControl;
                                    break;
                                }
                            }
                        }
                        if (EventTab == null)
                            event_tab.Controls.Add(a_event);
                        else
                            EventTab.Controls.Add(a_event);
                        Label para = new Label()
                        {
                            Name = "tip",
                            AutoSize = true,
                            Text = "事件:",
                            BackColor = Color.Transparent,
                            Anchor = AnchorStyles.None
                        };

                        #region 执行反射,添加需要的条件参数
                        //获取目标类体的类型
                        Type component_manager = Assembly.Load("cbhk_editor").GetType("cbhk_editor.SkillSpawner.ComponentsManager");
                        //获取目标类体内部的公开方法集合
                        MethodInfo[] ItemMethods = component_manager.GetMethods();
                        //创建目标类体实例
                        var c_m = Activator.CreateInstance(component_manager);
                        //调用目标类体目标方法
                        UserControl target_control = ItemMethods[index + 10].Invoke(c_m, null) as UserControl;
                        #endregion

                        #region 添加文本提示和事件块
                        //搜索是否存在提示文本
                        Control[] tips = skill_info_table.Controls.Find("tip",true);
                        if(tips.Length==0)
                        skill_info_table.Controls.Add(para, 0, 1);
                        if (target_control != null)
                        {
                            a_event.Controls.Add(target_control);
                            if (EventTab != null)
                                skill_info_table.Controls.Add(EventTab, 1, 1);
                            else
                                skill_info_table.Controls.Add(event_tab, 1, 1);
                        }
                        #endregion
                    }
                }
            }
        }

        private void Click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存所有技能
            List<string> skill_result = new List<string> { };
            foreach (TabPage skill_page in skill_tab.TabPages)
            {
                //保存生成结果
                string a_skill_result = "";
                //搜索标签页中的数据表
                TableLayoutPanel skill_table = skill_page.Controls.Find("skill_info_table",false)[0] as TableLayoutPanel;

                #region 处理条件数据
                //获取表中第一行第二列的自定义控件,这个自定义控件的子级放置了该条件所有的参数
                UserControl parameter_control = skill_table.GetControlFromPosition(1,0) as UserControl;
                string current_version = version1_12.Checked ?"1.12":"1.13";
                var conditions_obj = Activator.CreateInstance(manager);

                //标签页文本数字与标签页Tag数据中的数字相加的结果减1为调用方法的索引
                int condition_index = int.Parse(Regex.Match(skill_page.Text,@"[\d]+").ToString());
                int condition_start_index = int.Parse(skill_page.Tag.ToString());

                List<string> condition_data = skill_methods[condition_index+condition_start_index-1].Invoke(conditions_obj,new object[] { parameter_control,current_version }) as List<string>;
                //遍历条件和事件的结果,合并字符串
                for (int i = 1; i < condition_data.Count; i++)
                {
                    a_skill_result += condition_data[i] + "\r\n";
                }
                string target_para = condition_data[0];
                #endregion

                #region 处理事件数据
                //搜索数据包第二行第二列的TabControl控件
                TabControl event_tab;
                Control[] event_area = skill_table.Controls.Find("event_tab",true);
                if (event_area.Length == 0)
                    continue;
                else
                    event_tab = event_area[0] as TabControl;

                //存储事件数据
                List<string> event_data = new List<string> { };
                //遍历event_tab中的标签页
                foreach (TabPage page in event_tab.TabPages)
                {
                    int event_index = int.Parse(Regex.Match(page.Text, @"[\d]+").ToString());
                    int event_start_index = int.Parse(page.Tag.ToString());
                    //搜索标签页中的自定义控件
                    foreach (Control ctl in page.Controls)
                    {
                        if (ctl is UserControl)
                        {
                            //调用对应的方法
                            //方法索引=标签页索引+标签页Tag数字数据-1
                            List<string> event_result = skill_methods[event_index + event_start_index - 1].Invoke(conditions_obj, new object[] { ctl, target_para, current_version }) as List<string>;
                            foreach (string a_event in event_result)
                                a_skill_result += a_event + "\r\n";
                            //添加一个技能
                        }
                    }
                }
                #endregion
                skill_result.Add(a_skill_result);
            }
            #region 生成技能指令
            command_result cmd_result = new command_result("技能指令",skill_result);
            cmd_result.Show();
            #endregion
        }

        private void Version1_12_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            version1_13.Checked = !this_obj.Checked;
        }

        private void Version1_13_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            version1_12.Checked = !this_obj.Checked;
        }

        private void About_skill_spawner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("如何使用:\r\n1.点击\"添加/预览条件\"对现有条件进行查看或添加\r\n2.点击\"添加/预览事件对现有事件进行查看或添加\"\r\n3.设置每个条件的参数(如果有),之后设置事件的参数,最后点击生成即可获取指令串");
        }

        private void Delete_condition_menu_Click(object sender, EventArgs e)
        {
            if(skill_tab.TabPages.Count > 0)
            skill_tab.TabPages.Remove(skill_tab.SelectedTab);
        }

        private void Rclick_delete_contidion_Click(object sender, EventArgs e)
        {
            Delete_condition_menu_Click(null,null);
        }

        private void Delete_event_menu_Click(object sender, EventArgs e)
        {
            if(skill_tab.TabPages.Count > 0)
            foreach (Control item in skill_tab.SelectedTab.Controls)
            {
                if(item is TableLayoutPanel)
                {
                    TableLayoutPanel tlp = item as TableLayoutPanel;
                    foreach (Control area in tlp.Controls)
                    {
                        if(area is TabControl)
                        {
                            TabControl tc = area as TabControl;
                            tc.TabPages.Remove(tc.SelectedTab);
                        }
                    }
                }
            }
        }

        private void Rclick_delete_event_Click(object sender, EventArgs e)
        {
            Delete_event_menu_Click(null,null);
        }

        private void Delete_all_conditions_Click(object sender, EventArgs e)
        {
            skill_tab.TabPages.Clear();
        }

        private void Rclick_delete_conditions_Click(object sender, EventArgs e)
        {
            Delete_all_conditions_Click(null,null);
        }

        private void Delete_all_events_Click(object sender, EventArgs e)
        {
            if(skill_tab.TabPages.Count > 0)
            foreach (Control item in skill_tab.SelectedTab.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    TableLayoutPanel tlp = item as TableLayoutPanel;
                    foreach (Control area in tlp.Controls)
                    {
                        if (area is TabControl)
                        {
                            tlp.Controls.Remove(area);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void Rclick_delete_events_Click(object sender, EventArgs e)
        {
            Delete_all_events_Click(null,null);
        }
    }
}
