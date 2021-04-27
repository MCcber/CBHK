using cbhk_editor.EntitySpawner;
using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.SpawnerSpawner
{
    public partial class spawner_spawner : Form
    {
        Form parentForm;
        SoundPlayer soundPlayer = new SoundPlayer();

        //保存鼠标坐标
        Point mouse_pos = new Point();
        //保存最终结果
        private string result = "[";
        //是否需要逗号
        bool NeedComma = false;

        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");

        public spawner_spawner(Form obj,SoundPlayer click)
        {
            InitializeComponent();
            parentForm = obj;
            soundPlayer = click;
            InitUISettings();
        }

        private void InitUISettings()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");

            nbt_view.SelectedNode = nbt_view.Nodes[0];

            click_to_return.Click += (a,b) => 
            {
                if(parentForm != null)
                {
                    parentForm.ShowInTaskbar = true;
                    parentForm.WindowState = FormWindowState.Normal;
                    parentForm.TopMost = true;
                    parentForm.Show();
                    parentForm.TopMost = false;
                    Close();
                }
            };

            SetSpawnData.Click += (a,b) => 
            {
                Button this_obj = a as Button;
                this_obj.Tag = SetEntityInfo();
            };

            foreach (ToolStripMenuItem item in spawner_title_menu.Items)
            {
                item.ForeColor = Color.White;
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.ForeColor = Color.White;
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.Click += ClickSound;
                }
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        private void add_menu_Click(object sender, EventArgs e)
        {
            if(nbt_view.SelectedNode.Name == "a_entity")
            {
                nbt_view.SelectedNode.Tag =  SetEntityInfo();
            }

            if(nbt_view.SelectedNode.Name == "arraynode")
            {
                TreeNode a_ele = new TreeNode()
                {
                    Text = nbt_view.SelectedNode.Nodes.Count+1+"",
                    Name = "ele"
                };
                TreeNode weight_node = new TreeNode()
                {
                    Text = "Weight:1",
                    Name = "value:int"
                };
                TreeNode entity_node = new TreeNode()
                {
                    Text = "Entity",
                    Name = "a_entity"
                };

                nbt_view.SelectedNode.Nodes.Add(a_ele);
                a_ele.Nodes.Add(weight_node);
                a_ele.Nodes.Add(entity_node);
            }

            if(nbt_view.SelectedNode.Name.Contains("value:"))
            {
                string value_type = nbt_view.SelectedNode.Name.Split(':')[1];
                switch (value_type)
                {
                    case "int":
                        {
                            NumericUpDown setBox = new NumericUpDown()
                            {
                                Minimum = 1,
                                Maximum = 2147483647,
                                Value = 1,
                                Size = new Size(50, 25),
                                Location = mouse_pos,
                                BackColor = Color.FromArgb(50,50,50),
                                ForeColor = Color.White
                            };
                            string current_text = nbt_view.SelectedNode.Text.Split(':')[0];
                            setBox.KeyDown += (a,b) => 
                            {
                                if (b.KeyCode == Keys.Escape)
                                    nbt_view.Controls.Remove(setBox);
                                if(b.KeyCode == Keys.Enter)
                                {
                                    nbt_view.SelectedNode.Text = current_text + ":" + setBox.Value;
                                    nbt_view.Controls.Remove(setBox);
                                }
                            };
                            nbt_view.Controls.Add(setBox);
                            setBox.BringToFront();
                            break;
                        }
                }
            }
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if (nbt_view.SelectedNode.Name == "ele")
                nbt_view.Nodes.Remove(nbt_view.SelectedNode);
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            if (nbt_view.SelectedNode.Name == "arraynode")
                nbt_view.SelectedNode.Nodes.Clear();
        }

        private void add_rclick_Click(object sender, EventArgs e)
        {
            add_menu_Click(null,null);
        }

        private void delete_rclick_Click(object sender, EventArgs e)
        {
            delete_menu_Click(null,null);
        }

        private void clear_rclick_Click(object sender, EventArgs e)
        {
            clear_menu_Click(null,null);
        }

        private void nbt_view_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_pos = e.Location;
        }

        private string SetEntityInfo()
        {
            entity_spawner es = new entity_spawner(null, soundPlayer, true);
            if (es.ShowDialog() == DialogResult.OK)
            {
                if (es.EntityNBT[0].Trim() != "")
                {
                    return es.EntityNBT[0].Trim();
                }
            }
            return null;
        }

        private void StartSpawn(TreeNode CurrentNode)
        {
            foreach (TreeNode item in CurrentNode.Nodes)
            {
                if(item.Name == "ele")
                {
                    result += "{";
                    NeedComma = true;
                }
                if(item.Name.Contains("value:"))
                {
                    string value_type = item.Name.Split(':')[1];
                    switch (value_type)
                    {
                        case "int":
                            {
                                result += item.Text.Trim();
                                if (item.Index < (item.Parent.Nodes.Count - 1))
                                    result += ",";
                                break;
                            }
                    }
                }
                if (item.Name == "a_entity" && item.Tag != null)
                    result += item.Text + ":" + item.Tag.ToString();
                else
                if (item.Name == "a_entity" && item.Tag == null)
                {
                    result = result.TrimEnd(',');
                    NeedComma = false;
                }

                if (item.Nodes.Count > 0)
                    StartSpawn(item);

                switch (item.Name)
                {
                    case "ele":
                        {
                            result += "}";
                            if (item.Index < (item.Parent.Nodes.Count - 1))
                                NeedComma = true;
                            break;
                        }
                }

                if(item.Index < (item.Parent.Nodes.Count - 1) && NeedComma)
                {
                    if(!item.Name.Contains("value:"))
                    result += ",";
                    NeedComma = false;
                }
            }
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            StartSpawn(nbt_view.Nodes[0]);
            if (result.Trim() != "[")
            {
                result = nbt_view.Nodes[0].Text + ":" + result + "],";
            }
            else
                result = "";

            #region 合并生成数据
            string spawn_data = "";
            if (SetSpawnData.Tag != null)
            {
                spawn_data = "SpawnData:" + SetSpawnData.Tag.ToString() + ",";
            }
            #endregion

            #region 合并生成数量数据
            string spawn_count = "";
            spawn_count = "SpawnCount:"+SpawnCountBox.Value+"s,";
            #endregion

            #region 合并生成半径数据
            string spawn_range = "";
            spawn_range = "SpawnRange:" + SpawnRangeBox.Value+"s,";
            #endregion

            #region 合并延迟数据
            string delayInfo = "";
            delayInfo = "Delay:"+DelayBox.Value + "s,";
            #endregion

            #region 合并最小生成延迟数据
            string minspawndelay = "";
            minspawndelay = "MinSpawnDelay:" + MinSpawnDelayBox.Value + "s,";
            #endregion

            #region 合并最大生成延迟数据
            string maxspawndelay = "";
            maxspawndelay = "MaxSpawnDelay:" + MaxSpawnDelayBox.Value + "s,";
            #endregion

            #region 合并所需玩家距离数据
            string playerrange = "";
            playerrange = "RequiredPlayerRange:" + RequiredPlayerRangeBox.Value + "s,";
            #endregion

            #region 合并附近最大实体数量
            string maxentitycount = "";
            maxentitycount = "MaxNearbyEntities:" + MaxNearbyEntitiesBox.Value + "s,";
            #endregion

            #region 合并最终结果
            string nbt_data = spawn_data + spawn_count + spawn_range + delayInfo + minspawndelay + maxspawndelay + playerrange + maxentitycount;
            if (nbt_data.Trim() != "")
                nbt_data = nbt_data.Trim(',');
            result = "/setblock ~ ~1 ~ spawner{"+result + nbt_data+"}";
            #endregion

            #region 生成指令
            List<string> spawnerList = new List<string> { result };
            command_result cr = new command_result("刷怪笼指令",spawnerList);
            cr.Show();
            result = "[";
            #endregion

        }
    }
}
