using cbhk_editor.MainForm;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    public partial class GetEffect : UserControl
    {
        public GetEffect()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            effect_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            effect_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if(subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                effect_id.Items.Add(subsubitem.Text);
                                effect_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }
    }
}
