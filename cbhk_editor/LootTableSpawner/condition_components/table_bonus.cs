using cbhk_editor.MainForm;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class table_bonus : UserControl
    {
        public table_bonus()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            enchant_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            enchant_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                                enchant_id.Items.Add(a_item.Text);
                                enchant_id.AutoCompleteCustomSource.Add(a_item.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void UpdateInfo()
        {
            #region 合并概率数据
            string chanceList = "";
            foreach (string item in chance_box.Items)
            {
                chanceList += item + ",";
            }
            table.Parent.Tag = "{\"condition\": \"minecraft:table_bonus\",\"enchantment\": \""+enchant_id.Text.Trim()+"\",\"chances\":["+chanceList.TrimEnd(',')+"]},";
            #endregion

        }

        private void chance_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(chance_box.Text.Trim() != "")
            {
                chance_box.Items.Add(chance_box.Text.Trim());
                chance_box.Text = "";
                UpdateInfo();
            }
        }

        private void enchant_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void enchant_id_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ComboBox this_obj = sender as ComboBox;
                int CurrentIndex = this_obj.FindString(this_obj.Text.Trim());
                if (CurrentIndex != -1)
                    this_obj.SelectedIndex = CurrentIndex;
            }
        }
    }
}
