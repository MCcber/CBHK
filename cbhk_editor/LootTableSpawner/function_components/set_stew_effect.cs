using cbhk_editor.LootTableSpawner.function_components.SubComponents.set_stew_effect;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_stew_effect : UserControl
    {
        public set_stew_effect()
        {
            InitializeComponent();
        }

        private void set_stew_effect_btn_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            set_stew_effect_form ssef = new set_stew_effect_form();
            if(ssef.ShowDialog() == DialogResult.OK)
            {
                if (ssef.result.Trim() != "")
                    this_obj.Parent.Tag = ssef.result;
                else
                    this_obj.Parent.Tag = null;
            }
        }
    }
}
