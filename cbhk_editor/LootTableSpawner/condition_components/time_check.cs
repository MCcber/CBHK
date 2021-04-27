using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class time_check : UserControl
    {
        public time_check()
        {
            InitializeComponent();
        }

        private void time_value_box_ValueChanged(object sender, EventArgs e)
        {
            if(time_value_box.Value != -1)
            table.Parent.Tag = "{\"condition\":\"minecraft:time_check\",\"value\":"+ time_value_box.Value+ "},";
        }
    }
}
