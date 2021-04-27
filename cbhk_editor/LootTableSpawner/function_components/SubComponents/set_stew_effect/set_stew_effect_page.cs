using cbhk_editor.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_stew_effect
{
    public partial class set_stew_effect_page : UserControl
    {
        public set_stew_effect_page()
        {
            InitializeComponent();

            effect_id_box.TextChanged += UpdateInfo;
            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;

            TreeView Root = Cbhk_form.register;
            effect_id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            effect_id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:attribute")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_item in entry.Nodes)
                            {
                                effect_id_box.Items.Add(a_item.Text);
                                effect_id_box.AutoCompleteCustomSource.Add(a_item.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (effect_id_box.Text.Trim() != "")
            {
                #region 合并效果数据
                string effectsInfo = "";
                if (min_value_box.Value != -1 && max_value_box.Value != -1)
                    effectsInfo = "{\"type\":\"minecraft:" + effect_id_box.Text.Trim() + "\",\"duration\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "}},";
                else
                    if (min_value_box.Value != -1)
                    effectsInfo = "{\"type\":\"minecraft:" + effect_id_box.Text.Trim() + "\",\"duration\":" + min_value_box.Value + "},";
                else
                    if (max_value_box.Value != -1)
                    effectsInfo = "{\"type\":\"minecraft:" + effect_id_box.Text.Trim() + "\",\"duration\":" + max_value_box.Value + "},";

                if (effectsInfo.Trim() != "")
                    table.Parent.Tag = effectsInfo;
                #endregion
            }
            else
                table.Parent.Tag = null;

        }
    }
}
