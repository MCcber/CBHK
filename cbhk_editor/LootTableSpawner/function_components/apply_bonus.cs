using cbhk_editor.MainForm;
using System.Windows.Forms;
using System;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class apply_bonus : UserControl
    {
        public apply_bonus()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
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

            foreach (Control item in table.Controls)
            {
                if(item is ComboBox)
                {
                    ComboBox this_obj = item as ComboBox;
                    this_obj.SelectedIndexChanged += UpdateInfo;
                }
            }

            extra_box.ValueChanged += UpdateInfo;
            probability_box.TextChanged += UpdateInfo;
            probability_box.KeyPress += ControlInput;
            bonusMultiplier_box.TextChanged += UpdateInfo;
            bonusMultiplier_box.KeyPress += ControlInput;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (enchant_id_box.Text.Trim() != "" && formula_box.Text.Trim() != "")
            {
                string parameterInfo = ",parameters:{";
                if (extra_box.Value != -1)
                    parameterInfo += extra_box.Value != -1 ? "\"extra\":"+extra_box.Value+",":"";
                if (probability_box.Text.Trim() != "")
                    parameterInfo += probability_box.Text.Trim() != ""? "\"probability\":" +probability_box.Text.Trim()+",":"";
                if (bonusMultiplier_box.Text.Trim() != "")
                    parameterInfo += bonusMultiplier_box.Text.Trim() != "" ? "\"bonusMultiplier\":" + bonusMultiplier_box.Text.Trim() + "," :"";

                if (parameterInfo != ",parameters:{")
                    parameterInfo = parameterInfo.TrimEnd(',') + "}";
                else
                    parameterInfo = "";
                table.Parent.Tag = "{\"function\":\"minecraft:apply_bonus\",\"enchantment\":\""+enchant_id_box.Text.Trim()+ "\",\"formula\":\""+formula_box.Text.Trim()+"\""+parameterInfo+"},";
            }
            else
                table.Tag = null;
        }

        private void ControlInput(object sender,KeyPressEventArgs e)
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

        private void formula_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
