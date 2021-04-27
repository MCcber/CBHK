using cbhk_editor.LootTableSpawner.condition_components;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.tool_forms
{
    public partial class block_form : Form
    {
        public block_form()
        {
            InitializeComponent();
            block_state_property bsp = new block_state_property();
            Controls.Add(bsp.table);
        }

        private void block_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
