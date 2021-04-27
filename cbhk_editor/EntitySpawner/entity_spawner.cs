using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    public partial class entity_spawner : Form
    {
        Form parent;
        SoundPlayer soundPlayer;
        public static TreeView Root = new TreeView();
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        //是否作为工具提供给外部数据
        bool IsTool = false;
        //储存生成的实体ID
        public List<string> EntityId = new List<string> { };
        //储存生成的实体NBT
        public List<string> EntityNBT = new List<string> { };
        //是否导出
        private bool export = false;
        public entity_spawner(Form obj,SoundPlayer click,bool Tool = false)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            parent = obj;
            soundPlayer = click;
            Root = Cbhk_form.register;
            MaximumSize = Size;
            entity_tab.SelectedTab.BackColor = Color.FromArgb(50,50,50);
            IsTool = Tool;
            InitUISettigs();
        }

        private void InitUISettigs()
        {
            //通过反射获取物品管理器的方法组引用
            Type manager_type = Assembly.Load("cbhk_editor").GetType("cbhk_editor.EntitySpawner.EntityModifyManager");
            object manager_obj = Activator.CreateInstance(manager_type);
            var manager_invoker = typeof(EntityModifyManager);
            MethodInfo[] manager_methods = manager_type.GetMethods();

            click_to_return.Click += (a, b) =>
            {
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

            BackColor = Color.FromArgb(50, 50, 50);
            foreach (ToolStripMenuItem item in entity_title_menu.Items)
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
                    foreach (ToolStripMenuItem subsubitem in subitem.DropDownItems)
                    {
                        subsubitem.BackgroundImage = btn_img;
                        subsubitem.BackgroundImageLayout = ImageLayout.Stretch;
                        subsubitem.ForeColor = Color.FromArgb(255, 255, 255);
                        subsubitem.Click += ClickSound;
                        if(subsubitem.Name.Contains("add") || subsubitem.Name.Contains("delete") || subsubitem.Name.Contains("clear"))
                        {
                            ToolStripMenuItem parent_item = subsubitem.OwnerItem as ToolStripMenuItem;
                            ToolStripMenuItem parent_parent = parent_item.OwnerItem as ToolStripMenuItem;
                            int parent_index = parent_parent.DropDownItems.IndexOf(parent_item);
                            int current_index = parent_item.DropDownItems.IndexOf(subsubitem);
                            subsubitem.Click += (a, b) =>
                            {
                                manager_invoker.InvokeMember(manager_methods[parent_index * 3 + current_index].Name, BindingFlags.InvokeMethod, null, manager_obj, new object[] { entity_tab,Root });
                            };
                        }
                    }
                }
            }
            entity_tab.TabPages.Clear();
            manager_invoker.InvokeMember(manager_methods[0].Name, BindingFlags.InvokeMethod, null, manager_obj, new object[] { entity_tab, Root });
        }

        private void ClickSound(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.设置特殊NBT时请保证当前实体ID不为空\n2.-1为默认值");
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存最终结果
            List<string> results = new List<string> { };
            //保存导出的数据
            string export_result = "";
            foreach (TabPage entity_page in entity_tab.TabPages)
            {
                //实体ID
                ComboBox entity_id = entity_page.Controls.Find("entity_id", true)[0] as ComboBox;
                //生成模式
                ComboBox spawn_model = entity_page.Controls.Find("spawn_model", true)[0] as ComboBox;
                //布尔值类型NBT集合
                CheckedListBox base_nbt_list = entity_page.Controls.Find("base_nbt_list", true)[0] as CheckedListBox;
                //特殊NBT值
                Button set_check_special_nbt = entity_page.Controls.Find("set_check_special_nbt", true)[0] as Button;
                string special_nbt = "";
                if(set_check_special_nbt.Tag!=null && set_check_special_nbt.Tag.ToString().Trim()!="")
                {
                    special_nbt = set_check_special_nbt.Tag.ToString()+",";
                }
                //控件表
                TableLayoutPanel entity_table = entity_page.Controls.Find("entity_table", true)[0] as TableLayoutPanel;
                //实体基本NBT列表
                List<Control> EntityBaseNBT = new List<Control> { };
                foreach (Control item in entity_table.Controls)
                {
                    if (item is NumericUpDown)
                        EntityBaseNBT.Add(item);
                    if (item is TextBox)
                        EntityBaseNBT.Add(item);
                }

                //搜索药水效果集合控件引用
                TabControl effect_tab = entity_page.Controls.Find("effect_tab", true)[0] as TabControl;
                //左手物品数据
                Button LhandItem_btn = entity_page.Controls.Find("LhandItem_btn", true)[0] as Button;
                //右手物品数据
                Button RhandItem_btn = entity_page.Controls.Find("RhandItem_btn", true)[0] as Button;
                //头部物品数据
                Button HeadItemBox = entity_page.Controls.Find("HeadItemBox", true)[0] as Button;
                //胸部物品数据
                Button ChestItemBox = entity_page.Controls.Find("ChestItemBox", true)[0] as Button;
                //腿部物品数据
                Button LegItemBox = entity_page.Controls.Find("LegItemBox", true)[0] as Button;
                //脚部物品数据
                Button FeetItemBox = entity_page.Controls.Find("FeetItemBox", true)[0] as Button;
                //左手物品掉率
                TextBox Lhand_chance_box = entity_page.Controls.Find("Lhand_chance_box", true)[0] as TextBox;
                //右手物品掉率
                TextBox Rhand_chance_box = entity_page.Controls.Find("Rhand_chance_box", true)[0] as TextBox;
                //头部物品掉率
                TextBox HeadItemChance_box = entity_page.Controls.Find("HeadItemChance_box", true)[0] as TextBox;
                //胸部物品掉率
                TextBox ChestItemChance_box = entity_page.Controls.Find("ChestItemChance_box", true)[0] as TextBox;
                //腿部物品掉率
                TextBox LegItemChance_box = entity_page.Controls.Find("LegItemChance_box", true)[0] as TextBox;
                //脚部物品掉率
                TextBox FeetItemChance_box = entity_page.Controls.Find("FeetItemChance_box", true)[0] as TextBox;

                //骑乘实体集合控件引用
                TabControl passengerTab = entity_page.Controls.Find("passengerTab", true)[0] as TabControl;

                #region 合并药水效果数据
                string effect_string = "";
                foreach (TabPage item in effect_tab.TabPages)
                {
                    //效果id
                    ComboBox effect_id_box = item.Controls.Find("effect_id_box", true)[0] as ComboBox;
                    if(!effect_id_box.Text.Contains("minecraft:") && effect_id_box.Text.Trim()!="")
                    {
                        effect_id_box.Text = "minecraft:" + effect_id_box.Text;
                        effect_id_box.SelectedIndex = effect_id_box.FindString(effect_id_box.Text.Trim());
                    }
                    //效果持续时长
                    NumericUpDown duration_box = item.Controls.Find("duration_box", true)[0] as NumericUpDown;
                    //效果等级
                    NumericUpDown amplifier_box = item.Controls.Find("amplifier_box", true)[0] as NumericUpDown;

                    effect_string += effect_id_box.Text.Trim()!=""? "{Id:" + (effect_id_box.SelectedIndex + 1) + "b,Duration:" + duration_box.Value + ",Amplifier:" + amplifier_box.Value + "b,Ambient:0b,ShowParticles:0b}," :"";
                }
                effect_string = effect_string.Trim()!=""? "ActiveEffects:[" + effect_string.TrimEnd(',') + "]," : "";
                #endregion

                #region 合并骑乘实体数据
                string passenger_entity_string = "";
                foreach (TabPage item in passengerTab.TabPages)
                {
                    Button this_obj = item.Controls.Find("passenger_entity_btn", true)[0] as Button;
                    if(this_obj.Tag!=null && this_obj.Tag.ToString().Trim()!="")
                    passenger_entity_string += this_obj.Tag.ToString() + ",";
                }
                passenger_entity_string = passenger_entity_string.Trim()!=""? "Passengers:[" + passenger_entity_string.TrimEnd(',') + "]," : "";
                #endregion

                #region 合并手持装备数据
                string HandItem_string = (LhandItem_btn.Tag!=null && LhandItem_btn.Tag.ToString().Trim() != "") || (RhandItem_btn.Tag != null && RhandItem_btn.Tag.ToString().Trim() != "")? "HandItems:[" + (LhandItem_btn.Tag!=null && LhandItem_btn.Tag.ToString().Trim()!=""? LhandItem_btn .Tag.ToString()+",": "")+(RhandItem_btn.Tag != null && RhandItem_btn.Tag.ToString().Trim() != "" ? RhandItem_btn.Tag.ToString() + "," : "") +"],":"";
                string HandItemDrop = Lhand_chance_box.Text.Trim() != "" || Rhand_chance_box.Text.Trim() != ""? "HandDropChances:[" + (Lhand_chance_box.Text.Trim()!=""? Lhand_chance_box.Text:"0f") +","+(Rhand_chance_box.Text.Trim() != "" ? Rhand_chance_box.Text : "0f") + "],":"";
                HandItem_string += HandItemDrop;
                #endregion

                #region 合并装备数据
                string EquipmentItem_string = (FeetItemBox.Tag != null && FeetItemBox.Tag.ToString().Trim() != "") || (LegItemBox.Tag != null && LegItemBox.Tag.ToString().Trim() != "") || (ChestItemBox.Tag != null && ChestItemBox.Tag.ToString().Trim() != "") || (HeadItemBox.Tag != null && HeadItemBox.Tag.ToString().Trim() != "") ? "ArmorItems:[" + (FeetItemBox.Tag != null && FeetItemBox.Tag.ToString().Trim() != "" ? FeetItemBox.Tag.ToString() + "," : "") + (LegItemBox.Tag != null && LegItemBox.Tag.ToString().Trim() != "" ? LegItemBox.Tag.ToString() + "," : "") + (ChestItemBox.Tag != null && ChestItemBox.Tag.ToString().Trim() != "" ? ChestItemBox.Tag.ToString() + "," : "") + (HeadItemBox.Tag != null && HeadItemBox.Tag.ToString().Trim() != "" ? HeadItemBox.Tag.ToString() : "") + "]," : "";

                string EquipmentItemDrop = FeetItemChance_box.Text.Trim() != "" || LegItemChance_box.Text.Trim() != "" || ChestItemChance_box.Text.Trim() != "" || HeadItemChance_box.Text.Trim() != "" ? "ArmorDropChances:["+ (FeetItemChance_box.Text.Trim() != "" ? FeetItemChance_box.Text : "0f") + (LegItemChance_box.Text.Trim() != "" ? LegItemChance_box.Text : "0f") + (ChestItemChance_box.Text.Trim() != "" ? ChestItemChance_box.Text : "0f") + (HeadItemChance_box.Text.Trim() != "" ? HeadItemChance_box.Text : "0f") + "],":"";
                EquipmentItem_string += EquipmentItemDrop;
                #endregion

                #region 合并基础NBT和属性
                string tags = "";
                if(EntityBaseNBT[2].Text.Trim()!="" && EntityBaseNBT[2].Text.Contains(","))
                {
                    string[] tag_list = EntityBaseNBT[2].Text.Split(',');
                    foreach (string item in tag_list)
                    {
                        tags += "\""+item+"\",";
                    }
                    tags = tags.TrimEnd(',');
                }
                tags = tags.Trim() != "" ? "Tags:[" + tags + "]," : "";
                string CustomName = EntityBaseNBT[0].Text.Trim() != "" ? "CustomName :\"{\\\"text\\\":\\\"" + EntityBaseNBT[0].Text + "\\\"}\"," : "";
                string Team = EntityBaseNBT[1].Text.Trim() != "" ? "Team:\"" + EntityBaseNBT[1].Text + "\"," : "";
                string Health = (EntityBaseNBT[3] as NumericUpDown).Value != -1 ?"Heath:"+ (EntityBaseNBT[3] as NumericUpDown).Value+"," :"";
                string Motion = EntityBaseNBT[4].Text.Trim() != "" ?"Motion:["+EntityBaseNBT[4].Text.Trim()+"],":"";
                string Fire = (EntityBaseNBT[5] as NumericUpDown).Value != -1 ?"Fire:"+ ((EntityBaseNBT[5] as NumericUpDown).Value * 20) + "s," : "";

                string maxHealth = (EntityBaseNBT[6] as NumericUpDown).Value != -1 ?"{Base:"+ (EntityBaseNBT[6] as NumericUpDown).Value + "d,Name:\"generic.maxHealth\"}," : "";
                string knockbackResistance = (EntityBaseNBT[7] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[7] as NumericUpDown).Value + "d,Name:\"generic.knockbackResistance\"}," : "";
                string movementSpeed = (EntityBaseNBT[8] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[8] as NumericUpDown).Value + "d,Name:\"generic.movementSpeed\"}," : "";
                string followRange = (EntityBaseNBT[8] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[8] as NumericUpDown).Value + "d,Name:\"generic.followRange\"}," : "";
                string attackDamage = (EntityBaseNBT[9] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[9] as NumericUpDown).Value + "d,Name:\"generic.attackDamage\"}," : "";
                string attackSpeed = (EntityBaseNBT[10] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[10] as NumericUpDown).Value + "d,Name:\"generic.attackSpeed\"}," : "";
                string armor = (EntityBaseNBT[11] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[11] as NumericUpDown).Value + "d,Name:\"generic.armor\"}," : "";
                string armorToughness = (EntityBaseNBT[11] as NumericUpDown).Value != -1 ? "{Base:" + (EntityBaseNBT[11] as NumericUpDown).Value + "d,Name:\"generic.armorToughness\"}" : "";

                string Attributes = maxHealth + knockbackResistance + movementSpeed + followRange + attackDamage + attackSpeed + armor + armorToughness;
                Attributes = Attributes.Trim()!=""? "Attributes:[" + Attributes.Substring(0, Attributes.Length - 1) + "]," : "";
                #endregion

                #region 合并布尔值类型NBT
                string Bool_type_nbt = "";
                foreach (string item in base_nbt_list.CheckedItems)
                {
                    Bool_type_nbt += item+":true,";
                }
                #endregion

                #region 合并最终结果
                string EntityBaseNBT_string = Bool_type_nbt+ special_nbt + CustomName+Health+Team+tags+Motion+Fire+Attributes+ effect_string + EquipmentItem_string + HandItem_string + passenger_entity_string;
                EntityBaseNBT_string = EntityBaseNBT_string.TrimEnd(',');

                if(export)
                {
                    export_result += "{id:\"" + entity_id.Text.Trim() + "\"" + (EntityBaseNBT_string.Trim() != "" ? "," + EntityBaseNBT_string.Trim() : "") + "},";
                    continue;
                }

                if (IsTool)
                {
                    EntityId.Add(entity_id.Text.Trim());
                    EntityNBT.Add("{id:\"" + entity_id.Text.Trim() + "\""+(EntityBaseNBT_string.Trim() != ""?","+ EntityBaseNBT_string.Trim(): "")+"}");
                }

                if (spawn_model.SelectedIndex == 0)
                    EntityBaseNBT_string = "summon "+entity_id.Text.Trim()+" ~ ~ ~ {"+EntityBaseNBT_string+"}";
                else
                {
                    if(version1_12.Checked)
                    EntityBaseNBT_string = "give @p spawn_egg 1 0 {id:\"" + entity_id.Text.Trim() + "\"," + EntityBaseNBT_string + "}";
                    else
                        EntityBaseNBT_string = "give @p spawn_"+entity_id.Text.Trim()+"_egg{" + EntityBaseNBT_string + "} 1";
                }
                results.Add(EntityBaseNBT_string);
                #endregion
            }

            if(export)
            {
                export = false;
                Clipboard.SetText(export_result.TrimEnd(','));
                MessageBox.Show("所有实体已导出至剪切板");
                return;
            }

            #region 生成实体指令
            if (!IsTool)
            {
                command_result cmd_result = new command_result("实体指令", results);
                cmd_result.Show();
            }
            else
                DialogResult = DialogResult.OK;
            #endregion
        }

        private void version1_12_Click(object sender, EventArgs e)
        {
            version1_13.Checked = !version1_12.Checked;
        }

        private void version1_13_Click(object sender, EventArgs e)
        {
            version1_12.Checked = !version1_13.Checked;
        }

        private void export_and_copy_Click(object sender, EventArgs e)
        {
            export = true;
            click_to_spawn_Click(null,null);
        }

        private void entity_spawner_Shown(object sender, EventArgs e)
        {
            //窗口弹出时给实体id文本框焦点
            ComboBox id_box = entity_tab.SelectedTab.Controls.Find("entity_id", true)[0] as ComboBox;
            id_box.Focus();
        }
    }
}
