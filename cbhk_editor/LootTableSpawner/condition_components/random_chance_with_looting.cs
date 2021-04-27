using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class random_chance_with_looting : UserControl
    {
        public random_chance_with_looting()
        {
            InitializeComponent();
            chance_box.KeyPress += ControlInput;
            looting_multiplier_box.KeyPress += ControlInput;

            chance_box.TextChanged += UpdateInfo;
            looting_multiplier_box.TextChanged += UpdateInfo;
        }

        private void ControlInput(object sender, KeyPressEventArgs e)
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

        private void UpdateInfo(object sender,EventArgs e)
        {
            table.Parent.Tag = "{\"condition\":\"minecraft:random_chance_with_looting\",\"chance\":"+chance_box.Text.Trim()+",\"looting_multiplier\":"+looting_multiplier_box.Text.Trim()+"},";
        }
    }
}
