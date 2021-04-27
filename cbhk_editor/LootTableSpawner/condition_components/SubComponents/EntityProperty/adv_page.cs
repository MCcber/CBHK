using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    public partial class adv_page : UserControl
    {
        public adv_page()
        {
            InitializeComponent();
        }

        private void set_adv_id_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            Form currnet_form = this_obj.FindForm();
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
                    currnet_form.Controls.Remove(text_box);
                if (b.KeyCode == Keys.Enter)
                {
                    this_obj.Tag = text_box.Text.Trim();
                    UpdateResult();
                    page.Controls.Remove(text_box);
                }
            };
            page.Controls.Add(text_box);
            text_box.BringToFront();
        }

        private void add_trigger_Click(object sender, EventArgs e)
        {
            trigger_box.Items.Add(trigger_box.Text);
            trigger_box.Text = "";
            UpdateResult();
        }
        private void trigger_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            trigger_box.Items.RemoveAt(trigger_box.SelectedIndex);
            UpdateResult();
        }

        private void UpdateResult()
        {
            if(trigger_box.Items.Count > 0 && set_adv_id.Tag!=null && set_adv_id.Tag.ToString() != "")
            {
                page.Tag = set_adv_id.Tag.ToString()+",\""+set_adv_id.Tag.ToString().Split(':')[0]+"\":{";
                string triggers = "";
                foreach (string item in trigger_box.Items)
                {
                    triggers += "\""+item+"\":true,";
                }
                triggers = triggers.TrimEnd(',');
                page.Tag += triggers +"},";
            }
            else
                if(trigger_box.Items.Count == 0 && set_adv_id.Tag != null && set_adv_id.Tag.ToString() != "")
            {
                page.Tag = set_adv_id.Tag.ToString()+",";
            }
            page.Tag = page.Tag.ToString().TrimEnd(',');
        }
    }
}
