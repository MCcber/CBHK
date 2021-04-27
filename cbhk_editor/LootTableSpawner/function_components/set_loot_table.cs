using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_loot_table : UserControl
    {
        public set_loot_table()
        {
            InitializeComponent();

            lt_id_box.TextChanged += UpdateInfo;
            lt_seed_box.TextChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            #region 合并种子数据
            string seedInfo = "";
            if (lt_seed_box.Text.Trim() != "")
                seedInfo = ",\"seed\":"+lt_seed_box.Text.Trim();
            #endregion

            #region 合并最终结果
            if (lt_id_box.Text.Trim() != "")
            {
                table.Parent.Tag = "{\"function\":\"minecraft:set_loot_table\",\"name\":\""+Regex.Match(lt_id_box.Text.Trim(),@"(.*)").ToString()+"\"" + seedInfo + "},";
            }
            else
                table.Parent.Tag = null;
            #endregion
        }

        private void lt_seed_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
