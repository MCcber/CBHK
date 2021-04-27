using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class weather_check : UserControl
    {
        public weather_check()
        {
            InitializeComponent();
            raining.Click += UpdateInfo;
            thundering.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            string rainingInfo = raining.Checked ?"\"raining\":true,":"";
            string thunderingInfo = thundering.Checked ? "\"thundering\":true," : "";
            string weatherInfo = rainingInfo + thunderingInfo;
            if (weatherInfo.Trim() != "")
            {
                weatherInfo = "," + weatherInfo.TrimEnd(',');
                table.Parent.Tag = "{\"condition\":\"minecraft:weather_check\"" + weatherInfo + "},";
            }
            else
                table.Parent.Tag = null;
        }
    }
}
