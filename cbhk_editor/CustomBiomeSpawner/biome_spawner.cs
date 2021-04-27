using cbhk_editor.CustomBiomeSpawner.BiomeNodes;
using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace cbhk_editor.CustomBiomeSpawner
{
    public partial class biome_spawner : Form
    {
        Form parent = new Form();
        SoundPlayer click_sound = new SoundPlayer();
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        //保存当前节点
        TreeNode CurrentNode = new TreeNode();
        //表示当前正在操作
        bool Modifying = false;
        //保存当前鼠标坐标
        Point mouse_pos = new Point();

        //保存最终结果
        private string result = "{";
        //是否需要添加逗号
        private bool NeedComma = false;
        //保存历史生成路径
        private string history_path = "";
        //保存生物群系id
        List<string> Biomes = new List<string> { };
        //保存方块集合对象
        TreeView Blocks_view = Cbhk_form.Blocks;
        //保存方块列表
        List<string> Blocks = new List<string> { };
        //保存实体列表
        List<string> Entities = new List<string> { };
        public biome_spawner(Form obj,SoundPlayer soundPlayer)
        {
            InitializeComponent();
            parent = obj;
            click_sound = soundPlayer;
            InitUISettings();

            //读取生物群系id列表
            string[] biome_pathes = Directory.GetFiles(Application.StartupPath+ "\\generates\\generated1.16.3\\reports\\biomes");
            foreach (string item in biome_pathes)
            {
                Biomes.Add("minecraft:"+Path.GetFileNameWithoutExtension(item));
            }
            //读取方块列表
            foreach (TreeNode item in Blocks_view.Nodes)
            {
                Blocks.Add(item.Text);
            }
            //读取实体列表
            foreach (TreeNode item in Cbhk_form.register.Nodes)
            {
                if(item.Text.Trim() == "minecraft:entity_type")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text.Trim() == "entries")
                        {
                            foreach (TreeNode a_entry in entry.Nodes)
                            {
                                Entities.Add(a_entry.Text);
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void InitUISettings()
        {
            biomes_view.ExpandAll();
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
            foreach (ToolStripMenuItem item in biome_title_menu.Items)
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
            #region 处理根节点
            if (CurrentNode.Name == "root_node")
            {
                Modifying = true;
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
                        biomes_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = textBox.Text.Trim();
                        biomes_view.Controls.Remove(textBox);
                        Modifying = false;
                    }
                };

                biomes_view.Controls.Add(textBox);
                textBox.BringToFront();
                return;
            }
            #endregion

            #region 处理节点数据更新
            //处理各种值
            if (CurrentNode.Name.Contains("value"))
            {
                string value_type = CurrentNode.Name.Split(':')[1];
                switch (value_type)
                {
                    case "tag":
                        {
                            Modifying = true;
                            string node_name = CurrentNode.Text.Split(':')[0];
                            #region 处理实体ID
                            if (node_name.Trim() == "type" && CurrentNode.Parent.Parent.Text == "spawners" && CurrentNode.Parent.Parent.Name == "objects_node")
                            {
                                ComboBox entity_box = new ComboBox()
                                {
                                    AutoCompleteMode = AutoCompleteMode.Suggest,
                                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                                    Location = mouse_pos,
                                    Size = new Size(200, 100),
                                    ForeColor = Color.FromArgb(255, 255, 255),
                                    BackColor = Color.FromArgb(50, 50, 50)
                                };
                                entity_box.KeyDown += (a, b) =>
                                {
                                    if (b.KeyCode == Keys.Escape)
                                    {
                                        Modifying = false;
                                        biomes_view.Controls.Remove(entity_box);
                                    }
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        Modifying = false;
                                        biomes_view.Controls.Remove(entity_box);
                                        CurrentNode.Text = node_name + ":" + entity_box.Text.Trim();
                                    }
                                };

                                entity_box.Items.AddRange(Entities.ToArray());
                                entity_box.AutoCompleteCustomSource.AddRange(Entities.ToArray());
                                biomes_view.Controls.Add(entity_box);
                                entity_box.BringToFront();
                            }
                            #endregion
                            break;
                        }
                    case "string":
                        {
                            Modifying = true;
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            if (CurrentNode.Tag == null)
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
                                        biomes_view.Controls.Remove(textBox);
                                        Modifying = false;
                                    }
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                        biomes_view.Controls.Remove(textBox);
                                        Modifying = false;
                                    }
                                };

                                biomes_view.Controls.Add(textBox);
                                textBox.BringToFront();
                            }
                            else
                            {
                                ComboBox content_box = new ComboBox()
                                {
                                    AutoCompleteMode = AutoCompleteMode.Suggest,
                                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                                    Location = mouse_pos,
                                    Size = new Size(200, 100),
                                    ForeColor = Color.FromArgb(255, 255, 255),
                                    BackColor = Color.FromArgb(50,50,50)
                                };

                                string[] tag_content = CurrentNode.Tag.ToString().Split(',');
                                content_box.Items.AddRange(tag_content);
                                content_box.AutoCompleteCustomSource.AddRange(tag_content);
                                content_box.KeyDown += (a,b) => 
                                {
                                    if(b.KeyCode == Keys.Escape)
                                    {
                                        Modifying = false;
                                        biomes_view.Controls.Remove(content_box);
                                    }
                                    if(b.KeyCode == Keys.Enter)
                                    {
                                        Modifying = false;
                                        biomes_view.Controls.Remove(content_box);
                                        CurrentNode.Text = CurrentText + ":" + content_box.Text.Trim();
                                    }
                                };
                                biomes_view.Controls.Add(content_box);
                                content_box.BringToFront();
                            }
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
                                    biomes_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Value;
                                    biomes_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            biomes_view.Controls.Add(value_box);
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
                                    TextBox tb = a as TextBox;

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
                                    biomes_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    biomes_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            biomes_view.Controls.Add(textBox);
                            textBox.BringToFront();
                            break;
                        }
                    case "bool":
                        {
                            Modifying = true;
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
                                    biomes_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Text.Trim();
                                    biomes_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            value_box.Items.Add("true");
                            value_box.Items.Add("false");
                            value_box.AutoCompleteCustomSource.Add("true");
                            value_box.AutoCompleteCustomSource.Add("false");
                            biomes_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                }
                return;
            }
            #endregion

            #region 处理节点层级更新
            //处理空气及流体节点
            if(CurrentNode.Parent.Name == "parent_node" && CurrentNode.Parent.Text == "carvers" && CurrentNode.Name == "list_node")
            {
                Modifying = true;
                ComboBox blocks_box = new ComboBox()
                {
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Location = mouse_pos,
                    Size = new Size(200, 100),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                blocks_box.Items.AddRange(Blocks.ToArray());
                blocks_box.AutoCompleteCustomSource.AddRange(Blocks.ToArray());
                biomes_view.Controls.Add(blocks_box);

                //处理方块节点更新
                blocks_box.KeyDown += (a,b) => 
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(blocks_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(blocks_box);
                        TreeNode block_node = new TreeNode()
                        {
                            Text = blocks_box.Text.Trim(),
                            Name = "list_ele"
                        };
                        CurrentNode.Nodes.Add(block_node);
                    }
                };
                blocks_box.BringToFront();
            }

            //处理特性列表组
            if(CurrentNode.Name == "list_node" && CurrentNode.Text == "features")
            {
                TreeNode group_node = new TreeNode()
                {
                    Text = CurrentNode.Nodes.Count + 1 + "",
                    Name = "list_node"
                };
                Modifying = false;
                CurrentNode.Nodes.Add(group_node);
            }

            //处理特性列表元素
            if(CurrentNode.Name == "list_node" && CurrentNode.Parent.Text.Trim() == "features" && CurrentNode.Parent.Name == "list_node")
            {
                Modifying = true;
                TextBox feature_box = new TextBox()
                {
                    Location = mouse_pos,
                    Size = new Size(200, 100),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                //处理特性节点更新
                feature_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(feature_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(feature_box);
                        TreeNode group_node = new TreeNode()
                        {
                            Text = feature_box.Text.Trim(),
                            Name = "list_ele"
                        };
                        CurrentNode.Nodes.Add(group_node);
                    }
                };
                biomes_view.Controls.Add(feature_box);
                feature_box.BringToFront();
            }

            //处理生物群系所生成的结构
            if(CurrentNode.Name == "list_node" && CurrentNode.Text.Trim() == "starts")
            {
                Modifying = true;
                ComboBox biome_box = new ComboBox()
                {
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Location = mouse_pos,
                    Size = new Size(200, 100),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    BackColor = Color.FromArgb(50, 50, 50)
                };

                biome_box.Items.AddRange(Biomes.ToArray());
                biome_box.AutoCompleteCustomSource.AddRange(Biomes.ToArray());
                biomes_view.Controls.Add(biome_box);

                biome_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(biome_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(biome_box);
                        TreeNode block_node = new TreeNode()
                        {
                            Text = biome_box.Text.Trim(),
                            Name = "list_ele"
                        };
                        CurrentNode.Nodes.Add(block_node);
                    }
                };

                biome_box.BringToFront();
            }

            //处理实体生成设置
            if(CurrentNode.Name == "objects_node" && CurrentNode.Text.Trim() == "spawners")
            {
                Modifying = true;
                spawners spawners_node = new spawners();
                //设置值类型
                ComboBox spawner_type = new ComboBox()
                {
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Location = mouse_pos,
                    Size = new Size(200, 100),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                //添加成员
                string[] spawner_value = CurrentNode.Tag.ToString().Split(',');
                spawner_type.Items.AddRange(spawner_value);
                spawner_type.AutoCompleteCustomSource.AddRange(spawner_value);
                spawner_type.KeyDown += (a,b) => 
                {
                    if(b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(spawner_type);
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        Modifying = false;
                        //添加元素节点
                        TreeNode spawner_ele = new TreeNode()
                        {
                            Text = spawner_type.Text.Trim(),
                            Name = "array_node"
                        };
                        CurrentNode.Nodes.Add(spawner_ele);
                        //添加内容
                        foreach (TreeNode item in spawners_node.spawners_view.Nodes[0].Nodes)
                        {
                            spawner_ele.Nodes.Add(item);
                        }
                        biomes_view.Controls.Remove(spawner_type);
                    }
                };
                biomes_view.Controls.Add(spawner_type);
                spawner_type.BringToFront();
            }

            //处理生成代价
            if(CurrentNode.Name == "objects_node" && CurrentNode.Text.Trim() == "spawn_costs")
            {
                Modifying = true;
                ComboBox entity_box = new ComboBox()
                {
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Location = new Point(mouse_pos.X,mouse_pos.Y - 20),
                    Size = new Size(200, 100),
                    ForeColor = Color.FromArgb(255, 255, 255),
                    BackColor = Color.FromArgb(50, 50, 50)
                };
                entity_box.Items.AddRange(Entities.ToArray());
                entity_box.AutoCompleteCustomSource.AddRange(Entities.ToArray());

                entity_box.KeyDown += (a,b) => 
                {
                    if(b.KeyCode == Keys.Escape)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(entity_box);
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        Modifying = false;
                        biomes_view.Controls.Remove(entity_box);
                        TreeNode a_entity = new TreeNode()
                        {
                            Text = entity_box.Text.Trim(),
                            Name = "array_ele"
                        };
                        TreeNode energy_budget = new TreeNode()
                        {
                            Text = "energy_budget:",
                            Name = "value:double"
                        };
                        TreeNode charge = new TreeNode()
                        {
                            Text = "charge:",
                            Name = "value:double"
                        };
                        a_entity.Nodes.Add(energy_budget);
                        a_entity.Nodes.Add(charge);
                        CurrentNode.Nodes.Add(a_entity);
                    }
                };

                biomes_view.Controls.Add(entity_box);
                entity_box.BringToFront();
            }
            #endregion
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "array_ele" || CurrentNode.Name == "list_ele" || CurrentNode.Name == "ele")
                biomes_view.Nodes.Remove(CurrentNode);
            if (CurrentNode.Name.Contains("value") && (CurrentNode.Parent.Name == "array_node" || CurrentNode.Parent.Name == "list_node"))
                biomes_view.Nodes.Remove(CurrentNode);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "list_node" || CurrentNode.Name == "array_node")
                CurrentNode.Nodes.Clear();
        }

        private void add_rclick_Click(object sender, EventArgs e)
        {
            add_Click(null,null);
        }

        private void delete_rclick_Click(object sender, EventArgs e)
        {
            delete_Click(null,null);
        }

        private void clear_rclick_Click(object sender, EventArgs e)
        {
            clear_Click(null,null);
        }

        private void StartSpawn(TreeNode SelectNode)
        {
            foreach (TreeNode subnode in SelectNode.Nodes)
            {
                if (subnode.Name.Contains("value:"))
                {
                    if (subnode.Name.Contains("string"))
                    {
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            int index = subnode.Text.IndexOf(":");
                            result += "\"" + subnode.Text.Insert(index, "\"").Insert(index + 2, "\"") + "\"";
                            NeedComma = true;
                        }
                    }
                    else
                    if (subnode.Text.Contains(":") && (subnode.Text.IndexOf(':') + 1) < subnode.Text.Length)
                    {
                        int index = subnode.Text.IndexOf(":");
                        result += "\"" + subnode.Text.Insert(index, "\"").Insert(index + 2, "\"") + "\"";
                        NeedComma = true;
                    }

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
                    case "objects_node":
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

                //更正格式
                if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && (result.EndsWith("]") || result.EndsWith("}")))
                    result += ",";

                switch (subnode.Name)
                {
                    case "parent_node":
                    case "objects_node":
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
            //清除多余的逗号
            result = result.TrimEnd(',');
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            result = "{";
            StartSpawn(biomes_view.Nodes[0]);
            result += "}";

            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "请选择生物群系生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };
            if (folder.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folder.SelectedPath + "\\" + biomes_view.Nodes[0].Text + ".json", result, new UTF8Encoding(false));
                Process.Start(folder.SelectedPath);
                history_path = folder.SelectedPath;
            }
        }

        private void biomes_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Modifying)
            {
                CurrentNode = biomes_view.SelectedNode;
                mouse_pos = e.Location;
            }
        }
    }
}
