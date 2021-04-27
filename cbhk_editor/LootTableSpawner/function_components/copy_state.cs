using cbhk_editor.MainForm;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class copy_state : UserControl
    {
        TreeView BlockList = Cbhk_form.Blocks;
        string LastBlock = "";
        public copy_state()
        {
            InitializeComponent();
            block_id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            block_id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode a_block in BlockList.Nodes)
            {
                block_id_box.Items.Add(a_block.Text);
                block_id_box.AutoCompleteCustomSource.Add(a_block.Text.Replace("minecraft:",""));
            }
        }

        private void UpdateInfo()
        {
            #region 合并属性数据
            string propertiesInfo = ",\"properties\":[";
            for (int i = 0; i < property_list_box.Items.Count; i++)
            {
                if (property_list_box.GetItemChecked(i))
                    propertiesInfo += "\""+property_list_box.Items[i].ToString()+"\",";
            }
            if (propertiesInfo != ",\"properties\":[")
                propertiesInfo = propertiesInfo.TrimEnd(',') + "]";
            else
                propertiesInfo = "";
            #endregion

            #region 合并最终结果
            if (block_id_box.Text.Trim() != "")
            {
                string result = "{\"function\":\"minecraft:copy_state\",\"block\":\""+block_id_box.Text.Trim() + propertiesInfo + "},";
                table.Parent.Tag = result;
            }
            else
                table.Parent.Tag = null;
            #endregion
        }

        private void UpdateProperty()
        {
            int CurrentIndex = block_id_box.FindStringExact(block_id_box.Text.Trim());
            if(CurrentIndex != -1 && LastBlock.Trim() != block_id_box.Text.Trim())
            {
                LastBlock = block_id_box.Text.Trim();
                property_list_box.Items.Clear();
                foreach (TreeNode propertyNode in BlockList.Nodes[CurrentIndex].Nodes)
                {
                    if (propertyNode.Text == "properties")
                    {
                        foreach (TreeNode a_property in propertyNode.Nodes)
                        {
                            property_list_box.Items.Add(a_property.Text);
                        }
                    }
                }
            }
        }

        private void block_id_box_TextChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            int CurrentIndex = this_obj.FindStringExact(this_obj.Text.Trim());
            if (LastBlock != this_obj.Text.Trim() && CurrentIndex!= -1)
            {
                UpdateProperty();
                this_obj.SelectedIndex = CurrentIndex;
                UpdateInfo();
            }
        }

        private void property_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
