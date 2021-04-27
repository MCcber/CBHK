using System.Windows.Forms;
using System;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_count : UserControl
    {
        public set_count()
        {
            InitializeComponent();
            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                table.Parent.Tag = "{\"function\":\"minecraft:set_count\",\"count\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "}},";
            else
                if (min_value_box.Value != -1)
                table.Parent.Tag = "{\"function\":\"minecraft:set_count\",\"count\":" + min_value_box.Value + "},";
            else
                if (max_value_box.Value != -1)
                table.Parent.Tag = "{\"function\":\"minecraft:set_count\",\"count\":" + max_value_box.Value + "},";
            else
                table.Parent.Tag = null;
        }
    }
}
