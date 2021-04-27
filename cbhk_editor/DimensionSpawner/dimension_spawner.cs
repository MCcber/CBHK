using cbhk_editor.DimensionSpawner.BiomeSource;
using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace cbhk_editor.DimensionSpawner
{
    public partial class dimension_spawner : Form
    {
        Form parent;
        SoundPlayer click_sound = new SoundPlayer();
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        string[] dimension_types = new string[] { "minecraft:overworld", "minecraft:overworld_caves", "minecraft:the_nether", "minecraft:the_end" };
        string[] noise_settings = new string[] { "minecraft:amplified", "minecraft:caves", "minecraft:end", "minecraft:floating_islands", "minecraft:nether", "minecraft:overworld" };
        string[] BiomeSourceList;

        //保存当前节点
        TreeNode CurrentNode = new TreeNode();
        //表示当前正在操作
        bool Modifying = false;
        //保存当前鼠标坐标
        Point mouse_pos = new Point();

        //保存群系
        List<string> BiomeData = new List<string> { };
        //保存结构
        List<string> StructureData = new List<string> { };
        //保存根节点
        TreeView Root;
        //保存方块节点
        TreeView Blocks;
        //保存最终结果
        private string result = "{";
        //是否需要添加逗号
        private bool NeedComma = false;
        //保存历史生成路径
        private string history_path = "";

        public dimension_spawner(Form obj,SoundPlayer soundPlayer)
        {
            InitializeComponent();

            parent = obj;
            click_sound = soundPlayer;

            InitUISettings();

            Blocks = Cbhk_form.Blocks;

            //导入群系和结构
            Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:worldgen/structure_feature")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_entry in entry.Nodes)
                                StructureData.Add(a_entry.Text);
                        }
                    }
                }
            }
            if(Directory.Exists(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\biomes"))
            {
                string[] biomes = Directory.GetFiles(Application.StartupPath + "\\generates\\generated1.16.3\\reports\\biomes");
                for (int i = 0; i < biomes.Length; i++)
                    BiomeData.Add(Path.GetFileNameWithoutExtension(biomes[i]));
            }
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            dimension_view.ExpandAll();
            dimension_view.SelectedNode = dimension_view.Nodes[0];
            CurrentNode = dimension_view.SelectedNode;
            click_to_return.Click += (a, b) => {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            foreach (ToolStripMenuItem item in dimension_title_menu.Items)
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

        private void add_menu_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "root_node")
                return;

            #region 处理节点层级更新

            #region 处理维度类型选择
            if (CurrentNode.Parent.Name == "root_node" && CurrentNode.Text.Split(':')[0].Contains("type"))
            {
                Modifying = true;
                ComboBox dtype = new ComboBox()
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Size = new Size(150,25),
                    Location = mouse_pos
                };

                dtype.KeyDown += (a,b) => 
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(dtype);
                        Modifying = false;
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        if(dtype.Text.Trim() != "object")
                        {
                            CurrentNode.Text = "type:"+ dtype.Text.Trim();
                            CurrentNode.Nodes.Clear();
                        }
                        else
                        {
                            CurrentNode.Text = "type";
                            dimension_type dt = new dimension_type();
                            foreach (TreeNode item in dt.dimension_type_view.Nodes[0].Nodes)
                            {
                                CurrentNode.Nodes.Add(item);
                            }
                        }
                        dimension_view.Controls.Remove(dtype);
                        Modifying = false;
                    }
                };

                string[] dps = CurrentNode.Tag.ToString().Split(',');
                dtype.Items.AddRange(dps);
                dtype.AutoCompleteCustomSource.AddRange(dimension_types);
                dimension_view.Controls.Add(dtype);
                dtype.BringToFront();
                return;
            }
            #endregion

            #region 处理生成器类型选择
            if(CurrentNode.Parent != null && CurrentNode.Parent.Parent != null && CurrentNode.Parent.Parent.Name == "root_node" && CurrentNode.Text.Contains("type"))
            {
                Modifying = true;
                ComboBox gtype = new ComboBox()
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    Size = new Size(200, 25),
                    Location = mouse_pos
                };

                gtype.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(gtype);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        switch (gtype.Text.Trim())
                        {
                            case "minecraft:noise":
                                {
                                    //清空不相关子级
                                    foreach (TreeNode item in CurrentNode.Parent.Nodes)
                                    {
                                        if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                        {
                                            CurrentNode.Parent.Nodes.Remove(item);
                                        }
                                    }
                                    generator_noise gn = new generator_noise();
                                    foreach (TreeNode item in gn.noise_view.Nodes[0].Nodes)
                                    {
                                        CurrentNode.Parent.Nodes.Add(item);
                                    }
                                    CurrentNode.Text = "type:"+gtype.Text.Trim();
                                    Modifying = false;
                                    break;
                                }
                            case "minecraft:debug":
                                {
                                    foreach (TreeNode item in CurrentNode.Parent.Nodes)
                                    {
                                        if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                            CurrentNode.Parent.Nodes.Remove(item);
                                    }
                                    foreach (TreeNode item in CurrentNode.Parent.Nodes)
                                    {
                                        if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                            CurrentNode.Parent.Nodes.Remove(item);
                                    }
                                    CurrentNode.Text = "type:" + gtype.Text.Trim();
                                    Modifying = false;
                                    break;
                                }
                            case "minecraft:flat":
                                {
                                    //清空不相关子级
                                    foreach (TreeNode item in CurrentNode.Parent.Nodes)
                                    {
                                        if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                            CurrentNode.Parent.Nodes.Remove(item);
                                    }
                                    generator_flat gf = new generator_flat();
                                    foreach (TreeNode item in gf.flat_view.Nodes[0].Nodes)
                                    {
                                        CurrentNode.Parent.Nodes.Add(item);
                                    }
                                    CurrentNode.Text = "type:" + gtype.Text.Trim();
                                    Modifying = false;
                                    break;
                                }
                        }
                        dimension_view.Controls.Remove(gtype);
                    }
                };

                string[] dps = CurrentNode.Tag.ToString().Split(',');
                gtype.Items.AddRange(dps);
                gtype.AutoCompleteCustomSource.AddRange(dimension_types);
                dimension_view.Controls.Add(gtype);
                gtype.BringToFront();
                return;
            }
            #endregion

            #region 处理群系资源类型
            if(CurrentNode.Text.Contains("type") && CurrentNode.Name == "value:string" && CurrentNode.Parent.Text == "biome_source" && CurrentNode.Parent.Name == "parent_node")
            {
                Modifying = true;
                ComboBox biomeSourceType = new ComboBox()
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50,50,50),
                    Size = new Size(200,25),
                    Location = mouse_pos,
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource
                };

                biomeSourceType.KeyDown += (a,b) => 
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(biomeSourceType);
                        Modifying = false;
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        if (biomeSourceType.Text.Trim().Contains("vanilla_layered"))
                        {
                            //拥有大型群系
                            bool large_biomes = false;
                            //拥有群系
                            bool legacy_biome_init_layer = false;
                            //清除不必要的节点
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                string type_string = item.Text.Split(':')[0];
                                if (!type_string.Contains("seed") && !type_string.Contains("large_biomes") && !type_string.Contains("legacy_biome_init_layer") && !type_string.Contains("type"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                                if (type_string.Contains("large_biomes"))
                                    large_biomes = true;
                                if (type_string.Contains("legacy_biome_init_layer"))
                                    legacy_biome_init_layer = true;
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                string type_string = item.Text.Split(':')[0];
                                if (!type_string.Contains("seed") && !type_string.Contains("large_biomes") && !type_string.Contains("legacy_biome_init_layer") && !type_string.Contains("type"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                string type_string = item.Text.Split(':')[0];
                                if (!type_string.Contains("seed") && !type_string.Contains("large_biomes") && !type_string.Contains("legacy_biome_init_layer") && !type_string.Contains("type"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }

                            if (!large_biomes)
                            {
                                TreeNode large_node = new TreeNode()
                                {
                                    Text = "large_biomes:false",
                                    Name = "value:bool"
                                };
                                CurrentNode.Parent.Nodes.Add(large_node);
                            }
                            if (!legacy_biome_init_layer)
                            {
                                TreeNode legacy_node = new TreeNode()
                                {
                                    Text = "legacy_biome_init_layer:false",
                                    Name = "value:bool"
                                };
                                CurrentNode.Parent.Nodes.Add(legacy_node);
                            }
                            Modifying = false;
                        }

                        if (biomeSourceType.Text.Trim().Contains("the_end"))
                        {
                            //清除不必要的节点
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("type") && !item.Text.Contains("seed"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }

                            Modifying = false;
                        }

                        if (biomeSourceType.Text.Trim().Contains("multi_noise"))
                        {
                            List<string> NodeList = new List<string> { "type", "seed", "firstOctave", "amplitudes", "altitude_noise", "temperature_noise", "humidity_noise", "weirdness_noise", "biomes" };
                            List<bool> HaveNode = new List<bool> { false,false,false, false, false, false, false, false, false };

                            //清除不必要节点
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                int index = NodeList.FindIndex(obj => item.Text.Contains(obj));
                                if (index == -1)
                                    CurrentNode.Parent.Nodes.Remove(item);
                                else
                                    HaveNode[index] = true;
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (NodeList.FindIndex(obj => item.Text.Contains(obj)) == -1)
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (NodeList.FindIndex(obj => item.Text.Contains(obj)) == -1)
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }

                            multi_noise mo = new multi_noise();
                            foreach (TreeNode item in mo.multi_noise_view.Nodes[0].Nodes)
                            {
                                int index = NodeList.FindIndex(obj => item.Text == obj);
                                if (!HaveNode[index])
                                CurrentNode.Parent.Nodes.Add(item);
                            }

                            Modifying = false;
                        }

                        if (biomeSourceType.Text.Trim().Contains("fixed"))
                        {
                            //移除不必要的节点
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biome:"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biome:"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biome:"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }

                            TreeNode biome = new TreeNode()
                            {
                                Text = "biome:",
                                Name = "value:string"
                            };
                            CurrentNode.Parent.Nodes.Add(biome);

                            Modifying = false;
                        }

                        if (biomeSourceType.Text.Trim().Contains("checkerboard"))
                        {
                            //移除不必要的节点
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biomes"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biomes"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if (item != null && !item.Text.Contains("seed") && !item.Text.Contains("type") && !item.Text.Contains("biomes"))
                                    CurrentNode.Parent.Nodes.Remove(item);
                            }

                            TreeNode biomes = new TreeNode()
                            {
                                Text = "biomes",
                                Name = "list_node"
                            };
                            CurrentNode.Parent.Nodes.Add(biomes);

                            Modifying = false;
                        }

                        dimension_view.Controls.Remove(biomeSourceType);
                        CurrentNode.Text = "type:"+biomeSourceType.Text.Trim();
                    }
                };

                BiomeSourceList = CurrentNode.Tag.ToString().Split(',');
                biomeSourceType.Items.AddRange(BiomeSourceList);
                biomeSourceType.AutoCompleteCustomSource.AddRange(BiomeSourceList);
                dimension_view.Controls.Add(biomeSourceType);
                biomeSourceType.BringToFront();
                return;
            }
            #endregion

            #region 处理生成器设置参数
            if(CurrentNode.Name == "value:tag" && CurrentNode.Text.Substring(0,8) == "settings" && CurrentNode.Parent.Text == "generator" && CurrentNode.Parent.Name == "parent_node")
            {
                Modifying = true;
                string[] setting_type = CurrentNode.Tag.ToString().Split(',');
                ComboBox setting_box = new ComboBox()
                {
                    Size = new Size(200,25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50,50,50),
                    AutoCompleteMode = AutoCompleteMode.Suggest,
                    AutoCompleteSource = AutoCompleteSource.CustomSource
                };

                setting_box.KeyDown += (a,b) =>
                {
                    if(b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(setting_box);
                        Modifying = false;
                    }
                    if(b.KeyCode == Keys.Enter)
                    {
                        if (setting_box.Text.Trim() != "object")
                        {
                            CurrentNode.Text = "settings:"+setting_box.Text.Trim();
                            CurrentNode.Nodes.Clear();
                        }
                        else
                        {
                            settings set_node = new settings();
                            foreach (TreeNode item in set_node.settings_view.Nodes[0].Nodes)
                            {
                                CurrentNode.Nodes.Add(item);
                            }
                            CurrentNode.Text = "settings";
                        }
                        dimension_view.Controls.Remove(setting_box);
                        Modifying = false;
                    }
                };

                setting_box.Items.AddRange(setting_type);
                setting_box.AutoCompleteCustomSource.AddRange(setting_type);
                dimension_view.Controls.Add(setting_box);
                setting_box.BringToFront();
                return;
            }
            #endregion

            #endregion

            #region 处理节点数据更新
            //处理带Tag的节点数据
            if(CurrentNode.Name.Contains("value") && CurrentNode.Tag != null)
            {
                Modifying = true;
                string CurrentText = CurrentNode.Text.Split(':')[0];
                ComboBox property_box = new ComboBox()
                {
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                property_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(property_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = CurrentText + ":" + property_box.Text.Trim();
                        dimension_view.Controls.Remove(property_box);
                        Modifying = false;
                    }
                };

                string[] tag_data = CurrentNode.Tag.ToString().Split(',');
                property_box.Items.AddRange(tag_data);
                property_box.AutoCompleteCustomSource.AddRange(tag_data);

                dimension_view.Controls.Add(property_box);
                property_box.BringToFront();
                return;
            }

            //处理群系参数
            if(CurrentNode.Parent.Text == "biome_source" && CurrentNode.Text == "biomes" && CurrentNode.Name == "array_node")
            {
                muti_noise_biomes mnb = new muti_noise_biomes();
                TreeNode element = new TreeNode()
                {
                    Text = CurrentNode.Nodes.Count + 1 + "",
                    Name = "array_ele"
                };
                CurrentNode.Nodes.Add(element);
                foreach (TreeNode item in mnb.biomes_view.Nodes[0].Nodes)
                    element.Nodes.Add(item);
                return;
            }

            //处理群系数据
            if((CurrentNode.Name == "list_node" && CurrentNode.Text == "biomes") || CurrentNode.Text.Split(':')[0] == "biome")
            {
                Modifying = true;
                if (CurrentNode.Text.Split(':')[0].Contains("biome") && CurrentNode.Text.Contains(":"))
                {
                    ComboBox biome_box = new ComboBox()
                    {
                        Size = new Size(200, 25),
                        Location = mouse_pos,
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(50, 50, 50),
                        AutoCompleteSource = AutoCompleteSource.CustomSource,
                        AutoCompleteMode = AutoCompleteMode.Suggest
                    };

                    biome_box.KeyDown += (a, b) =>
                    {
                        string CurrentText = CurrentNode.Text.Split(':')[0];
                        if (b.KeyCode == Keys.Escape)
                        {
                            dimension_view.Controls.Remove(biome_box);
                            Modifying = false;
                        }
                        if (b.KeyCode == Keys.Enter)
                        {
                            CurrentNode.Text = CurrentText + ":minecraft:" + biome_box.Text.Trim();
                            dimension_view.Controls.Remove(biome_box);
                            Modifying = false;
                        }
                    };

                    biome_box.Items.AddRange(BiomeData.ToArray());
                    biome_box.AutoCompleteCustomSource.AddRange(BiomeData.ToArray());
                    dimension_view.Controls.Add(biome_box);
                    biome_box.BringToFront();
                }
                else
                {
                    CheckedListBox biomes_box = new CheckedListBox()
                    {
                        Size = new Size(200,100),
                        Location = mouse_pos,
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(50, 50, 50)
                    };

                    biomes_box.Items.AddRange(BiomeData.ToArray());
                    biomes_box.KeyDown += (a, b) =>
                    {
                        if (b.KeyCode == Keys.Escape)
                        {
                            dimension_view.Controls.Remove(biomes_box);
                            Modifying = false;
                        }
                        if (b.KeyCode == Keys.Enter)
                        {
                            for (int i = 0; i < biomes_box.Items.Count; i++)
                            {
                                if(biomes_box.GetItemChecked(i))
                                {
                                    TreeNode biome_node = new TreeNode()
                                    {
                                        Text = "minecraft:"+biomes_box.Items[i].ToString(),
                                        Name = "list_ele"
                                    };
                                    CurrentNode.Nodes.Add(biome_node);
                                }
                            }
                            dimension_view.Controls.Remove(biomes_box);
                            Modifying = false;
                        }
                    };

                    dimension_view.Controls.Add(biomes_box);
                    biomes_box.BringToFront();
                }
                return;
            }

            //处理平坦层
            if(CurrentNode.Name == "array_node" && CurrentNode.Text == "layers")
            {
                Modifying = true;
                ComboBox layer_box = new ComboBox()
                {
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                layer_box.KeyDown += (a, b) =>
                {
                    string CurrentText = CurrentNode.Text.Split(':')[0];
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(layer_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        TreeNode element = new TreeNode()
                        {
                            Text = CurrentNode.Nodes.Count + 1 + "",
                            Name = "array_ele"
                        };
                        TreeNode block_node = new TreeNode()
                        {
                            Text = "block:"+layer_box.Text.Trim(),
                            Name = "value:string"
                        };
                        TreeNode height_node = new TreeNode()
                        {
                            Text = "height:1",
                            Name = "value:int"
                        };
                        CurrentNode.Nodes.Add(element);
                        element.Nodes.Add(block_node);
                        element.Nodes.Add(height_node);
                        dimension_view.Controls.Remove(layer_box);
                        Modifying = false;
                    }
                };

                foreach (TreeNode item in Blocks.Nodes)
                {
                    layer_box.Items.Add(item.Text);
                    layer_box.AutoCompleteCustomSource.Add(item.Text);
                }
                dimension_view.Controls.Add(layer_box);
                layer_box.BringToFront();
                return;
            }

            //处理结构数据
            if(CurrentNode.Name == "array_node" && CurrentNode.Text == "structures" && CurrentNode.Parent.Text == "structures" && CurrentNode.Parent.Name == "parent_node")
            {
                Modifying = true;
                ComboBox structure_box = new ComboBox()
                {
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                structure_box.KeyDown += (a, b) =>
                {
                    string CurrentText = CurrentNode.Text.Split(':')[0];
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(structure_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        TreeNode structure = new TreeNode()
                        {
                            Text = structure_box.Text.Trim(),
                            Name = "array_ele"
                        };
                        TreeNode spacing = new TreeNode()
                        {
                            Text = "sacing:10",
                            Name = "value:int"
                        };
                        TreeNode separation = new TreeNode()
                        {
                            Text = "separation:5",
                            Name = "value:int"
                        };
                        TreeNode salt = new TreeNode()
                        {
                            Text = "salt:0",
                            Name = "value:int"
                        };
                        List<TreeNode> Children = new List<TreeNode> { spacing,separation,salt };
                        CurrentNode.Nodes.Add(structure);
                        structure.Nodes.AddRange(Children.ToArray());
                        dimension_view.Controls.Remove(structure_box);
                        Modifying = false;
                    }
                };

                structure_box.Items.AddRange(StructureData.ToArray());
                structure_box.AutoCompleteCustomSource.AddRange(StructureData.ToArray());
                dimension_view.Controls.Add(structure_box);
                structure_box.BringToFront();
                return;
            }

            //处理地表方块
            if(CurrentNode.Name == "parent_node" && (CurrentNode.Text == "default_block" || CurrentNode.Text == "default_fluid"))
            {
                Modifying = true;
                ComboBox block_box = new ComboBox()
                {
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                block_box.KeyDown += (a, b) =>
                {
                    string CurrentText = CurrentNode.Text.Split(':')[0];
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(block_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Nodes.Clear();
                        TreeNode name_node = new TreeNode()
                        {
                            Text = "Name:" + block_box.Text.Trim(),
                            Name = "value:string"
                        };
                        TreeNode property_node = new TreeNode()
                        {
                            Text = "Properties",
                            Name = "parent_node"
                        };
                        List<TreeNode> Children = new List<TreeNode> { name_node, property_node };
                        CurrentNode.Nodes.AddRange(Children.ToArray());
                        dimension_view.Controls.Remove(block_box);
                        Modifying = false;
                    }
                };

                foreach (TreeNode item in Blocks.Nodes)
                {
                    block_box.Items.Add(item.Text);
                    block_box.AutoCompleteCustomSource.Add(item.Text);
                }

                dimension_view.Controls.Add(block_box);
                block_box.BringToFront();
                return;
            }

            //处理方块属性
            if(CurrentNode.Name == "parent_node" && CurrentNode.Text == "Properties")
            {
                bool HaveID = false;
                string block_id = "";
                foreach (TreeNode item in CurrentNode.Parent.Nodes)
                {
                    if(item.Text.Split(':')[0].Trim() == "Name" && item.Name == "value:string" && CurrentNode.Parent.Name == "parent_node")
                    {
                        HaveID = true;
                        block_id = item.Text.Substring(item.Text.IndexOf(':')+1,item.Text.Length - (item.Text.IndexOf(':')+1));
                        break;
                    }
                }

                if(HaveID)
                {
                    foreach (TreeNode item in Blocks.Nodes)
                    {
                        if(item.Text.Trim() == block_id.Trim())
                        {
                            foreach (TreeNode property in item.Nodes)
                            {
                                if(property.Text == "properties")
                                {
                                    //遍历属性
                                    foreach (TreeNode a_property in property.Nodes)
                                    {
                                        //获取属性值列表
                                        string[] properties_value = a_property.Nodes[0].Text.Replace("[","").Replace("]","").Replace("\"","").Split(',');
                                        TreeNode property_node = new TreeNode()
                                        {
                                            Text = a_property.Text,
                                            Name = "value:string"
                                        };
                                        if (int.TryParse(properties_value[0], out int int_result))
                                            property_node.Name = "value:int";
                                        if (float.TryParse(properties_value[0], out float float_result))
                                            property_node.Name = "value:float";
                                        if (double.TryParse(properties_value[0], out double double_result))
                                            property_node.Name = "value:double";
                                        if (long.TryParse(properties_value[0], out long long_result))
                                            property_node.Name = "value:long";
                                        if (bool.TryParse(properties_value[0], out bool bool_result))
                                            property_node.Name = "value:bool";

                                        //设置Tag数据
                                        for (int i = 0; i < properties_value.Length; i++)
                                        {
                                            property_node.Tag += properties_value[i].Trim()+",";
                                        }
                                        property_node.Tag = property_node.Tag.ToString().TrimEnd(',');
                                        CurrentNode.Nodes.Add(property_node);
                                    }
                                }
                            }
                        }
                    }
                }
                return;
            }

            //处理方块名称
            if((CurrentNode.Name == "value:string" && CurrentNode.Text.Split(':')[0] == "Name" && CurrentNode.Parent.Name == "parent_node") || (CurrentNode.Name.Split(':')[0] == "block" && CurrentNode.Parent.Name == "array_node"))
            {
                //保存当前方块ID
                string CurrentId = CurrentNode.Text.Substring(CurrentNode.Text.IndexOf(':'),CurrentNode.Text.Length - CurrentNode.Text.IndexOf(':'));
                //保存键
                string CurrentKey = CurrentNode.Name.Split(':')[0];

                ComboBox block_box = new ComboBox()
                {
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                block_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(block_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        if (block_box.Text.Trim() != CurrentId.Trim())
                        {
                            CurrentNode.Text = CurrentKey + ":" + block_box.Text.Trim();
                            foreach (TreeNode item in CurrentNode.Parent.Nodes)
                            {
                                if(item.Text.Split(':')[0].Contains("Properties"))
                                {
                                    item.Nodes.Clear();
                                    break;
                                }
                            }
                        }
                        dimension_view.Controls.Remove(block_box);
                        Modifying = false;
                    }
                };

                foreach (TreeNode item in Blocks.Nodes)
                {
                    block_box.Items.Add(item.Text);
                    block_box.AutoCompleteCustomSource.Add(item.Text);
                }

                dimension_view.Controls.Add(block_box);
                block_box.BringToFront();
                return;
            }

            //处理噪音振幅
            if(CurrentNode.Name == "list_node" && CurrentNode.Text == "amplitudes" && CurrentNode.Parent.Name == "parent_node")
            {
                TreeNode list_node = new TreeNode()
                {
                    Text = CurrentNode.Nodes.Count + 1 + "",
                    Name = "value:float"
                };
                CurrentNode.Nodes.Add(list_node);
            }

            //处理天空渲染参数
            if (CurrentNode.Text.Split(':')[0] == "effects" && CurrentNode.Name == "value:string")
            {
                Modifying = true;
                ComboBox effect_box = new ComboBox()
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(50, 50, 50),
                    Size = new Size(200, 25),
                    Location = mouse_pos,
                    AutoCompleteSource = AutoCompleteSource.CustomSource,
                    AutoCompleteMode = AutoCompleteMode.Suggest
                };

                effect_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        dimension_view.Controls.Remove(effect_box);
                        Modifying = false;
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = "effects:" + effect_box.Text.Trim();
                        dimension_view.Controls.Remove(effect_box);
                        Modifying = false;
                    }
                };

                string[] effects = CurrentNode.Tag.ToString().Split(',');
                effect_box.Items.AddRange(effects);
                effect_box.AutoCompleteCustomSource.AddRange(effects);
                dimension_view.Controls.Add(effect_box);
                effect_box.BringToFront();
                return;
            }

            //处理各种值
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
                                    dimension_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    dimension_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            dimension_view.Controls.Add(textBox);
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
                                    dimension_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Value;
                                    dimension_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            dimension_view.Controls.Add(value_box);
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
                                    dimension_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + textBox.Text.Trim();
                                    dimension_view.Controls.Remove(textBox);
                                    Modifying = false;
                                }
                            };

                            dimension_view.Controls.Add(textBox);
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
                                    dimension_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + value_box.Text.Trim();
                                    dimension_view.Controls.Remove(value_box);
                                    Modifying = false;
                                }
                            };

                            value_box.Items.Add("true");
                            value_box.Items.Add("false");
                            value_box.AutoCompleteCustomSource.Add("true");
                            value_box.AutoCompleteCustomSource.Add("false");
                            dimension_view.Controls.Add(value_box);
                            value_box.BringToFront();
                            break;
                        }
                }
                return;
            }
            #endregion
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "array_ele" || CurrentNode.Name == "list_ele" || CurrentNode.Name == "ele")
                dimension_view.Nodes.Remove(CurrentNode);
            if (CurrentNode.Name.Contains("value") && (CurrentNode.Parent.Name == "array_node" || CurrentNode.Parent.Name == "list_node"))
                dimension_view.Nodes.Remove(CurrentNode);
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "list_node" || CurrentNode.Name == "array_node")
                CurrentNode.Nodes.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add_menu_Click(null,null);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete_menu_Click(null,null);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clear_menu_Click(null,null);
        }

        private void dimension_view_MouseDown(object sender, MouseEventArgs e)
        {
            if(!Modifying)
            {
                CurrentNode = dimension_view.SelectedNode;
                mouse_pos = e.Location;
            }
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
                    if(subnode.Index == (subnode.Parent.Nodes.Count - 1))
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
            StartSpawn(dimension_view.Nodes[0]);
            result += "}";

            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                Description = "请选择维度生成路径",
                RootFolder = Environment.SpecialFolder.MyComputer,
                ShowNewFolderButton = true,
                SelectedPath = history_path
            };
            if(folder.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(folder.SelectedPath+"\\"+dimension_view.Nodes[0].Text+".json",result,new UTF8Encoding(false));
                Process.Start(folder.SelectedPath);
                history_path = folder.SelectedPath;
            }
        }
    }
}
