using cbhk_editor.LootTableSpawner.condition_components.SubComponents.EntityProperty;
using cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate;
using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    public partial class entity_property_form : Form
    {
        MethodInfo[] component_manager = typeof(EntityComponentsManager).GetMethods();
        Type target_class = Assembly.Load("cbhk_editor").GetType("cbhk_editor.LootTableSpawner.condition_components.SubComponents.EntityComponentsManager");
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        //存储最终结果
        public string result = "";
        //存储装备信息
        List<string> equipInfo = new List<string> { "","","","","","" };
        public entity_property_form()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            InitUISettings();
        }

        private void InitUISettings()
        {
            MaximumSize = Size;
            //创建反射所需对象
            object target_class_instance = Activator.CreateInstance(target_class);
            var target_type = typeof(EntityComponentsManager);
            min_box.KeyPress += Number_KeyPress;
            max_box.KeyPress += Number_KeyPress;

            set_absolute.Click += SetDistance;
            set_horizontal.Click += SetDistance;
            set_x.Click += SetDistance;
            set_y.Click += SetDistance;
            set_z.Click += SetDistance;

            set_cat_type.Click += SetButtonTag;
            set_cat_type.Click += ClickSound;
            set_nbt.Click += SetButtonTag;
            set_nbt.Click += ClickSound;

            gamemode_box.KeyDown += CanNotInput;

            effect_page efp = new effect_page();
            effect_tab.TabPages.Add(efp.effect_tab.SelectedTab);

            adv_page advP = new adv_page();
            adv_tab.TabPages.Add(advP.adv_tab.SelectedTab);

            stats_page statsP = new stats_page();
            stats_tab.TabPages.Add(statsP.stats_tab.SelectedTab);

            foreach (ToolStripMenuItem item in entity_property_title_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.White;
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.ForeColor = Color.White;
                    foreach (ToolStripMenuItem subsubitem in subitem.DropDownItems)
                    {
                        subsubitem.BackgroundImage = btn_img;
                        subsubitem.BackgroundImageLayout = ImageLayout.Stretch;
                        subsubitem.ForeColor = Color.White;
                        ToolStripMenuItem parentItem = subsubitem.OwnerItem as ToolStripMenuItem;
                        ToolStripMenuItem parentparentItem = parentItem.OwnerItem as ToolStripMenuItem;
                        int parentIndex = parentparentItem.DropDownItems.IndexOf(parentItem);
                        int currentIndex = parentItem.DropDownItems.IndexOf(subsubitem);

                        subsubitem.Click += (a, b) =>
                        {
                            target_type.InvokeMember(component_manager[parentIndex * 3 + currentIndex].Name, BindingFlags.InvokeMethod, null, target_class_instance, new object[] { table });
                        };
                    }
                }
            }

            TreeView Root = Cbhk_form.register;
            entity_type.AutoCompleteMode = AutoCompleteMode.Suggest;
            entity_type.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:entity_type")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if(subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                entity_type.Items.Add(subsubitem.Text);
                                entity_type.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void ClickSound(object sender, EventArgs e)
        {
            soundPlayer.Play();
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

        private void SetDistance(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (min_box.Text.Trim() != "" && max_box.Text.Trim() != "")
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":{\"min\":" + min_box.Text.Trim() + ",\"max\":" + max_box.Text.Trim() + "},";
            else
                if (min_box.Text.Trim() != "")
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":" + min_box.Text.Trim() + ",";
            else
                if (max_box.Text.Trim() != "")
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":" + max_box.Text.Trim() + ",";
            else
                this_obj.Tag = null;
        }

        private void SetButtonTag(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            TextBox text_box = new TextBox()
            {
                Size = this_obj.Size,
                Location = this_obj.Location,
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White
            };
            text_box.KeyDown += (a, b) =>
            {
                if (b.KeyCode == Keys.Escape)
                    Controls.Remove(text_box);
                if (b.KeyCode == Keys.Enter)
                {
                    this_obj.Tag = text_box.Text.Trim();
                    Controls.Remove(text_box);
                }
            };
            Controls.Add(text_box);
            text_box.BringToFront();
        }

        private void set_level_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (level_min_box.Value != -1 && level_max_box.Value != -1)
                this_obj.Tag = "\"level\":{\"min\":" + level_min_box.Value + ",\"max\":" + level_max_box.Value + "},";
            else
                if (level_min_box.Value != -1)
                this_obj.Tag = "\"level\":" + level_min_box.Value + ",";
            else
                if (level_max_box.Value != -1)
                this_obj.Tag = "\"level\":" + level_max_box.Value + ",";
            else
                this_obj.Tag = null;
        }

        private void team_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text.Trim() != "")
                this_obj.Tag = "\"team\":" + this_obj.Text + ",";
            else
                this_obj.Tag = null;
        }

        private void entity_type_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text.Trim() != "")
                this_obj.Tag = "\"type\":" + this_obj.Text + ",";
            else
                this_obj.Tag = null;
        }

        private void CanNotInput(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void entity_property_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing && entity_type.Text.Trim() != "")
            {
                #region 合并距离数据
                string distanceInfo = "\"distance\":{";
                foreach (Control item in distance_area.Controls)
                {
                    if(item is Button && item.Tag != null)
                    {
                        distanceInfo += item.Tag.ToString();
                    }
                }
                if (distanceInfo != "\"distance\":{")
                    distanceInfo = distanceInfo.TrimEnd(',') + "},";
                else
                    distanceInfo = "";
                #endregion

                #region 合并状态效果数据
                string effectInfo = "\"effects\":[";
                foreach (TabPage page in effect_tab.TabPages)
                {
                    if(page.Tag != null)
                    effectInfo += page.Tag.ToString();
                }
                if (effectInfo != "\"effects\":[")
                    effectInfo = effectInfo.TrimEnd(',') + "],";
                else
                    effectInfo = "";
                #endregion

                #region 合并鱼钩状态数据
                string fishingHookStateInfo = "\"fishing_hook\":{";
                foreach (string item in fishing_hook_box.CheckedItems)
                {
                    fishingHookStateInfo += item;
                }
                if (fishingHookStateInfo != "\"fishing_hook\":{")
                    fishingHookStateInfo = fishingHookStateInfo.TrimEnd(',') + "},";
                else
                    fishingHookStateInfo = "";
                #endregion

                #region 合并实体状态
                string entityStateInfo = "\"flags\":{";
                foreach (string item in entity_flags_box.CheckedItems)
                {
                    entityStateInfo += item;
                }
                if (entityStateInfo != "\"flags\":{")
                    entityStateInfo = entityStateInfo.TrimEnd(',') + "},";
                else
                    entityStateInfo = "";
                #endregion

                #region 合并猫种类数据
                string catTypeInfo = "\"catType\":{";
                if (set_cat_type.Tag != null)
                    catTypeInfo = set_cat_type.Tag.ToString() + "},";
                else
                    catTypeInfo = "";
                #endregion

                #region 合并装备数据
                string equipmentInfo = "\"equipment\":{";
                foreach (string item in equipInfo)
                {
                    equipmentInfo += item;
                }
                if (equipmentInfo.Trim() == "\"equipment\":{")
                    equipmentInfo = "";
                else
                    equipmentInfo = equipmentInfo.TrimEnd(',') + "},";
                #endregion

                #region 合并位置谓词数据
                string locationInfo = "\"location\":{";
                if (set_location.Tag != null)
                    locationInfo += set_location.Tag.ToString() + "},";
                else
                    locationInfo = "";
                #endregion

                #region 合并NBT数据
                string nbtInfo = "\"nbt\":{";
                if (set_nbt.Tag != null)
                    nbtInfo += set_nbt.Tag.ToString() + "},";
                else
                    nbtInfo = "";
                #endregion

                #region 合并玩家数据
                string playerInfo = "\"player\":{";
                foreach (TabPage item in adv_tab.TabPages)
                {
                    if(item.Tag != null)
                    playerInfo += item.Tag.ToString();
                }

                #region 游戏模式
                string gamemodeInfo = "\"gamemode\":{";
                if (gamemode_box.Text != "")
                    gamemodeInfo += gamemode_box.Text.Trim() + "},";
                else
                    gamemodeInfo = "";
                #endregion

                #region 已解锁的配方
                string recipeInfo = "\"recipes\":{";
                foreach (string item in recipe_box.Items)
                {
                    recipeInfo += "\""+item + "\":true,";
                }
                if (recipeInfo != "\"recipes\":{")
                    recipeInfo = recipeInfo.TrimEnd(',') + "},";
                else
                    recipeInfo = "";
                #endregion

                #region 经验等级范围
                string levelInfo = "";
                if (set_level.Tag != null)
                    levelInfo = set_level.Tag.ToString();
                #endregion

                if (playerInfo != "\"player\":{")
                {
                    playerInfo += gamemodeInfo + recipeInfo + levelInfo;
                    playerInfo = playerInfo.TrimEnd(',') + "},";
                }
                else
                    playerInfo = "";
                #endregion

                #region 合并队伍数据
                string teamInfo = "";
                if (team_box.Tag != null)
                    teamInfo = team_box.Tag.ToString();
                #endregion

                #region 合并实体种类数据
                string entityTypeInfo = "";
                if (entity_type.Tag != null)
                    entityTypeInfo = entity_type.Tag.ToString();
                #endregion

                #region 合并最终结果
                result = distanceInfo + effectInfo + fishingHookStateInfo + entityStateInfo + catTypeInfo + equipmentInfo + locationInfo + nbtInfo + playerInfo + teamInfo + entityTypeInfo;
                result = result.TrimEnd(',');
                DialogResult = DialogResult.OK;
                #endregion
            }
        }

        private void entity_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if(!this_obj.Text.Contains("minecraft:"))
            {
                this_obj.Text = "minecraft:" + this_obj.Text.Trim();
            }
            this_obj.Tag = "\"entity\":\""+this_obj.Text+"\",";
        }

        private void set_item_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Button this_obj = sender as Button;
            equipment_slot es = new equipment_slot();
            if (es.ShowDialog() == DialogResult.OK)
            {
                //保存要存储的槽位
                List<string> slotInfo = new List<string> { };
                foreach (string item in es.slot_box.CheckedItems)
                {
                    slotInfo.Add(item);
                }
                item_form isp = new item_form();
                if(isp.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < slotInfo.Count; i++)
                    {
                        equipInfo[i] = "\"" + slotInfo[i] + "\"" + isp.result;
                    }
                }

                equipInfo[equipInfo.Count - 1] = equipInfo[equipInfo.Count - 1].TrimEnd(',');
            }
        }

        private void set_location_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Button this_obj = sender as Button;
            location_form lf = new location_form();
            if(lf.ShowDialog() == DialogResult.OK)
            {
                if (lf.result.Trim() != "")
                {
                    this_obj.Tag = lf.result;
                }
                else
                    this_obj.Tag = null;
            }
        }
    }
}
