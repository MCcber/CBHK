using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    public partial class entity_potion : UserControl
    {
        public entity_potion(TreeView root_node)
        {
            InitializeComponent();

            foreach (TreeNode item in root_node.Nodes)
            {
                #region 药水效果id补全数据源
                if (item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode entries in item.Nodes)
                    {
                        if (entries.Text.Contains("entries"))
                        {
                            foreach (TreeNode entry in entries.Nodes)
                            {
                                effect_id_box.Items.Add(entry.Text);
                                effect_id_box.AutoCompleteCustomSource.Add(entry.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion
            }
        }
    }
}
