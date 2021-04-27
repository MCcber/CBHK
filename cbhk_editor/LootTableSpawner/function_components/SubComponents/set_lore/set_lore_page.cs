using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_lore
{
    public partial class set_lore_page : UserControl
    {
        public set_lore_page()
        {
            InitializeComponent();

            lore_text_box.TextChanged += UpdateInfo;
            font_property_box.Click += UpdateInfo;
            font_color_box.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            #region 合并文本数据
            string textInfo = "";
            if (lore_text_box.Text.Trim() != "")
                textInfo = "\"text\":\"" + Regex.Match(lore_text_box.Text,@"(.*)").ToString() + "\",";
            #endregion

            #region 合并文本属性数据
            string textFontInfo = "";
            foreach (string item in font_property_box.CheckedItems)
            {
                textFontInfo += "\"" + item + "\":true,";
            }
            #endregion

            #region 合并文本颜色数据
            string textColorInfo = "";
            if (font_color_box.CheckedItems.Count > 0)
                textColorInfo = "\"color\":\""+font_color_box.CheckedItems[0].ToString()+"\",";
            #endregion

            #region 合并最终结果
            string result = textInfo + textFontInfo + textColorInfo;
            if (result.Trim() != "")
                result = "{" + result.TrimEnd(',') + "},";

            if (result.Trim() != "")
                table.Parent.Tag = result;
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
    }
}
