using cbhk_editor.LootTableSpawner.function_components.SubComponents.set_lore;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_lore : UserControl
    {
        public set_lore()
        {
            InitializeComponent();
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (set_lore_btn.Tag != null)
            {
                table.Parent.Tag = "{\"function\":\"minecraft: set_lore\""+set_lore_btn.Tag.ToString()+(replace_box.Checked?",\"replace\":"+replace_box.Checked:"")+"},";
            }
            else
                table.Parent.Tag = null;
        }

        private void set_lore_btn_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            set_lore_form slf = new set_lore_form();
            if (slf.ShowDialog() == DialogResult.OK && slf.result.Trim() != "")
            {
                this_obj.Tag = slf.result;
            }
            else
                this_obj.Tag = null;

            UpdateInfo(null,null);
        }

        private void entity_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
