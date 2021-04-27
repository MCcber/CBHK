using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    public partial class Item_spawner : Form
    {
        Form parent;
        SoundPlayer soundPlayer;
        TreeView root_node;
        Image btn_img = Image.FromFile(Application.StartupPath+ "\\ButtonsBgImages\\button.png");
        //是否作为工具生成数据
        bool IsTool = false;
        //保存外部物品id
        public List<string> ItemIds = new List<string> { };
        //保存外部物品NBT
        public List<string> ItemNBTs = new List<string> { };
        //需要导出物品
        bool Export = false;
        public Item_spawner(Form obj,SoundPlayer click,bool Tool = false)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            click_to_return.Click += (a,b) =>
            {
                soundPlayer.Play();
                if (parent != null)
                {
                    parent.WindowState = FormWindowState.Normal;
                    parent.ShowInTaskbar = true;
                    parent.TopMost = true;
                    parent.Show();
                    parent.TopMost = false;
                    Close();
                }
            };
            IsTool = Tool;
            parent = obj;
            soundPlayer = click;
            root_node = Cbhk_form.register;
            InitUISettings();
        }
        private void InitUISettings()
        {
            BackColor = Color.FromArgb(50,50,50);
            //通过反射获取物品管理器的方法组引用
            Type manager_type = Assembly.Load("cbhk_editor").GetType("cbhk_editor.ItemSpawner.ItemModifyManager");
            object manager_obj = Activator.CreateInstance(manager_type);
            var manager_invoker = typeof(ItemModifyManager);
            MethodInfo[] manager_methods = manager_type.GetMethods();

            foreach (ToolStripMenuItem modify in item__spawner_title_menu.Items)
            {
                modify.ForeColor = Color.FromArgb(255,255,255);
                modify.BackColor = Color.FromArgb(0,0,0);
                modify.BackgroundImage = btn_img;
                modify.BackgroundImageLayout = ImageLayout.Stretch;
                modify.Click += ClickSound;
                modify.DropDownOpened += ItemDropOpened;
                modify.DropDownClosed += ItemDropClosed;
                foreach (ToolStripMenuItem modify_item in modify.DropDownItems)
                {
                    modify_item.ForeColor = Color.FromArgb(255, 255, 255);
                    modify_item.BackColor = Color.FromArgb(0, 0, 0);
                    modify_item.BackgroundImage = btn_img;
                    modify_item.BackgroundImageLayout = ImageLayout.Stretch;
                    modify_item.Click += ClickSound;
                    foreach (ToolStripMenuItem item in modify_item.DropDownItems)
                    {
                        item.ForeColor = Color.FromArgb(255, 255, 255);
                        item.BackColor = Color.FromArgb(0, 0, 0);
                        item.BackgroundImage = btn_img;
                        item.BackgroundImageLayout = ImageLayout.Stretch;
                        item.Click += ClickSound;
                        if(item.Name.Contains("add")||item.Name.Contains("delete")||item.Name.Contains("clear"))
                        {
                            ToolStripMenuItem parent_item = item.OwnerItem as ToolStripMenuItem;
                            ToolStripMenuItem parent_parent = parent_item.OwnerItem as ToolStripMenuItem;
                            int parent_index = parent_parent.DropDownItems.IndexOf(parent_item);
                            int current_index = parent_item.DropDownItems.IndexOf(item);
                            item.Click += (a,b) =>
                            {
                                manager_invoker.InvokeMember(manager_methods[parent_index * 3 + current_index].Name,BindingFlags.InvokeMethod,null,manager_obj,new object[] { item_tab });
                            }; 
                        }
                    }
                }
            }
            item_tab.TabPages.Clear();
            manager_invoker.InvokeMember(manager_methods[0].Name, BindingFlags.InvokeMethod, null, manager_obj, new object[] { item_tab });
            MaximumSize = Size;
        }

        private void ItemDropOpened(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void ItemDropClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem this_obj = sender as ToolStripMenuItem;
            this_obj.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ClickSound(object sender,EventArgs e)
        {
            soundPlayer.Play();
        }

        private void Version1_12_Click(object sender, EventArgs e)
        {
            version1_13.Checked = !version1_12.Checked;
        }

        private void Version1_13_Click(object sender, EventArgs e)
        {
            version1_12.Checked = !version1_13.Checked;
        }

        private void click_to_spawn_Click(object sender, EventArgs e)
        {
            //保存最终结果
            List<string> results = new List<string> { };
            //保存导出结果
            string export_result = "";
            foreach (TabPage a_item in item_tab.TabPages)
            {
                //查找物品id引用
                ComboBox item_id = a_item.Controls.Find("item_id", true)[0] as ComboBox;
                if (IsTool)
                    ItemIds.Add(item_id.Text);
                //查找物品数量引用
                NumericUpDown item_count = a_item.Controls.Find("item_count", true)[0] as NumericUpDown;
                //查找物品数据值引用
                NumericUpDown item_data = a_item.Controls.Find("item_data", true)[0] as NumericUpDown;
                //查找物品显示名称引用
                TextBox display_name = a_item.Controls.Find("item_name", true)[0] as TextBox;
                //查找物品简介引用
                TextBox item_lore = a_item.Controls.Find("item_lore", true)[0] as TextBox;
                //查找物品是否无法破坏
                CheckBox unbreakable = a_item.Controls.Find("unbreakable", true)[0] as CheckBox;
                //查找物品自定义标签引用
                TextBox custom_tag = a_item.Controls.Find("item_custom_tag", true)[0] as TextBox;
                //查找物品信息显示方式引用
                ComboBox display_style = a_item.Controls.Find("item_display_style", true)[0] as ComboBox;
                //查找物品uid信息引用
                TextBox item_uid = a_item.Controls.Find("item_uid", true)[0] as TextBox;
                //查找物品可放置信息引用
                ComboBox can_place = a_item.Controls.Find("can_place", true)[0] as ComboBox;
                //查找物品可破坏信息引用
                ComboBox can_destory = a_item.Controls.Find("can_destory", true)[0] as ComboBox;
                //查找附魔控件引用
                TabControl enchantment_tab = a_item.Controls.Find("item_enchantment_tab", true)[0] as TabControl;
                //查找属性控件引用
                TabControl item_attribute_tab = a_item.Controls.Find("item_attribute_tab", true)[0] as TabControl;
                //查找药水效果控件引用
                TabControl item_potion_tab = a_item.Controls.Find("item_potion_tab", true)[0] as TabControl;

                //保存物品数据
                string result = "give @p "+item_id.Text;
                //保存物品nbt
                string item_nbt_info = "";

                #region 分割lore数据
                string lore_result = "";
                if (item_lore.Text.Contains(","))
                {
                    string[] lore_array = item_lore.Text.Split(',');
                    for (int i = 0; i < lore_array.Length; i++)
                    {
                        lore_result += "\"[\\\""+lore_array[i]+"\\\"]\",";
                    }
                }
                else
                    if(item_lore.Text.Trim() != "")
                    lore_result = "\"[\\\""+item_lore.Text+"\\\"]\"";
                lore_result = lore_result.TrimEnd(',');
                #endregion

                #region 合并display的数据
                string display_nbt = "display:{"+(display_name.Text.Trim()!=""? "Name :\"{\\\"text\\\":\\\"" + display_name.Text + "\\\"}\"":"")+(lore_result.Trim()!=""? (display_name.Text.Trim() != ""?",":"")+(lore_result.Trim() != ""? "Lore:[" + lore_result + "]" : "") :"")+"},";
                if (Regex.Match(display_nbt.Replace("display", ""),@"[A-z]+").ToString() == "")
                    display_nbt = "";
                #endregion

                #region 判断隐藏信息
                string HideInfo = "HideFlags:";
                if (display_style.SelectedIndex > 0 && display_style.SelectedIndex <= 4)
                    HideInfo += display_style.SelectedIndex + "b,";
                else
                if (display_style.SelectedIndex > 4)
                {
                    if (display_style.SelectedIndex != (display_style.Items.Count - 1))
                    {
                        int scale = display_style.SelectedIndex - 4;
                        HideInfo += 4 * Math.Pow(2, scale) + "b,";
                    }
                    else
                        HideInfo += "63b,";
                }
                else
                    HideInfo = "";
                #endregion

                #region 判断uid信息
                string uid_string = item_uid.Text.Trim() != "" ? item_uid.Text.Trim() != "" ? "UUID:" + item_uid.Text + "," : "" : "";
                #endregion

                #region 合并可放置数据和可破坏数据
                string placeon_destory = "";
                string CanPlaceOn = "CanPlaceOn:[";
                string CanDestory = "CanDestroy:[";
                if (can_place.Items.Count > 0)
                    foreach (string item in can_place.Items)
                    {
                        CanPlaceOn += "\"minecraft:" + item + "\",";
                    }
                else
                    CanPlaceOn = "";
                CanPlaceOn = CanPlaceOn.Trim()!=""? CanPlaceOn.TrimEnd(',') + "]," :"";
                if (can_destory.Items.Count > 0)
                    foreach (string item in can_destory.Items)
                    {
                        CanDestory += "\"minecraft:" + item + "\",";
                    }
                else
                    CanDestory = "";
                CanDestory = CanDestory.Trim()!=""? CanDestory.TrimEnd(',') + "]," :"";
                placeon_destory = CanPlaceOn + CanDestory;
                if (!Regex.Match(placeon_destory, @"[A-z]+").Success)
                    placeon_destory = "";
                #endregion

                #region 合并附魔数据
                string enchantment_info = "";
                List<string> enchant_ele = new List<string> { };
                foreach (TabPage enchant in enchantment_tab.TabPages)
                {
                    ComboBox enchant_id = enchant.Controls.Find("enchantment_id", true)[0] as ComboBox;
                    NumericUpDown enchant_level = enchant.Controls.Find("enchantment_level", true)[0] as NumericUpDown;
                    if (version1_12.Checked && enchant_id.Text.Trim()!="")
                        enchant_ele.Add("{id:"+Regex.Match(enchant_id.Text,@"\d+").ToString() +",lvl:"+enchant_level.Value+"s},");
                    else
                        if(version1_13.Checked && enchant_id.Text.Trim() != "")
                        enchant_ele.Add("{id:\"" + enchant_id.Text + "\",lvl:" + enchant_level.Value + "s},");
                }
                foreach (string item in enchant_ele)
                {
                    enchantment_info += item;
                }
                if (version1_12.Checked && enchantment_info.Trim()!="")
                    enchantment_info = "ench:[" + enchantment_info.TrimEnd(',') + "],";
                else
                    if (version1_13.Checked && enchantment_info.Trim() != "")
                    enchantment_info = "Enchantments:["+enchantment_info.TrimEnd(',')+"],";
                #endregion

                #region 合并属性数据
                string attribute_info = "";
                List<string> attribute_ele = new List<string> { };
                Random random_uid = new Random();
                foreach (TabPage attri in item_attribute_tab.TabPages)
                {
                    ComboBox attri_id = attri.Controls.Find("attribute_id", true)[0] as ComboBox;
                    TextBox attri_name = attri.Controls.Find("attribute_name", true)[0] as TextBox;
                    TextBox attribute_value = attri.Controls.Find("attribute_value", true)[0] as TextBox;
                    ComboBox attribute_operation = attri.Controls.Find("attribute_operation", true)[0] as ComboBox;
                    ComboBox attribute_slot = attri.Controls.Find("attribute_slot", true)[0] as ComboBox;
                    if(attri_id.Text.Trim()!="")
                    attribute_ele.Add("{AttributeName:\"generic." + attri_id.Text+"\",Name:\""+attri_name.Text+ "\",Amount:"+attribute_value.Text+ "d,Operation:"+ attribute_operation.SelectedIndex + ",UUIDMost:"+UuidHelper.NewUuidString()+"L,UUIDLeast:"+UuidHelper.NewUuidString()+"L,UUID:[I;"+ random_uid.Next(1,99)+ random_uid.Next(1, 99) + ","+ random_uid.Next(1, 99)+ random_uid.Next(1, 99) + ","+ random_uid.Next(1, 99)+ random_uid.Next(1, 99) + ","+ random_uid.Next(1, 99)+ random_uid.Next(1, 99) + "]"+(attribute_slot.Text.Trim() != ""? ",Slot:" + Regex.Match(attribute_slot.Text, @"[A-z]+") : "") +"},");
                }
                foreach (string item in attribute_ele)
                {
                    attribute_info += item;
                }
                attribute_info = attribute_info.Trim()!=""? "AttributeModifiers:[" + attribute_info.TrimEnd(',') + "]," :"";
                #endregion

                #region 合并药水数据
                string potion_info = "";
                List<string> potion_ele = new List<string> { };
                foreach (TabPage a_potion in item_potion_tab.TabPages)
                {
                    ComboBox potion_id = a_potion.Controls.Find("potion_id", true)[0] as ComboBox;
                    NumericUpDown potion_second = a_potion.Controls.Find("potioin_second", true)[0] as NumericUpDown;
                    NumericUpDown potion_amplifier = a_potion.Controls.Find("potion_amplifier", true)[0] as NumericUpDown;
                    if(potion_id.Text.Trim()!="")
                    potion_ele.Add("{Id:"+(potion_id.SelectedIndex+1)+"b,Duration:"+ (potion_second.Value*20)+ ",Amplifier:"+potion_amplifier.Value+"b,ShowParticles:0b},");
                }
                foreach (string item in potion_ele)
                {
                    potion_info += item;
                }
                potion_info = potion_info.Trim()!=""? "CustomPotionEffects:[" + potion_info.TrimEnd(',') + "]" :"";
                #endregion

                item_nbt_info = (unbreakable.Checked?"Unbreakable:1b,":"") + display_nbt+ HideInfo+ uid_string+ placeon_destory+ enchantment_info+ attribute_info+ potion_info;

                if (Export)
                    export_result += "{id:\"" + item_id.Text.Trim() + "\",Count:" + item_count.Value + "b" + (custom_tag.Text.Trim() != "" ? Regex.Match(custom_tag.Text.Trim(), @"(*.)").ToString() : "") + (item_nbt_info.Trim() != "" ? ",tag:{" + (item_data.Value != 0 ? "Damage:" + item_data.Value + "," : "") + item_nbt_info.TrimEnd(',') + "}" : "") + "},";

                if (IsTool)
                {
                    ItemIds.Add(item_id.Text.Trim());
                    if (ItemNBTs.Count > 0)
                        ItemNBTs.Clear();
                    ItemNBTs.Add("{id:\"" + item_id.Text.Trim() + "\",Count:"+item_count.Value+"b"+(custom_tag.Text.Trim()!=""?Regex.Match(custom_tag.Text.Trim(),@"(*.)").ToString():"") + (item_nbt_info.Trim() != "" ? ",tag:{" + (item_data.Value != 0 ? "Damage:" + item_data.Value + "," : "") + item_nbt_info.TrimEnd(',') + "}" : "") + "}");
                }
                else
                {
                    if (version1_12.Checked)
                        results.Add(result + " " + item_count.Value + item_data.Value + (item_nbt_info.Trim() != "" ? " {" + (custom_tag.Text.Trim() != "" ? Regex.Match(custom_tag.Text.Trim(), @"(.*)").ToString() : "") + item_nbt_info + "}" : ""));
                    if (version1_13.Checked)
                        results.Add(result + "{" + (custom_tag.Text.Trim() != "" ? Regex.Match(custom_tag.Text.Trim(), @"(.*)").ToString() : "") + (item_nbt_info.Trim() != "" ? item_nbt_info.TrimEnd(',') + (item_data.Value != 0 ? ",Damage:" + item_data.Value : "") : "") + "} " + item_count.Value);
                    results[results.Count - 1] = results[results.Count - 1].Replace("{}", "");
                }
            }

            if (Export)
            {
                export_result = export_result.TrimEnd(',');
                Clipboard.SetText(export_result);
                MessageBox.Show("所有物品已导出至剪切板");
                return;
            }

            #region 生成指令
            if (!IsTool)
            {
                command_result cmd_result = new command_result("物品指令", results);
                cmd_result.Show();
            }
            else
                DialogResult = DialogResult.OK;
            #endregion
        }

        private void export_and_copy_Click(object sender, EventArgs e)
        {
            Export = true;
            click_to_spawn_Click(null,null);
        }
    }
}
