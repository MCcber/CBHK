using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class enchant_randomly : UserControl
    {
        public enchant_randomly()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:enchantment")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_enchant in entry.Nodes)
                            {
                                enchant_list_box.Items.Add(a_enchant.Text);
                            }
                        }
                    }
                }
            }
        }

        private void enchant_list_box_Click(object sender, System.EventArgs e)
        {
            #region 合并附魔数据
            string enchantInfo = ",\"enchantments\":[";
            for (int i = 0; i < enchant_list_box.Items.Count; i++)
            {
                if (enchant_list_box.GetItemChecked(i))
                    enchantInfo += "\""+enchant_list_box.Items[i]+"\",";
            }
            if (enchantInfo != ",\"enchantments\":[")
                enchantInfo = enchantInfo.Trim(',') + "]";
            else
                enchantInfo = "";
            #endregion

            #region 合并最终结果
            if (enchantInfo.Trim() != "")
            {
                string result = "{\"function\":\"minecraft:enchant_randomly\"" + enchantInfo + "},";
                enchant_list_box.Parent.Tag = result;
            }
            else
                enchant_list_box.Parent.Tag = null;
            #endregion
        }
    }
}
