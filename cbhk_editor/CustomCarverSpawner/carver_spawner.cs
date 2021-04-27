using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.CustomCarverSpawner
{
    public partial class carver_spawner : Form
    {
        SoundPlayer click_sound;
        Form parent;
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

        //基础节点集合
        List<string> BaseNodes = new List<string> { "probability","y", "yScale", "lava_level", "debug_settings" };

        //洞穴节点集合
        List<string> CaveNodes = new List<string> { "horizontal_radius_multiplier", "vertical_radius_multiplier", "floor_level" };

        //峡谷节点集合
        List<string> CanyonNodes = new List<string> { "vertical_rotation", "shape" };

        //第一种数值类型集合
        string value_type_0 = "minecraft:constant,minecraft:uniform,minecraft:biased_to_bottom,minecraft:very_biased_to_bottom,minecraft:trapezoid";
        //第二种值类型集合
        string value_type_1 = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid";

        //引用方块ID表
        TreeView blocks_view = MainForm.Cbhk_form.Blocks;
        //保存方块ID表
        List<TreeNode> Blocks = new List<TreeNode> { };

        public carver_spawner(Form obj,SoundPlayer soundPlayer)
        {
            InitializeComponent();
            parent = obj;
            click_sound = soundPlayer;
            InitUISettings();

            //缓存方块ID列表
            foreach (TreeNode item in blocks_view.Nodes)
                Blocks.Add(item);
        }

        private void InitUISettings()
        {
            carver_view.ExpandAll();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");

            click_to_return.Click += (a, b) =>
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            foreach (ToolStripMenuItem item in Carver_title_menu.Items)
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


        /// <summary>
        /// 删除多余的节点
        /// </summary>
        /// <param name="TargetList">需要比较的链表对象</param>
        private void DeleteSurplusNodes(TreeNode TagretNode,List<string> TargetList)
        {
            //删除多余节点
            try
            {
                List<int> remove_eles = new List<int> { };
                foreach (TreeNode item in TagretNode.Nodes)
                {
                    if (TargetList.FindIndex(obj => item.Text.Contains(obj)) == -1 && BaseNodes.FindIndex(obj => item.Text.Contains(obj)) == -1)
                    {
                        remove_eles.Add(item.Index);
                    }
                }
                for (int i = 0; i < remove_eles.Count; i++)
                {
                    TagretNode.Nodes.RemoveAt(remove_eles[i]);
                    int next_index = remove_eles.IndexOf(remove_eles[i]);
                    --remove_eles[next_index + 1];
                }
            }
            catch { }
        }

        /// <summary>
        /// 编辑值类型节点
        /// </summary>
        /// <param name="TargetNode">当前编辑的节点</param>
        /// <param name="target_string">当前选中的类型</param>
        private void ModifyValueNodes(TreeNode TargetNode,string target_string)
        {
            if(TargetNode.Tag.ToString().Trim() == value_type_0)
            {
                switch (target_string)
                {
                    case "constant":
                        {
                            //删除不必要的节点
                            if (TargetNode.Text.Trim() != "type:minecraft:constant")
                            {
                                while (TargetNode.Parent.Nodes.Count > 1)
                                {
                                    TargetNode.Parent.Nodes.RemoveAt(1);
                                }
                            }
                            else
                            {
                                TargetNode.Text = "type:minecraft:constant";
                                return;
                            }
                            TreeNode value = new TreeNode()
                            {
                                Text = "value",
                                Name = "parent_node",
                                Tag = "absolute,above_bottom,below_top",
                                ForeColor = Color.White
                            };
                            TreeNode sub_node = new TreeNode()
                            {
                                Text = "absolute:",
                                Name = "value:int",
                                ForeColor = Color.White
                            };
                            TargetNode.Parent.Nodes.Add(value);
                            value.Nodes.Add(sub_node);
                            TargetNode.Text = "type:minecraft:constant";
                            break;
                        }
                    case "uniform":
                    case "biased_to_bottom":
                    case "very_biased_to_bottom":
                    case "trapezoid":
                        {
                            //删除不必要的节点
                            if (TargetNode.Text.Trim() != "type:minecraft:" + target_string)
                            {
                                while (TargetNode.Parent.Nodes.Count > 1)
                                {
                                    TargetNode.Parent.Nodes.RemoveAt(1);
                                }
                            }
                            else
                            {
                                TargetNode.Text = "type:minecraft:" + target_string;
                                return;
                            }
                            TreeNode min_inclusive = new TreeNode()
                            {
                                Text = "min_inclusive",
                                Name = "parent_node",
                                Tag = "absolute,above_bottom,below_top",
                                ForeColor = Color.White
                            };
                            TreeNode max_inclusive = new TreeNode()
                            {
                                Text = "max_inclusive",
                                Name = "parent_node",
                                Tag = "absolute,above_bottom,below_top",
                                ForeColor = Color.White
                            };
                            TreeNode sub_node_0 = new TreeNode()
                            {
                                Text = "absolute:",
                                Name = "value:int",
                                ForeColor = Color.White
                            };
                            TreeNode sub_node_1 = new TreeNode()
                            {
                                Text = "absolute:",
                                Name = "value:int",
                                ForeColor = Color.White
                            };
                            TargetNode.Parent.Nodes.Add(min_inclusive);
                            TargetNode.Parent.Nodes.Add(max_inclusive);
                            min_inclusive.Nodes.Add(sub_node_0);
                            max_inclusive.Nodes.Add(sub_node_1);
                            TargetNode.Text = "type:minecraft:"+ target_string;
                            break;
                        }
                }
            }

            if(TargetNode.Tag.ToString().Trim() == value_type_1)
            {
                //删除不必要的节点
                if (TargetNode.Parent.Nodes[1].Nodes.Count > 0)
                    TargetNode.Parent.Nodes[1].Nodes.Clear();
                switch (target_string)
                {
                    case "constant":
                        {
                            TargetNode.Parent.Nodes[1].Name = "value:int";
                            TargetNode.Parent.Nodes[1].Text = "value:";
                            break;
                        }

                    case "uniform":
                        {
                            TargetNode.Parent.Nodes[1].Name = "parent_node";
                            TargetNode.Parent.Nodes[1].Text = TargetNode.Parent.Nodes[1].Text.Replace(":", "");
                            TreeNode min_inclusive = new TreeNode()
                            {
                                Text = "min_inclusive:",
                                Name = "value:int"
                            };
                            TreeNode max_exclusive = new TreeNode()
                            {
                                Text = "max_exclusive:",
                                Name = "value:int"
                            };
                            TargetNode.Parent.Nodes[1].Nodes.Add(min_inclusive);
                            TargetNode.Parent.Nodes[1].Nodes.Add(max_exclusive);
                            break;
                        }

                    case "clamped_normal":
                        {
                            TargetNode.Parent.Nodes[1].Name = "parent_node";
                            TargetNode.Parent.Nodes[1].Text = TargetNode.Parent.Nodes[1].Text.Replace(":", "");
                            TreeNode min = new TreeNode()
                            {
                                Text = "min:",
                                Name = "value:float"
                            };
                            TreeNode max = new TreeNode()
                            {
                                Text = "max:",
                                Name = "value:float"
                            };
                            TreeNode mean = new TreeNode()
                            {
                                Text = "mean:",
                                Name = "value:float"
                            };
                            TreeNode deviation = new TreeNode()
                            {
                                Text = "deviation:",
                                Name = "value:float"
                            };
                            TargetNode.Parent.Nodes[1].Nodes.Add(min);
                            TargetNode.Parent.Nodes[1].Nodes.Add(max);
                            TargetNode.Parent.Nodes[1].Nodes.Add(mean);
                            TargetNode.Parent.Nodes[1].Nodes.Add(deviation);
                            break;
                        }
                    case "trapezoid":
                        {
                            TargetNode.Parent.Nodes[1].Name = "parent_node";
                            TargetNode.Parent.Nodes[1].Text = TargetNode.Parent.Nodes[1].Text.Replace(":","");
                            TreeNode min = new TreeNode()
                            {
                                Text = "min:",
                                Name = "value:float"
                            };
                            TreeNode max = new TreeNode()
                            {
                                Text = "max:",
                                Name = "value:float"
                            };
                            TreeNode plateau = new TreeNode()
                            {
                                Text = "plateau:",
                                Name = "value:float"
                            };
                            TargetNode.Parent.Nodes[1].Nodes.Add(min);
                            TargetNode.Parent.Nodes[1].Nodes.Add(max);
                            TargetNode.Parent.Nodes[1].Nodes.Add(plateau);
                            break;
                        }
                }
                TargetNode.Text = "type:" + target_string;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            #region 处理节点层级更新
            string[] node_type = Array.Empty<string>();
            if (CurrentNode.Text.Contains(":"))
                node_type = CurrentNode.Text.Split(':');

            #region 处理雕刻器类型
            if (node_type.Length > 0 && node_type[0] == "type" && CurrentNode.Parent.Name == "root_node")
            {
                Modifying = true;
                ComboBox carver_type_box = new ComboBox()
                {
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    BackColor = Color.FromArgb(50,50,50),
                    ForeColor = Color.White,
                    Size = new Size(200,100),
                    Location = mouse_pos
                };
                string[] node_items = CurrentNode.Tag.ToString().Split(',');
                carver_type_box.Items.AddRange(node_items);
                carver_type_box.AutoCompleteCustomSource.AddRange(node_items);

                carver_type_box.KeyPress += (a,b) => 
                {
                    b.Handled = true;
                };
                carver_type_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        carver_view.Controls.Remove(carver_type_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        //处理underwater_canyon,underwater_cave
                        if (carver_type_box.SelectedText.Contains("underwater_canyon") || carver_type_box.SelectedText.Contains("underwater_cave"))
                        {
                            //保存当前父级节点
                            TreeNode parent_node = CurrentNode.Parent.Nodes[1];
                            //删除多余节点
                            try
                            {
                                List<int> remove_eles = new List<int> { };
                                foreach (TreeNode item in CurrentNode.Parent.Nodes[1].Nodes)
                                {
                                    if (BaseNodes.FindIndex(obj => item.Text.Contains(obj)) == -1)
                                    {
                                        remove_eles.Add(item.Index);
                                    }
                                }
                                for (int i = 0; i < remove_eles.Count; i++)
                                {
                                    parent_node.Nodes.RemoveAt(remove_eles[i]);
                                    int next_index = remove_eles.IndexOf(remove_eles[i]);
                                    --remove_eles[next_index + 1];
                                }
                            }
                            catch { }
                        }

                        //处理cave,nether_cave
                        if(carver_type_box.SelectedText.Contains("minecraft:cave") || carver_type_box.SelectedText.Contains("nether_cave"))
                        {
                            //保存父级节点
                            TreeNode parent_node = CurrentNode.Parent.Nodes[1];
                            //删除多余节点
                            DeleteSurplusNodes(parent_node,CaveNodes);

                            //添加洞穴节点
                            CarverType.cave cave_nodes = new CarverType.cave();
                            foreach (TreeNode item in cave_nodes.carver_view.Nodes[0].Nodes)
                            {
                                string currentText = CurrentNode.Text.Replace(node_type[0] + ":", "").Trim();
                                if (currentText.Contains("cave") || currentText.Contains("nether_cave"))
                                    break;
                                CurrentNode.Parent.Nodes[1].Nodes.Add(item);
                            }
                        }

                        //处理canyon
                        if(carver_type_box.SelectedText.Contains("minecraft:canyon"))
                        {
                            //保存父级节点
                            TreeNode parent_node = CurrentNode.Parent.Nodes[1];
                            //删除多余节点
                            DeleteSurplusNodes(parent_node,CanyonNodes);

                            //添加洞穴节点
                            CarverType.canyon canyon_nodes = new CarverType.canyon();
                            foreach (TreeNode item in canyon_nodes.canyon_view.Nodes[0].Nodes)
                            {
                                if (CurrentNode.Text.Replace(node_type[0]+":","").Trim().Contains("minecraft:canyon"))
                                    break;
                                CurrentNode.Parent.Nodes[1].Nodes.Add(item);
                            }
                        }

                        CurrentNode.Text = node_type[0]+":"+carver_type_box.SelectedText.Trim();
                        Modifying = false;
                        carver_view.Controls.Remove(carver_type_box);
                    }
                };

                carver_view.Controls.Add(carver_type_box);
                carver_type_box.BringToFront();
                return;
            }
            #endregion

            #region 处理对象值类型
            if(CurrentNode.Name == "value:string" && (CurrentNode.Tag.ToString().Trim() == value_type_0 || CurrentNode.Tag.ToString().Trim() == value_type_1))
            {
                Modifying = true;
                ComboBox value_select_box = new ComboBox()
                {
                    Location = mouse_pos,
                    Size = new Size(200,100),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50,50,50)
                };
                string[] node_items = CurrentNode.Tag.ToString().Trim().Split(',');
                value_select_box.Items.AddRange(node_items);

                value_select_box.KeyPress += (a,b) => { b.Handled = true; };
                value_select_box.KeyDown += (a,b) =>
                {
                    if(b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        carver_view.Controls.Remove(value_select_box);
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        //更新当前层级的节点
                        string value_model = value_select_box.Text.Trim().Replace("minecraft:","");
                        ModifyValueNodes(CurrentNode, value_model);
                        Modifying = false;
                        carver_view.Controls.Remove(value_select_box);
                    }
                };

                carver_view.Controls.Add(value_select_box);
                value_select_box.BringToFront();
                return;
            }
            #endregion

            #region 处理值的键值类型
            if (CurrentNode.Name == "parent_node" && CurrentNode.Tag != null)
            {
                Modifying = true;
                ComboBox value_select_box = new ComboBox()
                {
                    Location = mouse_pos,
                    Size = new Size(200, 100),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                string[] node_items = CurrentNode.Tag.ToString().Trim().Split(',');
                value_select_box.Items.AddRange(node_items);

                value_select_box.KeyPress += (a, b) => { b.Handled = true; };
                value_select_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        carver_view.Controls.Remove(value_select_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Nodes[0].Text = value_select_box.Text.Trim()+":";
                        Modifying = false;
                        carver_view.Controls.Remove(value_select_box);
                    }
                };

                carver_view.Controls.Add(value_select_box);
                value_select_box.BringToFront();
                return;
            }
            #endregion

            #endregion

            #region 处理节点数据更新
            if(CurrentNode.Name == "root_node")
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
                        carver_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = textBox.Text.Trim();
                        carver_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                };

                carver_view.Controls.Add(textBox);
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
                                    carver_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    carver_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            carver_view.Controls.Add(textBox);
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
                                    carver_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Value;
                                    carver_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            carver_view.Controls.Add(value_box);
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
                                    carver_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    carver_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            carver_view.Controls.Add(textBox);
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
                                    carver_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Text.Trim();
                                    carver_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            value_box.Items.Add("true");
                            value_box.Items.Add("false");
                            value_box.AutoCompleteCustomSource.Add("true");
                            value_box.AutoCompleteCustomSource.Add("false");
                            carver_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                    case "tag":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            #region 设置方块ID和属性
                            if (node_type[0] == "Name" && CurrentNode.Parent.Name == "parent_node" && CurrentNode.Parent.Text == "air_state")
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

                                value_box.KeyDown += (a,b) => 
                                {
                                    if(b.KeyCode == Keys.Escape)
                                    {
                                        Modifying = false;
                                        carver_view.Controls.Remove(value_box);
                                    }
                                    if(b.KeyCode == Keys.Enter)
                                    {
                                        Modifying = false;
                                        carver_view.Controls.Remove(value_box);

                                        #region 设置属性
                                        //判断是否清空属性节点
                                        if (CurrentNode.Text.Replace(CurrentText+":","") == value_box.Text.Trim())
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

                                carver_view.Controls.Add(value_box);
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

                            tag_box.KeyDown += (a,b) => 
                            {
                                if(b.KeyCode == Keys.Escape)
                                {
                                    Modifying = false;
                                    carver_view.Controls.Remove(tag_box);
                                }
                                if(b.KeyCode == Keys.Enter)
                                {
                                    Modifying = false;
                                    carver_view.Controls.Remove(tag_box);

                                    CurrentNode.Text = CurrentText+":"+tag_box.Text.Trim();
                                }
                            };

                            carver_view.Controls.Add(tag_box);
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
            if (CurrentNode.Name == "list_ele" || CurrentNode.Name == "array_ele")
                CurrentNode.Parent.Nodes.Remove(CurrentNode);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if(CurrentNode.Name == "list_node" || CurrentNode.Name == "array_node")
                CurrentNode.Nodes.Clear();
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
            StartSpawn(carver_view.Nodes[0]);
            result += "}";

            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "请选择雕刻器生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };
            if (folder.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folder.SelectedPath + "\\" + carver_view.Nodes[0].Text + ".json", result, new UTF8Encoding(false));
                Process.Start(folder.SelectedPath);
                history_path = folder.SelectedPath;
            }
        }

        private void carver_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Modifying)
            {
                CurrentNode = carver_view.SelectedNode;
                mouse_pos = e.Location;
            }
        }
    }
}
