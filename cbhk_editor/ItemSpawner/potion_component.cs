using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    public partial class potion_component : UserControl
    {
        public potion_component()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                #region 写入药水ID补全数据
                if (item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            for (int i = 0; i < subitem.Nodes.Count; i++)
                            {
                                potion_id.Items.Add(subitem.Nodes[i].Text);
                                potion_id.AutoCompleteCustomSource.Add(subitem.Nodes[i].Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion
            }
        }
    }
}
