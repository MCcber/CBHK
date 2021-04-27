using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner
{
    public partial class advancement_spawner : Form
    {

        Form parent;
        SoundPlayer click_sound;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        //保存鼠标坐标
        Point mouse_pos = new Point();
        //保存当前选中的节点
        TreeNode CurrentNode = new TreeNode();
        //是否正在操作
        bool Modifying = false;
        //保存最终结果
        string result = "{";
        //需要添加逗号
        bool NeedComma = false;
        //保存历史路径
        string history_path = "";
        public advancement_spawner(Form obj,SoundPlayer click)
        {
            InitializeComponent();
            InitUISettings();
            click_sound = click;
            parent = obj;
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            adv_view.ExpandAll();
            adv_view.SelectedNode = adv_view.Nodes[0];

            click_to_return.Click += (a,b) => 
            {
                click_sound.Play();
                if(parent != null)
                {
                    parent.ShowInTaskbar = true;
                    parent.WindowState = FormWindowState.Normal;
                    parent.TopMost = true;
                    parent.Show();
                    parent.TopMost = false;
                    Close();
                }
            };

            foreach (ToolStripMenuItem item in adv_title_menu.Items)
            {
                item.BackColor = Color.FromArgb(50,50,50);
                item.ForeColor = Color.White;
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackColor = Color.FromArgb(50, 50, 50);
                    subitem.ForeColor = Color.White;
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.Click += ClickSound;
                }
            }

            //处理直接类型触发器
            foreach (ToolStripMenuItem item in simple_triggers_menu.DropDownItems)
            {
                item.Click += (a,b) => 
                {
                    if (CurrentNode.Name == "value:list" && CurrentNode.Text.Contains("trigger"))
                        CurrentNode.Text = CurrentNode.Text.Split(':')[0] +":minecraft:"+ item.Text;
                };
            }
            foreach (ToolStripMenuItem item in simple_triggers.DropDownItems)
            {
                item.Click += (a, b) =>
                {
                    if (CurrentNode.Name == "value:list" && CurrentNode.Text.Contains("trigger"))
                        CurrentNode.Text = CurrentNode.Text.Split(':')[0] + ":minecraft:" + item.Text;
                };
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            click_sound.Play();
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
                    if (subnode.Name.Contains("string"))
                    {
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Text.Split(':')[1] + "\"";
                            NeedComma = true;
                        }
                        else
                        {
                            NeedComma = false;
                        }
                    }
                    else
                        if (subnode.Name.Contains("tag") && subnode.Tag != null)
                    {
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            if (subnode.Text.Contains(":") && subnode.Text.Split(':')[0] == "nbt")
                                result += "\"" + subnode.Text.Split(':')[0] + "\":\"{" + subnode.Tag.ToString() + "}\"";
                            else
                                result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Tag.ToString() + "\"";
                            NeedComma = true;
                        }
                        else
                        if(subnode.Tag != null)
                        {
                            result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Tag.ToString() + "\"";
                            NeedComma = true;
                        }
                        else
                        {
                            NeedComma = false;
                        }
                    }
                    else
                    if (subnode.Name.Contains("list") && subnode.Tag != null)
                    {
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            if(subnode.Text.Split(':')[0] == "trigger")
                            result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Text.Split(':')[1] + ":" + subnode.Text.Split(':')[2]+"\"," + subnode.Tag.ToString();
                            else
                                result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Text.Split(':')[1]+"\"";
                            NeedComma = true;
                        }
                        else
                        {
                            NeedComma = false;
                        }
                    }
                    else
                    if(subnode.Name.Contains("list") && subnode.Tag == null && subnode.Text.Split(':').Length > 2)
                    {
                        if (subnode.Text.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                        {
                            result += "\"" + subnode.Text.Split(':')[0] + "\":\"" + subnode.Text.Split(':')[1] + ":" + subnode.Text.Split(':')[2]+"\"";
                            NeedComma = true;
                        }
                    }
                    else
                    if (subnode.Text.Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries).Length >= 2)
                    {
                        result += "\"" + subnode.Text.Split(':')[0] + "\":" + subnode.Text.Split(':')[1];
                        NeedComma = true;
                    }
                    else
                    {
                        NeedComma = false;
                    }

                    //去除多余的尾部逗号
                        if (subnode.Index == (subnode.Parent.Nodes.Count - 1) && !NeedComma && (result.EndsWith("[") || result.EndsWith("]") || result.EndsWith("{") || result.EndsWith("}") || result.EndsWith(",")))
                            result = result.TrimEnd(',');

                    if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && NeedComma)
                        result += ",";
                }

                switch (subnode.Name)
                {
                    case "array_ele":
                        {
                            string[] ele_array = subnode.Text.Split(',');
                            result += "[";
                            foreach (string item in ele_array)
                            {
                                result += "\""+item+"\",";
                            }
                            result = result.Trim(',') + "]";
                            if (subnode.Index < (subnode.Parent.Nodes.Count - 1))
                                NeedComma = true;
                            break;
                        }

                    case "parent_node":
                    case "condition":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "\"" + subnode.Text + "\":{";
                                NeedComma = true;
                            }
                            break;
                        }

                    case "list_node":
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

                    case "parent_node":
                        {
                            if (subnode.Nodes.Count > 0)
                            {
                                result += "}";
                                NeedComma = true;
                            }
                            break;
                        }
                    case "condition":
                        {
                            result += "}";
                            NeedComma = true;
                            break;
                        }

                    case "list_node":
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

                if (subnode.Index < (subnode.Parent.Nodes.Count - 1) && NeedComma)
                {
                    if (!subnode.Name.Contains("value:") && subnode.Name != "ele")
                    {
                        result += ",";
                        NeedComma = false;
                    }
                }
            }
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            adv_view.Enabled = false;

            StartSpawn(adv_view.Nodes[0]);

            result += "}";

            FolderBrowserDialog select_folder = new FolderBrowserDialog()
            {
                 Description = "请选择进度生成路径",
                 RootFolder = Environment.SpecialFolder.MyComputer,
                 ShowNewFolderButton = true,
                 SelectedPath = history_path
            };

            if(select_folder.ShowDialog() == DialogResult.OK)
            {
                if (select_folder.SelectedPath.Length > 0 && Directory.Exists(select_folder.SelectedPath))
                {
                    File.WriteAllText(select_folder.SelectedPath + "\\" + adv_view.Nodes[0].Text + ".json", result, new UTF8Encoding(false));

                    result = "{";

                    Process.Start(select_folder.SelectedPath);
                }
            }
            adv_view.Enabled = true;
        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            if(CurrentNode.Name.Contains("value:"))
            {
                string value_type = CurrentNode.Name.Split(':')[1];
                switch (value_type)
                {
                    case "string":
                    case "tag":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            TextBox text_box = new TextBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50,25),
                                Location = mouse_pos
                            };
                            text_box.KeyDown += (a,b) => 
                            {
                                if (b.KeyCode == Keys.Escape)
                                    adv_view.Controls.Remove(text_box);
                                if(b.KeyCode == Keys.Enter)
                                {
                                    if(value_type == "string")
                                    CurrentNode.Text = CurrentText + ":" + text_box.Text.Trim();
                                    if(value_type == "tag")
                                        CurrentNode.Tag =  text_box.Text.Trim();
                                    adv_view.Controls.Remove(text_box);
                                    Modifying = false;
                                }
                            };
                            Modifying = true;
                            adv_view.Controls.Add(text_box);
                            text_box.BringToFront();
                            break;
                        }

                    case "bool":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            ComboBox text_box = new ComboBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 25),
                                Location = mouse_pos
                            };
                            text_box.KeyPress += (a,b) => { b.Handled = true; };
                            text_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                    adv_view.Controls.Remove(text_box);
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + text_box.Text.Trim();
                                    adv_view.Controls.Remove(text_box);
                                    Modifying = false;
                                }
                            };
                            Modifying = true;
                            text_box.Items.Add("true");
                            text_box.Items.Add("false");
                            adv_view.Controls.Add(text_box);
                            text_box.BringToFront();
                            break;
                        }

                    case "int":
                    case "byte":
                    case "long":
                    case "short":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            NumericUpDown text_box = new NumericUpDown()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 25),
                                Location = mouse_pos,
                                Minimum = -1,
                                Maximum = 10000000000,
                                Value = -1
                            };
                            text_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                    adv_view.Controls.Remove(text_box);
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + text_box.Value;
                                    adv_view.Controls.Remove(text_box);
                                    Modifying = false;
                                }
                            };
                            Modifying = true;
                            adv_view.Controls.Add(text_box);
                            text_box.BringToFront();
                            break;
                        }

                    case "list":
                        {
                            if(CurrentNode.Text.Split(':')[0] == "frame")
                            {
                                string CurrentText = CurrentNode.Text.Split(':')[0];
                                ComboBox text_box = new ComboBox()
                                {
                                    BackColor = Color.FromArgb(50, 50, 50),
                                    ForeColor = Color.White,
                                    Size = new Size(100, 25),
                                    Location = mouse_pos
                                };
                                text_box.KeyPress += (a, b) => { b.Handled = true; };
                                text_box.KeyDown += (a, b) =>
                                {
                                    if (b.KeyCode == Keys.Escape)
                                        adv_view.Controls.Remove(text_box);
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        CurrentNode.Text = CurrentText +":"+ text_box.Text.Trim();
                                        adv_view.Controls.Remove(text_box);
                                        Modifying = false;
                                    }
                                };
                                Modifying = true;
                                string[] value_list = CurrentNode.Tag.ToString().Split(',');
                                foreach (string item in value_list)
                                {
                                    text_box.Items.Add(item);
                                }
                                adv_view.Controls.Add(text_box);
                                text_box.BringToFront();
                            }

                            if(CurrentNode.Text.Split(':')[0] == "trigger")
                            {
                                string[] triggers = File.ReadAllLines(Application.StartupPath+ "\\AdvancementTriggers\\triggers.ini");

                                string CurrentText = CurrentNode.Text.Split(':')[0];
                                ComboBox text_box = new ComboBox()
                                {
                                    BackColor = Color.FromArgb(50, 50, 50),
                                    ForeColor = Color.White,
                                    Size = new Size(200, 25),
                                    Location = mouse_pos
                                };
                                text_box.KeyPress += (a, b) => { b.Handled = true; };
                                text_box.KeyDown += (a, b) =>
                                {
                                    if (b.KeyCode == Keys.Escape)
                                        adv_view.Controls.Remove(text_box);
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        triggers_form tf = new triggers_form(text_box.SelectedIndex);
                                        if(tf.ShowDialog() == DialogResult.OK)
                                        {
                                            if(tf.Tag != null)
                                            {
                                                CurrentNode.Tag = tf.Tag;
                                                CurrentNode.Text = CurrentText +":"+ text_box.Text.Trim();
                                                //MessageBox.Show(tf.Tag.ToString());
                                            }
                                            else
                                            CurrentNode.Tag = null;
                                        }
                                        Modifying = false;
                                        adv_view.Controls.Remove(text_box);
                                    }
                                };
                                Modifying = true;
                                foreach (string item in triggers)
                                {
                                    text_box.Items.Add(item);
                                }
                                adv_view.Controls.Add(text_box);
                                text_box.BringToFront();
                            }
                            break;
                        }

                    case "float":
                    case "double":
                        {
                            string CurrentText = CurrentNode.Text.Split(':')[0];
                            TextBox text_box = new TextBox()
                            {
                                BackColor = Color.FromArgb(50, 50, 50),
                                ForeColor = Color.White,
                                Size = new Size(50, 25),
                                Location = mouse_pos
                            };
                            text_box.KeyPress += (a,b) => 
                            {
                                if (b.KeyChar != 8 && !char.IsDigit(b.KeyChar) && b.KeyChar != 0x2E)
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
                            text_box.KeyDown += (a, b) =>
                            {
                                if (b.KeyCode == Keys.Escape)
                                    adv_view.Controls.Remove(text_box);
                                if (b.KeyCode == Keys.Enter)
                                {
                                    CurrentNode.Text = CurrentText + ":" + text_box.Text.Trim();
                                    adv_view.Controls.Remove(text_box);
                                    Modifying = false;
                                }
                            };
                            Modifying = true;
                            adv_view.Controls.Add(text_box);
                            text_box.BringToFront();
                            break;
                        }
                }
            }

            if(CurrentNode.Name == "condition")
            {
                string CurrentText = CurrentNode.Text.Split(':')[0];
                TextBox text_box = new TextBox()
                {
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.White,
                    Size = new Size(50, 25),
                    Location = mouse_pos
                };
                text_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        CurrentNode.Text = CurrentText;
                        adv_view.Controls.Remove(text_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = text_box.Text.Trim();
                        adv_view.Controls.Remove(text_box);
                        Modifying = false;
                    }
                };
                Modifying = true;
                adv_view.Controls.Add(text_box);
                text_box.BringToFront();
            }

            if(CurrentNode.Name == "rootnode")
            {
                string CurrentText = CurrentNode.Text;
                TextBox text_box = new TextBox()
                {
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.White,
                    Size = new Size(50, 25),
                    Location = mouse_pos
                };
                text_box.KeyDown += (a, b) =>
                {
                    if (b.KeyCode == Keys.Escape)
                    {
                        CurrentNode.Text = CurrentText;
                        adv_view.Controls.Remove(text_box);
                    }
                    if (b.KeyCode == Keys.Enter)
                    {
                        CurrentNode.Text = text_box.Text.Trim();
                        adv_view.Controls.Remove(text_box);
                        Modifying = false;
                    }
                };
                Modifying = true;
                adv_view.Controls.Add(text_box);
                text_box.BringToFront();
            }

            if(CurrentNode.Name == "list_node")
            {
                if(CurrentNode.Text == "requirements")
                {
                    if(CurrentNode.Parent.Nodes[2].Nodes.Count > 0)
                    {
                        ComboBox requirements_box = new ComboBox()
                        {
                            ForeColor = Color.White,
                            BackColor = Color.FromArgb(50, 50, 50),
                            Size = new Size(200, 25),
                            Location = mouse_pos,
                            AutoCompleteMode = AutoCompleteMode.Suggest,
                            AutoCompleteSource = AutoCompleteSource.CustomSource
                        };
                        foreach (TreeNode item in CurrentNode.Parent.Nodes[2].Nodes)
                        {
                            requirements_box.AutoCompleteCustomSource.Add(item.Text);
                        }
                        requirements_box.KeyDown += (a, b) => {
                            if (b.KeyCode == Keys.Escape)
                            {
                                TreeNode new_ele = new TreeNode()
                                {
                                    Name = "array_ele"
                                };
                                foreach (string item in requirements_box.Items)
                                {
                                    new_ele.Text += item + ",";
                                }
                                new_ele.Text = new_ele.Text.TrimEnd(',');
                                CurrentNode.Nodes.Add(new_ele);
                                adv_view.Controls.Remove(requirements_box);
                            }
                            if (b.KeyCode == Keys.Enter)
                            {
                                if (requirements_box.Text.Trim() != "")
                                {
                                    requirements_box.Items.Add(requirements_box.Text.Trim());
                                    requirements_box.Text = "";
                                }
                            }
                        };

                        adv_view.Controls.Add(requirements_box);
                        requirements_box.BringToFront();
                    }
                }
                else
                {
                    TextBox requirements_box = new TextBox()
                    {
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(50, 50, 50),
                        Size = new Size(200, 25),
                        Location = mouse_pos,
                        AutoCompleteMode = AutoCompleteMode.Suggest,
                        AutoCompleteSource = AutoCompleteSource.CustomSource
                    };
                    requirements_box.KeyDown += (a, b) => {
                        if (b.KeyCode == Keys.Escape)
                            adv_view.Controls.Remove(requirements_box);
                        if (b.KeyCode == Keys.Enter)
                        {
                            if (requirements_box.Text.Trim() != "")
                            {
                                TreeNode new_ele = new TreeNode()
                                {
                                    Name = "array_ele",
                                    Text = requirements_box.Text.Trim()
                                };
                                CurrentNode.Nodes.Add(new_ele);
                            }
                            adv_view.Controls.Remove(requirements_box);
                        }
                    };

                    adv_view.Controls.Add(requirements_box);
                    requirements_box.BringToFront();
                }
            }

            if(CurrentNode.Name == "parent_node" && CurrentNode.Text == "criteria")
            {
                TreeNode new_ele = new TreeNode()
                {
                    Text = CurrentNode.Nodes.Count + 1 + "",
                    Name = "condition"
                };
                TreeNode trigger = new TreeNode()
                {
                    Text = "trigger:",
                    Name = "value:list"
                };
                CurrentNode.Nodes.Add(new_ele);
                new_ele.Nodes.Add(trigger);
                adv_view.SelectedNode = new_ele;
            }
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if (CurrentNode.Name == "condition" || CurrentNode.Name == "array_ele")
                adv_view.Nodes.Remove(CurrentNode);
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            if(CurrentNode.Name == "list_node" || (CurrentNode.Name == "parent_node" && CurrentNode.Text == "criteria"))
            {
                CurrentNode.Nodes.Clear();
            }
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

        private void adv_view_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_pos = e.Location;
        }

        private void adv_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Modifying)
                CurrentNode = adv_view.SelectedNode;
        }
    }
}
