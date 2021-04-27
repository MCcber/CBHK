using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class enchant_with_levels : UserControl
    {
        public enchant_with_levels()
        {
            InitializeComponent();
            treasure.Click += set_level_Click;
        }

        private void set_level_Click(object sender, EventArgs e)
        {
            #region 合并等级数据
            string levelInfo = "";
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                levelInfo = ",\"levels\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "}";
            else
                if (min_value_box.Value != -1)
                levelInfo = ",\"levels\":" + min_value_box.Value;
            else
                if (max_value_box.Value != -1)
                levelInfo = ",\"levels\":"+max_value_box.Value;
            #endregion

            #region 合并宝藏附魔数据
            string treasureInfo = "";
            if (treasure.Checked)
                treasureInfo = ",\"treasure\":true";
            #endregion

            #region 合并最终结果
            if (levelInfo != "" || treasureInfo != "")
            {
                string result = "{\"function\":\"minecraft:enchant_with_levels\"" + levelInfo + treasureInfo + "},";
                table.Parent.Tag = result;
            }
            else
                table.Parent.Tag = null;
            #endregion
        }
    }
}
