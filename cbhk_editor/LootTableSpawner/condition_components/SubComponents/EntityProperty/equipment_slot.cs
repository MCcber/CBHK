using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents.EntityProperty
{
    public partial class equipment_slot : Form
    {
        public equipment_slot()
        {
            InitializeComponent();
        }

        private void equipment_slot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (slot_box.CheckedItems.Count > 0)
                DialogResult = DialogResult.OK;
        }
    }
}
