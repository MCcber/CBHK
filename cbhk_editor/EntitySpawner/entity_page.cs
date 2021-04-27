using cbhk_editor.ItemSpawner;
using cbhk_editor.MainForm;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    public partial class entity_page : UserControl
    {
        Color dark_gray = Color.FromArgb(50, 50, 50);
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        TreeView root_node = new TreeView();
        //保存实体NBT
        string HistoryNBT = "";
        //保存历史实体ID
        string HistoryId = "";
        public entity_page(TreeView Root)
        {
            InitializeComponent();

            root_node = Root;
            foreach (TreeNode item in root_node.Nodes)
            {
                #region 处理实体id补全数据源
                if (item.Text == "minecraft:entity_type")
                {
                    foreach (TreeNode entries in item.Nodes)
                    {
                        if(entries.Text.Contains("entries"))
                        {
                            foreach (TreeNode entry in entries.Nodes)
                            {
                                entity_id.Items.Add(entry.Text.Replace("minecraft:",""));
                                entity_id.AutoCompleteCustomSource.Add(entry.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
                #endregion

                #region 药水效果id补全数据源
                if(item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode entries in item.Nodes)
                    {
                        if (entries.Text.Contains("entries"))
                        {
                            foreach (TreeNode entry in entries.Nodes)
                            {
                                effect_id_box.Items.Add(entry.Text);
                                effect_id_box.AutoCompleteCustomSource.Add(entry.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion
            }

            entity_tab.SelectedTab.ForeColor = Color.White;
            entity_tab.SelectedTab.BackColor = dark_gray;

            entity_table.ForeColor = Color.White;
            entity_table.BackColor = dark_gray;

            set_check_special_nbt.Click += ClickSound;
            passenger_entity_btn.Click += ClickSound;

            foreach (Control item in hand_item_area.Controls)
            {
                if(item is TextBox)
                    item.KeyPress += Number_KeyPress;
                if (item is Button)
                {
                    item.Click += ClickSound;
                    item.Click += LoadItem;
                }
            }

            foreach (Control item in equipment_area.Controls)
            {
                if(item is TextBox)
                    item.KeyPress += Number_KeyPress;
                if (item is Button)
                {
                    item.Click += ClickSound;
                    item.Click += LoadItem;
                }
            }

            foreach (Control item in entity_table.Controls)
            {
                item.ForeColor = Color.White;
                item.BackColor = dark_gray;
            }

            effect_tab.SelectedTab.BackColor = dark_gray;

            foreach (Control item in effect_tab.SelectedTab.Controls)
            {
                item.ForeColor = Color.White;
                item.BackColor = dark_gray;
            }

            foreach (Control item in passengerTab.Controls)
            {
                item.ForeColor = Color.White;
                item.BackColor = dark_gray;
            }

            foreach (Control item in hand_item_area.Controls)
            {
                item.ForeColor = Color.White;
                item.BackColor = dark_gray;
            }

            foreach (Control item in equipment_area.Controls)
            {
                item.ForeColor = Color.White;
                item.BackColor = dark_gray;
            }
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        /// <summary>
        /// 设置标签指定的值
        /// </summary>
        /// <param name="value_type"></param>
        private void ReplaceValueType(string[] value_type)
        {
            switch (value_type[1])
            {
                case "TAG_Byte":
                    {
                        value_type[1] = "0b";
                        break;
                    }
                case "TAG_Short":
                    {
                        value_type[1] = "0s";
                        break;
                    }
                case "TAG_Long":
                case "TAG_Int":
                    {
                        value_type[1] = "1";
                        break;
                    }
                case "TAG_Float":
                    {
                        value_type[1] = "1f";
                        break;
                    }
                case "TAG_Double":
                    {
                        value_type[1] = "1d";
                        break;
                    }

                case "TAG_String":
                    {
                        value_type[1] = "\"\"";
                        break;
                    }

                case "TAG_Compound":
                    {
                        value_type[1] = "{}";
                        break;
                    }
                case "TAG_List":
                    {
                        value_type[1] = "[]";
                        break;
                    }
            }
        }

        private void RecursionGetNBT(TreeNode CurrentNode)
        {
            foreach (TreeNode nbt_obj in CurrentNode.Nodes)
            {
                string[] value_type = nbt_obj.Nodes[nbt_obj.Nodes.Count - 2].Text.Split(':');
                string[] key_info = nbt_obj.LastNode.Text.Split(':');

                if (key_info[1].Trim() == "" || value_type[1].Trim() == "TAG_None")
                    continue;

                //判断是否为集合或者数组类型节点,是则开启递归拼接NBT数据
                if (value_type[1].Trim() == "TAG_Compound" || value_type[1].Trim() == "TAG_List")
                {
                    HistoryNBT += key_info[1] + ":" + (value_type[1].Trim() == "TAG_List" ? "[" : "{");
                    if (nbt_obj.Nodes[0].Text.Trim() == "children" && nbt_obj.Nodes[0].Nodes.Count > 0)
                        RecursionGetNBT(nbt_obj.Nodes[0]);

                    //递归结束拼闭括号
                    TreeNode SameLastSecond = CurrentNode.Parent.Nodes[CurrentNode.Parent.LastNode.Index - 1];
                    HistoryNBT = SameLastSecond.Text.Split(':')[1].Trim() == "TAG_List" ?HistoryNBT.TrimEnd(',') + "]," : (SameLastSecond.Text.Split(':')[1].Trim() == "TAG_Compound" ? HistoryNBT.TrimEnd(',') + "}," : "");
                }
                else
                {
                    ReplaceValueType(value_type);
                    HistoryNBT += key_info[1].Trim() + ":" + value_type[1] + ",";
                }

            }
        }

        /// <summary>
        /// 设置或查看特殊NBT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void set_check_special_nbt_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (entity_id.FindString(entity_id.Text) != entity_id.FindString(HistoryId))
            {
                this_obj.Tag = null;
                HistoryNBT = "";
            }

            if (this_obj.Tag == null)
            {
                if (entity_id.FindString(entity_id.Text, -1) != -1)
                {
                    //引用并遍历实体NBT数据对象
                    foreach (TreeNode entites in Cbhk_form.EntityNBTs.Nodes)
                    {
                        if (entites.Text == "entities")
                        {
                            //遍历实体
                            foreach (TreeNode entity in entites.Nodes)
                            {
                                if (entity.Nodes[2].Text.Split(':')[1].Trim() == entity_id.Text.Trim())
                                {
                                    //递归收集所有NBT数据
                                    RecursionGetNBT(entity.Nodes[0].Nodes[0]);
                                    HistoryNBT = HistoryNBT.Trim(',');
                                    this_obj.Tag = HistoryNBT;
                                    HistoryId = entity_id.Text;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            EntityNBTForm entityNBTForm = new EntityNBTForm(this_obj.Tag != null ? this_obj.Tag.ToString():"");
            if (entityNBTForm.ShowDialog() == DialogResult.OK)
                this_obj.Tag = entityNBTForm.nbt_result;
        }

        private void LoadItem(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            if(this_obj.Tag == null)
            {
                Item_spawner itemspawner = new Item_spawner(null, soundPlayer, true);
                if (itemspawner.ShowDialog() == DialogResult.OK)
                {
                    this_obj.Name = itemspawner.ItemIds[0];
                    this_obj.Tag = itemspawner.ItemNBTs[0];
                }
            }
            else
            {
                EntityNBTForm entityNBTForm = new EntityNBTForm(this_obj.Tag.ToString());
                if(entityNBTForm.ShowDialog() == DialogResult.OK)
                {
                    this_obj.Tag = entityNBTForm.nbt_result;
                }
            }
        }

        private void passenger_entity_btn_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            EntityNBTForm entityNBTForm = new EntityNBTForm(this_obj.Tag!=null?this_obj.Tag.ToString():"");
            entityNBTForm.Text = "设置骑乘实体信息";
            if(entityNBTForm.ShowDialog() == DialogResult.OK)
            {
                this_obj.Tag = entityNBTForm.nbt_result;
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
                e.Handled = true;
            if (e.KeyChar == '.')   //允许输入回退键
            {
                if (this_obj.Text == "")
                {
                    this_obj.Text = "0.";
                    this_obj.Select(this_obj.Text.Length, 0);
                    e.Handled = true;
                }
                else if (this_obj.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }
    }
}
