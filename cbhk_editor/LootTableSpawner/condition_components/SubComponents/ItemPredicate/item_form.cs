using System.Windows.Forms;
using System;
using cbhk_editor.MainForm;
using System.Drawing;
using System.Media;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate
{
    public partial class item_form : Form
    {
        //保存最终结果
        public string result = "";
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        public item_form()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            MaximumSize = Size;
            TreeView Root = Cbhk_form.register;
            item_id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if (item.Text == "minecraft:item")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if (entry.Text == "entries")
                        {
                            foreach (TreeNode a_item in entry.Nodes)
                            {
                                item_id_box.Items.Add(a_item.Text);
                                item_id_box.AutoCompleteCustomSource.Add(a_item.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
            }

            add_enchant_Click(null, null);
            set_count.Click += SetButtonTag;
            set_durability.Click += SetButtonTag;
            foreach (ToolStripMenuItem item in item_title_menu.Items)
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

        private void UpdateInfo()
        {
            #region 合并物品ID
            string idInfo = "";
            if (item_id_box.Text.Trim() != "")
                idInfo = "\"item\":\"" + item_id_box.Text.Trim() + "\",";
            else
            {
                result = "";
                return;
            }
            #endregion

            #region 合并数量数据
            string countInfo = "";
            if (set_count.Tag != null)
                countInfo = set_count.Tag.ToString();
            #endregion

            #region 合并耐久数据
            string durabilityInfo = "";
            if (set_durability.Tag != null)
                durabilityInfo = set_durability.Tag.ToString();
            #endregion

            #region 合并NBT数据
            string itemNbtInfo = "";
            if (nbt_box.Text.Trim() != "")
                itemNbtInfo = "\"nbt\":\"{"+nbt_box.Text.Trim()+"}\",";
            #endregion

            #region 合并药水ID数据
            string potionInfo = "";
            if (potion_box.Text.Trim() != "")
                potionInfo = "\"potion\":\""+potion_box.Text.Trim()+"\",";
            #endregion

            #region 合并标签数据
            string tagInfo = "";
            if (tag_box.Text.Trim() != "")
                tagInfo = "\"tag\":\"" + tag_box.Text.Trim() + "\",";
            #endregion

            #region 合并附魔数据
            string enchantInfo = "";
            foreach (TabPage item in enchant_tab.TabPages)
            {
                if (item.Tag != null)
                    enchantInfo += item.Tag.ToString();
            }
            if (enchantInfo.Trim() != "")
                enchantInfo = "\"enchantments\":["+enchantInfo.TrimEnd(',')+"],";
            #endregion

            #region 合并最终数据
            string resultInfo = idInfo + countInfo + durabilityInfo + itemNbtInfo + potionInfo + tagInfo + enchantInfo;
            result = "{" + resultInfo.TrimEnd(',') + "},";
            #endregion
        }

        private void item_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateInfo();
            DialogResult = DialogResult.OK;
        }

        private void SetButtonTag(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (min_box.Value != -1 && max_box.Value != -1)
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":{\"min\":" + min_box.Value + ",\"max\":" + max_box.Value+"},";
            else
                if (min_box.Value != -1)
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":" + min_box.Value+",";
            else
                if (max_box.Value != -1)
                this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":" + max_box.Value+",";
            else
                this_obj.Tag = null;
            UpdateInfo();
        }

        private void add_enchant_Click(object sender, EventArgs e)
        {
            enchant_page ep = new enchant_page();
            enchant_tab.TabPages.Add(ep.enchant_tab.SelectedTab);
            enchant_tab.SelectedIndex = enchant_tab.TabPages.Count - 1;
            enchant_tab.SelectedTab.Text = enchant_tab.TabPages.Count + "";
        }

        private void delete_enchant_Click(object sender, EventArgs e)
        {
            enchant_tab.TabPages.RemoveAt(enchant_tab.SelectedIndex);
        }

        private void clear_enchant_Click(object sender, EventArgs e)
        {
            enchant_tab.TabPages.Clear();
        }
    }
}
