using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_name : UserControl
    {
        public set_name()
        {
            InitializeComponent();

            name_box.TextChanged += UpdateInfo;
            score_id_box.TextChanged += UpdateInfo;
            player_name_box.TextChanged += UpdateInfo;
            font_property_box.Click += UpdateInfo;
            font_color_box.Click += UpdateInfo;
            entity_box.SelectedIndexChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            #region 合并文本数据
            string textInfo = "{\"function\":\"minecraft:set_name\"";
            if(name_box.Enabled)
            {
                textInfo += ",\"name\":\""+name_box.Text.Trim()+"\"";
            }
            else
            if(score_id_box.Text.Trim() != "" && player_name_box.Text.Trim() != "")
            {
                textInfo += ",\"name\":{\"score\":{\"objective\":\"" + score_id_box.Text.Trim() + "\",\"name\":\"" + player_name_box.Text.Trim() + "\"}";
                foreach (string item in font_property_box.CheckedItems)
                {
                    textInfo += ",\"" + item + "\":true";
                }
                if (font_color_box.CheckedItems.Count > 0)
                    textInfo += ",\"color\":" + font_color_box.CheckedItems[0].ToString();

                textInfo += "},\"entity\":"+entity_box.Text.Trim()+"},";
            }

            if (textInfo.Trim() != "{\"function\":\"minecraft:set_name\"")
                table.Parent.Tag = textInfo;
            else
                table.Parent.Tag = null;
            #endregion
        }

        private void font_color_box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox this_obj = sender as CheckedListBox;
            foreach (int nIndex in this_obj.CheckedIndices)
            {
                if (nIndex != e.Index)
                    this_obj.SetItemCheckState(nIndex, CheckState.Unchecked);
            }
        }

        private void model_box_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox this_obj = sender as CheckBox;
            if (this_obj.Checked)
            {
                name_box.Enabled = true;
                score_id_box.Enabled = player_name_box.Enabled = font_property_box.Enabled = font_color_box.Enabled = false;
            }
            else
            {
                name_box.Enabled = false;
                score_id_box.Enabled = player_name_box.Enabled = font_property_box.Enabled = font_color_box.Enabled = true;
            }
        }

        private void entity_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
