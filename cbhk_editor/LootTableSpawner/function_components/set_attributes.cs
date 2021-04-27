using cbhk_editor.LootTableSpawner.function_components.SubComponents.set_attributes;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_attributes : UserControl
    {
        public set_attributes()
        {
            InitializeComponent();
        }

        private void set_attribute_btn_Click(object sender, EventArgs e)
        {
            set_attributes_form saf = new set_attributes_form();
            if (saf.ShowDialog() == DialogResult.OK && saf.result.Trim() != "")
            {
                table.Parent.Tag = saf.result;
            }
            else
                table.Parent.Tag = null;
        }
    }
}
