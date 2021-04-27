using cbhk_editor.LootTableSpawner.condition_components.SubComponents;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class location_check : UserControl
    {
        string x_value = "";
        string y_value = "";
        string z_value = "";
        public location_check()
        {
            InitializeComponent();
            offsetX.TextChanged += UpdateInfo;
            offsetY.TextChanged += UpdateInfo;
            offsetZ.TextChanged += UpdateInfo;

            offsetX.KeyPress += ControlInput;
            offsetY.KeyPress += ControlInput;
            offsetZ.KeyPress += ControlInput;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            x_value = offsetX.Text.Trim() != "" ? "\"offsetX\":" + offsetX.Text.Trim() + "," : "";
            y_value = offsetY.Text.Trim() != "" ? "\"offsetY\":" + offsetY.Text.Trim() + "," : "";
            z_value = offsetZ.Text.Trim() != "" ? "\"offsetZ\":" + offsetZ.Text.Trim() + "," : "";

            string pos_info = "";
            pos_info =  x_value + y_value + z_value + (set_location_check.Tag != null? set_location_check.Tag.ToString() : "");
            if(pos_info.Trim() != "")
            pos_info = ","+pos_info.TrimEnd(',');
            table.Parent.Tag = "{\"condition\":\"minecraft:location_check\""+pos_info+"},";
        }

        private void set_location_check_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            location_form lf = new location_form();
            if (lf.ShowDialog() == DialogResult.OK && lf.result.Trim() != "")
                this_obj.Tag = "\"predicate\":{"+lf.result+"}";
            else
                this_obj.Tag = null;
            UpdateInfo(null, null);
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
    }
}
