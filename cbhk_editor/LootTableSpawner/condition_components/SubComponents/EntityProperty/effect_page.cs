using cbhk_editor.MainForm;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    public partial class effect_page : UserControl
    {
        public effect_page()
        {
            InitializeComponent();
            amplifier_box.ValueChanged += ValueUpdate;
            duration_box.ValueChanged += ValueUpdate;
            TreeView Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode subitem in entry.Nodes)
                            {
                                effect_id_box.Items.Add(subitem.Text);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateResult()
        {
            if(effect_id_box.Text.Trim() !="")
            {
                page.Tag = "{\"id\":\""+effect_id_box.Text.Trim()+ "\",\"amplifier\":"+amplifier_box.Value+ ",\"duration\":"+duration_box.Value+"},";
            }
        }

        private void effect_id_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void ValueUpdate(object sender,EventArgs e)
        {
            UpdateResult();
        }

        private void effect_id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
