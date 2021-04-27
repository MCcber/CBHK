using System;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace cbhk_editor.SurfaceBuilderSpawner
{
    public partial class surface_builder_spawner : Form
    {
        Form parent;
        SoundPlayer click_sound;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //保存最终结果
        private string result = "{";
        //是否需要添加逗号
        private bool NeedComma = false;
        //保存历史生成路径
        private string history_path = "";

        //保存当前节点
        TreeNode CurrentNode = new TreeNode();
        //表示当前正在操作
        bool Modifying = false;
        //保存当前鼠标坐标
        Point mouse_pos = new Point();

        //引用方块ID表
        TreeView blocks_view = MainForm.Cbhk_form.Blocks;
        //保存方块ID表
        List<TreeNode> Blocks = new List<TreeNode> { };

        public surface_builder_spawner(Form obj,SoundPlayer sound)
        {
            InitializeComponent();
            parent = obj;
            click_sound = sound;
            InitUISettings();

            //缓存方块ID列表
            foreach (TreeNode item in blocks_view.Nodes)
                Blocks.Add(item);
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            surface_builder_view.ExpandAll();
            click_to_return.Click += (a, b) =>
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };

            foreach (ToolStripMenuItem item in surface_builder_title_menu.Items)
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

        private void add_Click(object sender, EventArgs e)
        {
            #region 处理节点数据更新
            string[] node_type = Array.Empty<string>();
            if (CurrentNode.Text.Contains(":"))
                node_type = CurrentNode.Text.Split(':');
            if (CurrentNode.Name == "root_node")
            {
                TextBox textBox = new TextBox()
                {
                    Size = new Size(50, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50)
                };

                textBox.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        surface_builder_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = textBox.Text.Trim();
                        surface_builder_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                };

                surface_builder_view.Controls.Add(textBox);
                textBox.BringToFront();
            }

            if (CurrentNode.Name.Contains("value"))
            {
                string value_type = CurrentNode.Name.Split(':')[1];
                switch (value_type)
                {
                    case "string":
                        {
                            if (CurrentNode.Parent.Parent.Name == "root_node" && CurrentNode.Text.Contains("type"))
                            {
                                Modifying = false;
                                break;
                            }
                            Modifying = true;
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            TextBox textBox = new TextBox()
                            {
                                Size = new Size(50, 25),
                                Location = mouse_pos,
                                ForeColor = Color.White,
                                BackColor = Color.FromArgb(50, 50, 50)
                            };

                            textBox.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    surface_builder_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    surface_builder_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            surface_builder_view.Controls.Add(textBox);
                            textBox.BringToFront();
                            break;
                        }
                    case "int":
                    case "long":
                        {
                            Modifying = true;
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            NumericUpDown value_box = new NumericUpDown()
                            {
                                Minimum = 0,
                                Maximum = value_type == "int" ? 2147483647 : 9223372036854775807,
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(100, 25),
                                Location = mouse_pos
                            };

                            value_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    surface_builder_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Value;
                                    surface_builder_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            surface_builder_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                    case "double":
                    case "float":
                        {
                            Modifying = true;
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            TextBox textBox = new TextBox()
                            {
                                Size = new Size(50, 25),
                                Location = mouse_pos,
                                ForeColor = Color.White,
                                BackColor = Color.FromArgb(50, 50, 50)
                            };

                            textBox.KeyPress += (a, b) =>
                            {
                                if (b.KeyChar != 8 && !Char.IsDigit(b.KeyChar) && b.KeyChar != 0x2E)
                                {
                                    b.Handled = true;
                                }

                                if (b.KeyChar == '.')   //允许输入回退键
                                {
                                    TextBox tb = sender as TextBox;

                                    if (tb.Text == "")
                                    {
                                        tb.Text = "0.";
                                        tb.Select(tb.Text.Length, 0);
                                        b.Handled = true;
                                    }
                                    else if (tb.Text.Contains("."))
                                    {
                                        b.Handled = true;
                                    }
                                    else
                                    {
                                        b.Handled = false;
                                    }
                                }
                            };

                            textBox.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    surface_builder_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    surface_builder_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            surface_builder_view.Controls.Add(textBox);
                            textBox.BringToFront();
                            break;
                        }
                    case "bool":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            ComboBox value_box = new ComboBox()
                            {
                                Size = new Size(100, 25),
                                Location = mouse_pos,
                                AutoCompleteSource = AutoCompleteSource.CustomSource,
                                AutoCompleteMode = AutoCompleteMode.Suggest,
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White
                            };

                            value_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    surface_builder_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Text.Trim();
                                    surface_builder_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            value_box.Items.Add("true");
                            value_box.Items.Add("false");
                            value_box.AutoCompleteCustomSource.Add("true");
                            value_box.AutoCompleteCustomSource.Add("false");
                            surface_builder_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                    case "tag":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            #region 设置方块ID和属性
                            if (node_type[0] == "Name" && CurrentNode.Parent.Name == "parent_node")
                            {
                                ComboBox value_box = new ComboBox()
                                {
                                    Size = new Size(200, 25),
                                    Location = mouse_pos,
                                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                                    AutoCompleteMode = AutoCompleteMode.Suggest,
                                    BackColor = Color.FromArgb(50, 50, 50),
                                    ForeColor = Color.White
                                };

                                //填充成员
                                foreach (TreeNode item in Blocks)
                                {
                                    value_box.Items.Add(item.Text);
                                    value_box.AutoCompleteCustomSource.Add(item.Text);
                                }

                                value_box.KeyDown += (a, b) =>
                                {
                                    if (b.KeyCode == Keys.Escape)
                                    {
                                        Modifying = false;
                                        surface_builder_view.Controls.Remove(value_box);
                                    }
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        Modifying = false;
                                        surface_builder_view.Controls.Remove(value_box);

                                        #region 设置属性
                                        //判断是否清空属性节点
                                        if (CurrentNode.Text.Replace(CurrentText + ":", "") == value_box.Text.Trim())
                                            return;
                                        else//否则清空所有属性
                                            CurrentNode.Parent.Nodes[1].Nodes.Clear();
                                        CurrentNode.Text = CurrentText + ":" + value_box.Text.Trim();

                                        foreach (TreeNode item in Blocks[value_box.SelectedIndex].Nodes)
                                        {
                                            if (item.Text == "properties")
                                            {
                                                foreach (TreeNode a_property in item.Nodes)
                                                {
                                                    //创建属性节点
                                                    TreeNode a_property_node = new TreeNode()
                                                    {
                                                        Text = a_property.Text + ":"
                                                    };

                                                    //设置标签值
                                                    a_property_node.Tag = a_property.Nodes[0].Text.Replace("\"", "").Replace("[", "").Replace("]", "").Replace(" ", "").Trim();

                                                    if (Regex.Match(a_property.Nodes[0].Text, @"\d+").Success)
                                                    {
                                                        a_property_node.Name = "value:int";
                                                    }
                                                    else
                                                        if (Regex.Match(a_property.Nodes[0].Text, "false", RegexOptions.IgnoreCase).Success)
                                                        a_property_node.Name = "value:bool";
                                                    else
                                                        a_property_node.Name = "value:tag";

                                                    //添加属性节点
                                                    CurrentNode.Parent.Nodes[1].Nodes.Add(a_property_node);
                                                }
                                            }
                                        }
                                        #endregion
                                    }
                                };

                                surface_builder_view.Controls.Add(value_box);
                                value_box.BringToFront();
                                return;
                            }
                            #endregion

                            #region 设置选中的Tag为文本值
                            ComboBox tag_box = new ComboBox()
                            {
                                Size = new Size(200, 25),
                                Location = mouse_pos,
                                AutoCompleteSource = AutoCompleteSource.CustomSource,
                                AutoCompleteMode = AutoCompleteMode.Suggest,
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White
                            };

                            //填充成员
                            string[] tags = CurrentNode.Tag.ToString().Split(',');
                            for (int i = 0; i < tags.Length; i++)
                            {
                                tag_box.Items.Add(tags[i]);
                                tag_box.AutoCompleteCustomSource.Add(tags[i]);
                            }

                            tag_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                {
                                    Modifying = false;
                                    surface_builder_view.Controls.Remove(tag_box);
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    Modifying = false;
                                    surface_builder_view.Controls.Remove(tag_box);

                                    CurrentNode.Text = CurrentText + ":" + tag_box.Text.Trim();
                                }
                            };

                            surface_builder_view.Controls.Add(tag_box);
                            tag_box.BringToFront();
                            #endregion
                            break;
                        }
                }
                return;
            }
            #endregion
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            add_Click(null,null);
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            delete_Click(null,null);
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            clear_Click(null,null);
        }


        /// <summary>
        /// 开始合并所有节点的数据
        /// </summary>
        /// <param name="SelectNode"></param>
        private void StartSpawn(TreeNode SelectNode)
        {
            foreach (TreeNode subnode in SelectNode.Nodes)
            {
                if (subnode.Name.Contains("value:"))
                {
                    if (subnode.Name.Contains("string"))
                    {
                        if (subnode.Text.Split(':')[0] == "type" && subnode.Nodes.Count > 0 && subnode.Parent.Name == "root_node")
                        {
                            result += "\"" + subnode.Text + "\":{";
                            NeedComma = true;
                        }
                        else
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            int index = subnode.Text.IndexOf(":");
                            result += "\"" + subnode.Text.Insert(index, "\"").Insert(index + 2, "\"") + "\"";
                            NeedComma = true;
                        }
                        else
                        {
                            NeedComma = false;
                        }
                    }
                    else
                    if (subnode.Text.Contains(":") && (subnode.Text.IndexOf(':') + 1) < subnode.Text.Length)
                    {
                        int index = subnode.Text.IndexOf(":");
                        result += "\"" + subnode.Text.Insert(index, "\"");
                        NeedComma = true;
                    }
                    else
                    if (!subnode.Name.Contains("value"))
                    {
                        int index = subnode.Text.IndexOf(":");
                        result += "\"" + subnode.Text.Insert(index, "\"") + "{";
                    }
                    else
                        NeedComma = false;

                    //去除多余的尾部逗号
                    if (result.EndsWith("[,") || result.EndsWith("{,"))
                        result = result.TrimEnd(',');

                    if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && NeedComma)
                        result += ",";
                    else
                    if (subnode.Index == (subnode.Parent.Nodes.Count - 1))
                    {
                        result = result.TrimEnd(',');
                    }
                }

                switch (subnode.Name)
                {
                    case "list_ele":
                        {
                            string[] ele_array = subnode.Text.Split(',');
                            //result += "[";
                            foreach (string item in ele_array)
                            {
                                result += "\"" + item + "\",";
                            }
                            result = result.Trim(',');
                            if (subnode.Index < (subnode.Parent.Nodes.Count - 1))
                                NeedComma = true;
                            break;
                        }

                    case "parent_node":
                    case "array_ele":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "\"" + subnode.Text + "\":{";
                                NeedComma = true;
                            }
                            break;
                        }

                    case "list_node":
                    case "array_node":
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
                }

                if (subnode.Nodes.Count > 0)
                    StartSpawn(subnode);

                switch (subnode.Name)
                {
                    case "value:string":
                        {
                            if (subnode.Parent.Name == "root_node" && subnode.Nodes.Count > 0)
                                result += "}";

                            if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && subnode.Nodes.Count > 0)
                                result += ",";
                            break;
                        }
                    case "parent_node":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "}";
                                NeedComma = true;
                            }
                            break;
                        }
                    case "array_ele":
                        {
                            result += "}";
                            NeedComma = true;
                            break;
                        }

                    case "list_node":
                    case "array_node":
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
                }

                //去除多余的尾部逗号
                if (result.EndsWith("[,") || result.EndsWith("{,"))
                    result = result.TrimEnd(',');
                while (result.EndsWith(",]") || result.EndsWith(",}"))
                {
                    result = result.Replace(",]", "]").Replace(",}", "}");
                }

                if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && NeedComma)
                {
                    if (!subnode.Name.Contains("value:"))
                    {
                        result += ",";
                        NeedComma = false;
                    }
                }
            }
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            result = "{";
            StartSpawn(surface_builder_view.Nodes[0]);
            result += "}";

            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "请选择地表生成器生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };
            if (folder.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folder.SelectedPath + "\\" + surface_builder_view.Nodes[0].Text + ".json", result, new UTF8Encoding(false));
                Process.Start(folder.SelectedPath);
                history_path = folder.SelectedPath;
            }
        }

        private void surface_builder_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Modifying)
            {
                CurrentNode = surface_builder_view.SelectedNode;
                mouse_pos = e.Location;
            }
        }
    }
}
