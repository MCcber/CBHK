using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class fill_player_head : UserControl
    {
        public fill_player_head()
        {
            InitializeComponent();
            set_head.TextChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_head.Text.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:fill_player_head\",\"entity\":\"" + set_head.Text.Trim() + "\"},";
            else
                table.Parent.Tag = null;
        }

        private void set_head_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
