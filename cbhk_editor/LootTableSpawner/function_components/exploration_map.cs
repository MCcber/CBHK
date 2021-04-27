using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class exploration_map : UserControl
    {
        List<string> decorationList = new List<string> { "player", "frame", "red_marker", "blue_marker", "target_x", "target_point", "player_off_map", "player_off_limits", "mansion", "monument", "red_x", "banner_" };

        List<string> decorationColors = new List<string> { "white","orange","magenta","light_blue","yellow","lime","pink","gray","light_gray","cyan","purple","blue","brown","green","red","black" };
        public exploration_map()
        {
            InitializeComponent();
            destination_box.KeyPress += ControlInput;
            decoration_box.KeyPress += ControlInput;
            TreeView Root = Cbhk_form.register;
            destination_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            destination_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:worldgen/structure_feature")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_feature in entry.Nodes)
                            {
                                destination_box.Items.Add(a_feature.Text);
                                destination_box.AutoCompleteCustomSource.Add(a_feature.Text);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < decorationList.Count; i++)
            {
                if(i != (decorationList.Count-1))
                decoration_box.Items.Add(decorationList[i]);
                else
                {
                    foreach (string item in decorationColors)
                    {
                        decoration_box.Items.Add(decorationList[i]+item);
                    }
                }
            }

            destination_box.TextChanged += UpdateInfo;
            decoration_box.TextChanged += UpdateInfo;
            zoom_box.ValueChanged += UpdateInfo;
            search_radius_box.ValueChanged += UpdateInfo;
            skip_existing_chunks_box.CheckedChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            #region 合并结构ID数据
            string destinationInfo = ",\"destination\":";
            if (destination_box.Text.Trim() != "")
                destinationInfo += destination_box.Text.Trim();
            else
                destinationInfo = "";
            #endregion

            #region 合并图标数据
            string decorationInfo = ",\"decoration\":";
            if (decoration_box.Text.Trim() != "")
                decorationInfo += decoration_box.Text.Trim();
            else
                decorationInfo = "";
            #endregion

            #region 合并地图缩放等级数据
            string zoomInfo = ",\"zoom\":";
            if (zoom_box.Value != 2)
                zoomInfo += zoom_box.Value;
            else
                zoomInfo = "";
            #endregion

            #region 合并搜索区块半径数据
            string search_radiusInfo = ",\"search_radius\":";
            if (search_radius_box.Value != 50)
                search_radiusInfo += search_radius_box.Value;
            else
                search_radiusInfo = "";
            #endregion

            #region 合并是否跳过已生成区块
            string skip_existing_chunksInfo = ",\"skip_existing_chunks\":";
            if (!skip_existing_chunks_box.Checked)
                skip_existing_chunksInfo += "false";
            else
                skip_existing_chunksInfo = "";
            #endregion

            #region 合并最终结果
            string result = "";
            result = destinationInfo + decorationInfo + zoomInfo + search_radiusInfo + skip_existing_chunksInfo;
            if (result != "")
            {
                result = "{\"function\":\"minecraft:exploration_map\"" + result + "},";
                table.Parent.Tag = result;
            }
            else
                table.Parent.Tag = null;
            #endregion
        }

        private void ControlInput(object sender,KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
