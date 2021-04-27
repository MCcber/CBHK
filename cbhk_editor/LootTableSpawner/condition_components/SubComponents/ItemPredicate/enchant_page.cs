using cbhk_editor.MainForm;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate
{
    public partial class enchant_page : UserControl
    {
        TreeView Root = Cbhk_form.register;
        public enchant_page()
        {
            InitializeComponent();
            set_min_level.Click += SetButtonTag;
            set_max_level.Click += SetButtonTag;
            enchant_id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            enchant_id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:enchantment")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_item in entry.Nodes)
                            {
                                enchant_id_box.Items.Add(a_item.Text);
                                enchant_id_box.AutoCompleteCustomSource.Add(a_item.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void UpdateInfo()
        {
            string lvl_range = "";
            if (set_min_level.Tag != null && set_max_level.Tag != null)
                lvl_range = "{\"min\":" + set_min_level.Tag.ToString().Trim() + ",\"max\":" + set_max_level.Tag.ToString().Trim() + "}";
            else
            if (set_min_level.Tag != null)
                lvl_range = set_min_level.Tag.ToString();
            else
            if (set_max_level.Tag != null)
                lvl_range = set_max_level.Tag.ToString();
            if (enchant_id_box.Text.Trim() != "" && lvl_range.Trim() != "")
                enchant_id_box.Parent.Tag = "{\"enchantment\":\"" + enchant_id_box.Text.Trim() + "\",\"levels\":" + lvl_range + "},";
            else
                enchant_id_box.Parent.Tag = null;
        }

        private void SetButtonTag(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            NumericUpDown lvl_box = new NumericUpDown()
            {
                Minimum = -1,
                Maximum = 10000000000,
                Value = 0,
                Location = this_obj.Location,
                Size = this_obj.Size,
                BackColor = Color.FromArgb(50,50,50),
                ForeColor = Color.White
            };
            lvl_box.KeyDown += (a,b) => 
            {
                if (b.KeyCode == Keys.Escape)
                    this_obj.Parent.Controls.Remove(lvl_box);
                if(b.KeyCode == Keys.Enter)
                {
                    if (lvl_box.Value != -1)
                        this_obj.Tag = lvl_box.Value + "";
                    else
                        this_obj.Tag = null;
                    this_obj.Parent.Controls.Remove(lvl_box);
                    UpdateInfo();
                }
            };
            this_obj.Parent.Controls.Add(lvl_box);
            lvl_box.BringToFront();
        }

        private void enchant_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void enchant_id_box_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if (!this_obj.Text.Contains("minecraft:"))
                this_obj.Text = "minecraft:" + this_obj.Text;
            if(e.KeyCode == Keys.Enter)
            {
                int CurrentIndex = this_obj.FindString(this_obj.Text.Trim());
                if (CurrentIndex != -1)
                    this_obj.SelectedIndex = CurrentIndex;
                UpdateInfo();
            }
        }
    }
}
