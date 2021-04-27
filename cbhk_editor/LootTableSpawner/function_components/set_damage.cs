using System.Windows.Forms;
using System;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_damage : UserControl
    {
        public set_damage()
        {
            InitializeComponent();
            min_value_box.TextChanged += UpdateInfo;
            max_value_box.TextChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (min_value_box.Text.Trim() != "" && max_value_box.Text.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:set_damage\",\"damage\":{\"min\":" + min_value_box.Text.Trim() + ",\"max\":" + max_value_box.Text.Trim() + "}},";
            else
                if (min_value_box.Text.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:set_damage\",\"damage\":" + min_value_box.Text.Trim() + "},";
            else
                if (max_value_box.Text.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:set_damage\",\"damage\":" + max_value_box.Text.Trim() + "},";
            else
                table.Parent.Tag = null;
        }
    }
}
