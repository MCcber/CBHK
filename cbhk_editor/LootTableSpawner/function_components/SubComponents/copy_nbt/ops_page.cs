using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents
{
    public partial class ops_page : UserControl
    {
        public ops_page()
        {
            InitializeComponent();
            set_source.Click += SetButtonTag;
            set_source.Click += UpdateInfo;
            set_target.Click += SetButtonTag;
            set_target.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            string sourceInfo = "";
            if (set_source.Tag != null)
                sourceInfo = set_source.Tag.ToString();
            string targetInfo = "";
            if (set_target.Tag != null)
                targetInfo = set_target.Tag.ToString();
            string opInfo = "";
            if (set_op.Tag != null)
                opInfo = set_op.Tag.ToString();

            opInfo = sourceInfo + targetInfo + opInfo;
            opInfo = opInfo.TrimEnd(',');
            set_source.Parent.Tag = "{"+opInfo+"},";
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

        private void SetButtonTag(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            TextBox set_box = new TextBox()
            {
                Location = this_obj.Location,
                Size = this_obj.Size,
                BackColor = Color.FromArgb(50,50,50),
                ForeColor = Color.White
            };
            set_box.KeyDown += (a,b) => 
            {
                if (b.KeyCode == Keys.Escape)
                    ops_tab.SelectedTab.Controls.Remove(set_box);
                if(b.KeyCode == Keys.Enter)
                {
                    if (set_box.Text.Trim() != "")
                        this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":\"" + set_box.Text.Trim() + "\",";
                    else
                        this_obj.Tag = null;
                    set_source.Parent.Controls.Remove(set_box);
                }
            };
            set_source.Parent.Controls.Add(set_box);
            set_box.BringToFront();
        }

        private void set_op_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            ComboBox op_box = new ComboBox()
            {
                Location = this_obj.Location,
                Size = this_obj.Size,
                BackColor = Color.FromArgb(50,50,50),
                ForeColor = Color.White
            };
            string[] op_item = new string[] { "replace", "append","merge" };
            op_box.Items.AddRange(op_item);
            op_box.KeyPress += (a,b) => { b.Handled = true; };
            op_box.KeyDown += (c,d) => 
            {
                if (d.KeyCode == Keys.Escape)
                    set_source.Parent.Controls.Remove(op_box);
                if(d.KeyCode == Keys.Enter)
                {
                    if (op_box.Text.Trim() != "")
                        this_obj.Tag = "\"" + this_obj.Name.Split('_')[1] + "\":\"" + op_box.Text.Trim() + "\",";
                    else
                        this_obj.Tag = null;
                    set_source.Parent.Controls.Remove(op_box);
                    UpdateInfo(null,null);
                }
            };
            set_source.Parent.Controls.Add(op_box);
            op_box.BringToFront();
        }
    }
}
