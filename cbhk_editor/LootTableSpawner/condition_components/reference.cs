using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class reference : UserControl
    {
        public reference()
        {
            InitializeComponent();
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            table.Parent.Tag = "{\"condition\":\"minecraft:reference\",\"name\":\""+this_obj.Text.Trim()+"\"},";
        }
    }
}
