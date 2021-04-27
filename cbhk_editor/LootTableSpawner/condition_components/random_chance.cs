using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class random_chance : UserControl
    {
        public random_chance()
        {
            InitializeComponent();
        }

        private void chance_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            table.Parent.Tag = "{\"condition\":\"minecraft:random_chance\",\"chance\":"+this_obj.Text.Trim()+"},";
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
    }
}
