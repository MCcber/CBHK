using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner
{
    public partial class function_form : Form
    {
        Type managerType = Assembly.Load("cbhk_editor").GetType("cbhk_editor.LootTableSpawner.FunctionsManager");
        MethodInfo[] methods;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");

        //保存最终结果
        public TreeNode functionInfo = new TreeNode();

        //不需要子级的条件索引
        List<int> NoChildrenFunctions = new List<int> { 0, 1 };

        public function_form()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            MaximumSize = Size;
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            foreach (TabPage item in function_tab.TabPages)
            {
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
            }
            add_Click(null, null);

            foreach (ToolStripMenuItem item in function_title_menu.Items)
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

            foreach (ToolStripMenuItem item in add.DropDownItems)
            {
                item.Click += SetFunctionHead;
            }
        }

        private void ClickSound(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void function_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPage item in function_tab.TabPages)
            {
                foreach (Control subitem in item.Controls)
                {
                    #region 合并所有函数数据
                    if (subitem is TabControl)
                    {
                        TabControl CurrentTab = subitem as TabControl;
                        foreach (TabPage a_function in CurrentTab.TabPages)
                        {
                            if (a_function.Tag != null)
                            {
                                TreeNode function_node = new TreeNode()
                                {
                                    Text = "minecraft:"+item.Name.Replace("_page",""),
                                    Name = "a_function",
                                    Tag = a_function.Tag
                                };
                                functionInfo.Nodes.Add(function_node);
                            }
                        }
                    }
                    #endregion
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void add_Click(object sender, EventArgs e)
        {
            var target_class = typeof(FunctionsManager);
            object instance = Activator.CreateInstance(target_class);
            methods = target_class.GetMethods();
            Control target_obj = target_class.InvokeMember(methods[function_tab.SelectedIndex].Name, BindingFlags.InvokeMethod, null, instance, new object[] { }) as Control;
            TabControl a_function = function_tab.SelectedTab.Controls[0] as TabControl;
            TabPage newItem = new TabPage()
            {
                Text = a_function.TabPages.Count + 1 + ""
            };
            newItem.Controls.Add(target_obj);
            a_function.TabPages.Add(newItem);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TabControl a_function = function_tab.SelectedTab.Controls[0] as TabControl;
            a_function.TabPages.RemoveAt(a_function.SelectedIndex);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            TabControl a_function = function_tab.SelectedTab.Controls[0] as TabControl;
            a_function.TabPages.Clear();
        }

        private void function_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl a_function = function_tab.SelectedTab.Controls[0] as TabControl;
            if (a_function.TabPages.Count == 0)
                add_Click(null, null);
        }

        private void SetFunctionHead(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            Close();
            ToolStripMenuItem ParentItem = this_obj.OwnerItem as ToolStripMenuItem;
            int CurrentIndex = ParentItem.DropDownItems.IndexOf(this_obj);
            if (NoChildrenFunctions.FindIndex(obj => CurrentIndex == obj) == -1)
            {
                functionInfo.Text = "minecraft:" + this_obj.Name;
                functionInfo.Name = "function_head";
            }
            else
            {
                TreeNode FunctionHead = new TreeNode()
                {
                    Text = "minecraft:" + this_obj.Name,
                    Tag = "{\"function\":\"minecraft:" + this_obj.Name + "\"},",
                    Name = "a_function"
                };
                functionInfo.Nodes.Add(FunctionHead);
            }
        }
    }
}
