using cbhk_editor.LootTableSpawner.function_components.SubComponents.copy_nbt;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class copy_nbt : UserControl
    {
        public copy_nbt()
        {
            InitializeComponent();
        }

        private void source_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void set_nbt_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            copy_nbt_form cnf = new copy_nbt_form();
            if (cnf.ShowDialog() == DialogResult.OK && cnf.result.Trim() != "")
            {
                this_obj.Parent.Tag = cnf.result;
            }
            else
                this_obj.Parent.Tag = null;
        }
    }
}
