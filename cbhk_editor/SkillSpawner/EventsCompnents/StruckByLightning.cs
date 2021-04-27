using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    public partial class StruckByLightning : UserControl
    {
        public StruckByLightning()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            LightedEntity.AutoCompleteMode = AutoCompleteMode.Suggest;
            LightedEntity.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if (item.Text == "minecraft:entity_type")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                LightedEntity.Items.Add(subsubitem.Text);
                                LightedEntity.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
            }
        }
    }
}
