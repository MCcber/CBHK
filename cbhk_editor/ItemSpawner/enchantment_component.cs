using cbhk_editor.MainForm;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    public partial class enchantment_component : UserControl
    {
        public enchantment_component()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                #region 写入附魔补全数据
                if (item.Text == "minecraft:enchantment")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                enchantment_id.Items.Add(subsubitem.Text);
                                enchantment_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion
            }
        }
    }
}
