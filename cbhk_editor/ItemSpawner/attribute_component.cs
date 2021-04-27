using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    public partial class attribute_component : UserControl
    {
        public attribute_component()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            #region 写入属性补全数据
            foreach (TreeNode item in Root.Nodes)
            {
                if (item.Text == "minecraft:attribute")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                attribute_id.Items.Add(subsubitem.Text.Replace("minecraft:generic.", "").Replace("minecraft:", ""));
                                attribute_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", "").Replace("minecraft:", ""));
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}
