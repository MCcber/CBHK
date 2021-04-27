using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components.SubComponents
{
    public partial class stats_page : UserControl
    {
        public stats_page()
        {
            InitializeComponent();
            min_value_box.ValueChanged += ValueUpdate;
            max_value_box.ValueChanged += ValueUpdate;
        }

        private void type_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void ValueUpdate(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            string rangeInfo = "";
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                rangeInfo = "{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value+"},";
            else
            if (min_value_box.Value != -1)
                rangeInfo = min_value_box.Value+"";
            else
            if (max_value_box.Value != -1)
                rangeInfo = max_value_box.Value+"";
            if (type_box.Text.Trim() != "" && id_box.Text.Trim() != "")
            {
                page.Tag = "\"type\":"+type_box.Text.Trim()+",\"stat\":\""+id_box.Text.Trim()+"\",\"value\":"+ rangeInfo;
            }
        }
    }
}
