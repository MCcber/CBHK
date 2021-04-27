using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class limit_count : UserControl
    {
        public limit_count()
        {
            InitializeComponent();
            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            string result = "";
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                result = "{\"function\":\"minecraft:limit_count\",\"limit\":{\"min\":"+min_value_box.Value+",\"max\":"+max_value_box.Value+"}},";
            else
                if(min_value_box.Value != -1)
                result = "{\"function\":\"minecraft:limit_count\",\"limit\":" + min_value_box.Value + "},";
            else
                if(max_value_box.Value != -1)
                result = "{\"function\":\"minecraft:limit_count\",\"limit\":" + max_value_box.Value + "},";

            if (result.Trim() != "")
                table.Parent.Tag = result;
            else
                table.Parent.Tag = null;
        }
    }
}
