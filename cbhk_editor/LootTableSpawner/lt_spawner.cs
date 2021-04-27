using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner
{
    public partial class lt_spawner : Form
    {
        Form parent;
        TreeView Root;
        SoundPlayer soundPlayer;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //保存光标坐标
        Point mouse_pos = new Point();

        //可修改节点
        List<string> CanModifyNodes = new List<string> {  };
        //可删除节点
        List<string> CanDeleteNodes = new List<string> { "ele", "condition_head","function_head", "a_condition","a_function" };

        //保存最终结果
        string result = "{";
        //历史路径
        string history_path = "";
        public lt_spawner(Form obj,SoundPlayer click)
        {
            InitializeComponent();
            InitUISettings();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            parent = obj;
            soundPlayer = click;
            Root = Cbhk_form.register;
        }

        //已选中的节点
        TreeNode SelectedNode = new TreeNode();
        //表示正在编辑
        bool Modifying = false;
        //需要添加逗号
        bool NeedComma = false;

        private void InitUISettings()
        {
            MaximumSize = Size;
            click_to_return.Click += (a, b) =>
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            foreach (ToolStripMenuItem item in lt_title_menu.Items)
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
            lt_view.ExpandAll();
        }

        private void ClickSound(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        /// <summary>
        /// 开始合并所有节点的数据
        /// </summary>
        /// <param name="CurrentNode"></param>
        private void StartSpawn(TreeNode CurrentNode)
        {
            foreach (TreeNode subnode in CurrentNode.Nodes)
            {
                if (subnode.Name.Contains("value:"))
                {
                    if(subnode.Name.Contains("string"))
                        result += "\""+subnode.Text.Split(':')[0]+"\":\""+subnode.Text.Split(':')[1]+"\"";
                    else
                        result += "\"" + subnode.Text.Split(':')[0] + "\":" + subnode.Text.Split(':')[1];

                    if (subnode.Index < (subnode.Parent.Nodes.Count - 1))
                        result += ",";
                }

                switch (subnode.Name)
                {
                    case "arraynode":
                    case "obj_parentnode":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "\"" + subnode.Text + "\":[";
                                NeedComma = true;
                            }
                            else
                                NeedComma = false;
                            break;
                        }

                    case "parentnode":
                        {
                            if(subnode.Nodes.Count > 0)
                            {
                                result += "\"" + subnode.Text + "\":{";
                                NeedComma = true;
                            }
                            break;
                        }

                    case "ele":
                        {
                            result += "{";
                            break;
                        }
                    case "a_function":
                    case "a_condition":
                        {
                            result += subnode.Tag.ToString();
                            if (subnode.Index >= (subnode.Parent.Nodes.Count - 1))
                            {
                                NeedComma = false;
                                result = result.TrimEnd(',');
                            }
                            break;
                        }

                    case "condition_head":
                        {
                            if (subnode.Text.Contains("alternative") && subnode.Nodes.Count > 0)
                            {
                                result += "{\"condition\":\"minecraft:alternative\",\"terms\":[";
                                NeedComma = true;
                            }
                            if (subnode.Text.Contains("inverted") && subnode.Nodes.Count > 0)
                            {
                                result += "{\"condition\":\"minecraft:inverted\",\"term\":{";
                                NeedComma = true;
                            }
                            break;
                        }
                }

                if (subnode.Nodes.Count > 0)
                    StartSpawn(subnode);

                switch (subnode.Name)
                {
                    case "arraynode":
                    case "obj_parentnode":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "]";
                                NeedComma = true;
                            }
                            else
                                NeedComma = false;
                            break;
                        }

                    case "parentnode":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "}";
                                NeedComma = true;
                            }
                            break;
                        }
                    case "ele":
                        {
                            result += "}";
                            if (subnode.Index < (subnode.Parent.Nodes.Count - 1))
                                result += ",";
                            break;
                        }

                    case "condition_head":
                        {
                            if (subnode.Text.Contains("alternative") && subnode.Nodes.Count > 0)
                            {
                                result += "]}";
                                NeedComma = true;
                            }
                            if (subnode.Text.Contains("inverted") && subnode.Nodes.Count > 0)
                            {
                                result += "}}";
                                NeedComma = true;
                            }
                            break;
                        }
                }

                if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && NeedComma)
                {
                    if ((subnode.Name != "a_condition" || subnode.Name != "a_function") && !subnode.Name.Contains("value:") && subnode.Name != "ele")
                    {
                        result += ",";
                        NeedComma = false;
                    }
                }
            }
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            //执行生成
            StartSpawn(lt_view.Nodes[0]);

            result += "}";

            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "请选择战利品表生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };

            if(folder.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folder.SelectedPath+"\\"+lt_view.Nodes[0].Text+".json",result);
                result = "{";
                Process.Start(folder.SelectedPath);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void version1_12_Click(object sender, EventArgs e)
        {
            version1_13.Checked = !version1_12.Checked;
        }

        private void version1_13_Click(object sender, EventArgs e)
        {
            version1_12.Checked = !version1_13.Checked;
        }

        private void add_node_title_menu_Click(object sender, EventArgs e)
        {
            SelectedNode = lt_view.SelectedNode;

            if(SelectedNode.Name == "obj_parentnode")
            {
                if (SelectedNode.Text == "pools")
                {
                    pool_item pi = new pool_item();
                    TreeNode new_subnode = new TreeNode() { Name = "ele" };
                    TreeNodeCollection subnodes = pi.pool_view.Nodes[0].Nodes;
                    new_subnode.Text = SelectedNode.Nodes.Count + 1 + "";
                    SelectedNode.Nodes.Add(new_subnode);
                    foreach (TreeNode item in subnodes)
                        new_subnode.Nodes.Add(item);
                }
                else
                    if(SelectedNode.Text == "entries")
                {
                    entry_item ei = new entry_item();
                    TreeNode new_subnode = new TreeNode() { Name = "ele" };
                    TreeNodeCollection subnodes = ei.entry_view.Nodes[0].Nodes;
                    new_subnode.Text = SelectedNode.Nodes.Count + 1+"";
                    SelectedNode.Nodes.Add(new_subnode);
                    foreach (TreeNode item in subnodes)
                        new_subnode.Nodes.Add(item);
                }
            }

            if(SelectedNode.Name == "arraynode")
            {
                Modifying = true;
                if (SelectedNode.Text == "conditions")
                {
                    condition_form cf = new condition_form();
                    if (cf.ShowDialog() == DialogResult.OK)
                    {
                        TreeNode a_condition = new TreeNode();
                        if (cf.conditionInfo.Text.Trim() != "")
                        {
                            a_condition = cf.conditionInfo;
                            SelectedNode.Nodes.Add(a_condition);
                            lt_view.SelectedNode = a_condition;
                        }
                        else
                        {
                            foreach (TreeNode item in cf.conditionInfo.Nodes)
                            {
                                SelectedNode.Nodes.Add(item);
                            }
                            SelectedNode.ExpandAll();
                        }
                        Modifying = false;
                    }
                }
                else
                if (SelectedNode.Text == "functions")
                {
                    function_form ff = new function_form();
                    if (ff.ShowDialog() == DialogResult.OK)
                    {
                        TreeNode a_function = new TreeNode()
                        {
                            Name = "a_function"
                        };

                        if (ff.functionInfo.Text.Trim() != "")
                        {
                            a_function = ff.functionInfo;
                            SelectedNode.Nodes.Add(a_function);
                            TreeNode conditions = new TreeNode()
                            {
                                Text = "conditions",
                                Name = "arraynode"
                            };
                            a_function.Nodes.Add(conditions);
                            lt_view.SelectedNode = a_function;
                        }
                        else
                        {
                            foreach (TreeNode item in ff.functionInfo.Nodes)
                            {
                                SelectedNode.Nodes.Add(item);
                                TreeNode conditions = new TreeNode()
                                {
                                    Text = "conditions",
                                    Name = "arraynode"
                                };
                                item.Nodes.Add(conditions);
                            }
                            SelectedNode.ExpandAll();
                        }
                        Modifying = false;
                    }
                }
            }
        }

        private void modify_node_title_menu_Click(object sender, EventArgs e)
        {
            if(SelectedNode.Name == "rootnode")
            {
                TextBox value_box = new TextBox()
                {
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.White,
                    Size = new Size(50, 15),
                    Location = mouse_pos
                };
                value_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                        lt_view.Controls.Remove(value_box);
                    if (b.KeyCode == Keys.Enter)
                    {
                        SelectedNode.Text = value_box.Text;
                        lt_view.Controls.Remove(value_box);
                        Modifying = false;
                    }
                };
                lt_view.Controls.Add(value_box);
                value_box.BringToFront();
            }

            if(SelectedNode.Name.Contains("value:"))
            {
                Modifying = true;
                string key_value = SelectedNode.Text.Split(':')[0];
                string node_type = SelectedNode.Name.Split(':')[1];
                switch (node_type)
                {
                    case "string":
                        {
                            TextBox value_box = new TextBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 15),
                                Location = mouse_pos
                            };
                            value_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    lt_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    SelectedNode.Text = key_value + ":" + value_box.Text;
                                    lt_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };
                            lt_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                    case "int":
                        {
                            NumericUpDown value_box = new NumericUpDown()
                            {
                                Minimum = -1,
                                Maximum = 10000000000,
                                Value = -1,
                                BackColor = Color.FromArgb(50,50,50),
                                ForeColor = Color.White,
                                Size = new Size(50, 15),
                                Location = mouse_pos
                            };
                            value_box.KeyDown += (a,b) => 
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    Modifying = false;
                                    lt_view.Controls.Remove(value_box);
                                }
                                if(b.KeyCode == Keys.Enter)
                                {
                                    if(value_box.Value != -1)
                                    SelectedNode.Text = key_value + ":" + value_box.Value;
                                    lt_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };
                            lt_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }

                    case "float":
                    case "double":
                        {
                            TextBox value_box = new TextBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 15),
                                Location = mouse_pos
                            };
                            value_box.KeyPress += ControlInput;
                            value_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    Modifying = false;
                                    lt_view.Controls.Remove(value_box);
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    if (value_box.Text.Trim() != "")
                                        SelectedNode.Text = key_value + ":" + value_box.Text;
                                    lt_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };
                            lt_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }

                    case "bool":
                        {
                            ComboBox value_box = new ComboBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 15),
                                Location = mouse_pos
                            };
                            string[] bool_value = new string[] { "true","false" };
                            value_box.Items.AddRange(bool_value);
                            value_box.KeyPress += (a,b) => 
                            {
                                b.Handled = true;
                            };
                            value_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    Modifying = false;
                                    lt_view.Controls.Remove(value_box);
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    SelectedNode.Text = key_value + ":" + value_box.Text.Trim();
                                    lt_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };
                            lt_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                }
            }
        }

        private void ControlInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void delete_node_title_menu_Click(object sender, EventArgs e)
        {
            if (CanDeleteNodes.FindIndex(obj=>obj == lt_view.SelectedNode.Name) !=-1)
            {
                SelectedNode.Parent.Nodes.Remove(lt_view.SelectedNode);
            }
        }

        private void clear_node_title_menu_Click(object sender, EventArgs e)
        {
            if (lt_view.SelectedNode.Name == "obj_parentnode" || lt_view.SelectedNode.Name == "arraynode" || lt_view.SelectedNode.Name == "condition_head")
            {
                SelectedNode.Nodes.Clear();
                Modifying = false;
            }
        }

        private void add_node_Click(object sender, EventArgs e)
        {
            add_node_title_menu_Click(null,null);
        }

        private void modify_node_Click(object sender, EventArgs e)
        {
            modify_node_title_menu_Click(null,null);
        }

        private void delete_node_Click(object sender, EventArgs e)
        {
            delete_node_title_menu_Click(null,null);
        }

        private void clear_node_Click(object sender, EventArgs e)
        {
            clear_node_title_menu_Click(null,null);
        }

        private void lt_view_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_pos = e.Location;
            if (!Modifying)
                SelectedNode = lt_view.SelectedNode;
        }

        private void lt_view_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modify_node_title_menu_Click(null,null);
        }
    }
}
