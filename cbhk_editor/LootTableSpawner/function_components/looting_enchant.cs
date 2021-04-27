using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class looting_enchant : UserControl
    {
        public looting_enchant()
        {
            InitializeComponent();
            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;
            limit_box.ValueChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            string count_range = "";
            string limitInfo = "";
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                count_range = ",\"count\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "},";
            else
                if (min_value_box.Value != -1)
                count_range = ",\"count\":" + min_value_box.Value + ",";
            else
                if (max_value_box.Value != -1)
                count_range = ",\"count\":" + max_value_box.Value + ",";

            if (limit_box.Value != -1)
                limitInfo = ",\"limit\":"+limit_box.Value;

            if (count_range.Trim() != "" || limitInfo.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:looting_enchant\"" + count_range + limitInfo + "},";
            else
                table.Parent.Tag = null;
        }
    }
}
