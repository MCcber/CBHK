using System;
using System.Windows.Forms;
using cbhk_editor.LootTableSpawner.condition_components.SubComponents.ItemPredicate;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class match_tool : UserControl
    {
        public match_tool()
        {
            InitializeComponent();
        }

        private void set_item_Click(object sender, EventArgs e)
        {
            item_form Item_Form = new item_form();
            if(Item_Form.ShowDialog() == DialogResult.OK && Item_Form.result.Trim() != "")
                    set_item.Parent.Tag = Item_Form.result;
            else
            set_item.Parent.Tag = null;
        }
    }
}
