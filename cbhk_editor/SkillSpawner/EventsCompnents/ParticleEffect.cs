using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    public partial class ParticleEffect : UserControl
    {
        public ParticleEffect()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            particle_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            particle_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if (item.Text == "minecraft:particle_type")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                particle_id.Items.Add(subsubitem.Text);
                                particle_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
            }
        }
    }
}
