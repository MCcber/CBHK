using cbhk_editor.LootTableSpawner.condition_components.SubComponents;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class entity_properties : UserControl
    {
        public entity_properties()
        {
            InitializeComponent();
        }

        private void set_entity_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            entity_property_form epf = new entity_property_form();
            if (epf.ShowDialog() == DialogResult.OK && epf.result.Trim() != "")
                this_obj.Tag = epf.result;
            else
                this_obj.Tag = null;
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            string entityInfo = "";
            entityInfo = set_entity.Tag != null ? "\"predicate\": {" + set_entity.Tag.ToString().TrimEnd(',') + "}," : "";
            if (entityInfo.Trim() != "")
                table.Parent.Tag = "{\"condition\": \"minecraft:entity_properties\"," + entityInfo + "\"entity\": \"" + entity_box.Text.Trim() + "\"},";
            else
                table.Parent.Tag = null;
        }

        private void entity_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void entity_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
