using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner
{
    public partial class condition_form : Form
    {
        Type managerType = Assembly.Load("cbhk_editor").GetType("cbhk_editor.LootTableSpawner.ConditionsManager");
        MethodInfo[] methods;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");

        //保存最终结果
        public TreeNode conditionInfo = new TreeNode();

        //不需要子级的条件索引
        List<int> NoChildrenConditions = new List<int> { 2,3 };

        public condition_form()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            foreach (TabPage item in condition_tab.TabPages)
            {
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
            }
            add_title_menu_Click(null, null);

            foreach (ToolStripMenuItem item in condition_title_menu.Items)
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

            foreach (ToolStripMenuItem item in add_title_menu.DropDownItems)
            {
                item.Click += SetConditionHead;
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        private void condition_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPage item in condition_tab.TabPages)
            {
                foreach (TabControl subitem in item.Controls)
                {
                    #region 合并所有条件数据
                    foreach (TabPage a_condition in subitem.TabPages)
                    {
                        if (a_condition.Tag != null)
                        {
                            TreeNode condition_node = new TreeNode()
                            {
                                Tag = a_condition.Tag,
                                Text = "minecraft:"+item.Name.Replace("_page", ""),
                                Name = "a_condition"
                            };
                            conditionInfo.Nodes.Add(condition_node);
                        }
                    }
                    #endregion
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void add_title_menu_Click(object sender, EventArgs e)
        {
            var target_class = typeof(ConditionsManager);
            object instance = Activator.CreateInstance(target_class);
            methods = target_class.GetMethods();
            Control target_obj = target_class.InvokeMember(methods[condition_tab.SelectedIndex].Name, BindingFlags.InvokeMethod, null, instance, new object[] { }) as Control;
            TabControl a_condition = condition_tab.SelectedTab.Controls[0] as TabControl;
            TabPage newItem = new TabPage()
            {
                Text = a_condition.TabPages.Count+1+""
            };
            newItem.Controls.Add(target_obj);
            a_condition.TabPages.Add(newItem);
        }

        private void delete_title_menu_Click(object sender, EventArgs e)
        {
            TabControl a_condition = condition_tab.SelectedTab.Controls[0] as TabControl;
            a_condition.TabPages.RemoveAt(a_condition.SelectedIndex);
        }

        private void clear_title_menu_Click(object sender, EventArgs e)
        {
            TabControl a_condition = condition_tab.SelectedTab.Controls[0] as TabControl;
            a_condition.TabPages.Clear();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.按钮的交互结果都是需要填写的");
        }

        private void condition_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl a_condition = condition_tab.SelectedTab.Controls[0] as TabControl;
            if (a_condition.TabPages.Count == 0)
                add_title_menu_Click(null,null);
        }

        private void SetConditionHead(object sender,EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            Close();
            ToolStripMenuItem ParentItem = this_obj.OwnerItem as ToolStripMenuItem;
            int CurrentIndex = ParentItem.DropDownItems.IndexOf(this_obj);
            if(NoChildrenConditions.FindIndex(obj=> CurrentIndex == obj) == -1)
            {
                conditionInfo.Text = "minecraft:" + this_obj.Name;
                conditionInfo.Name = "condition_head";
            }
            else
            {
                TreeNode ConditionHead = new TreeNode()
                {
                    Text = "minecraft:" + this_obj.Name,
                    Tag = "{\"condition\":\"minecraft:" + this_obj.Name + "\"},",
                    Name = "a_condition"
                };
                conditionInfo.Nodes.Add(ConditionHead);
            }
        }
    }
}
