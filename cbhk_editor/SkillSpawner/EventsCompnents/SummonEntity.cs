using cbhk_editor.MainForm;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.EventsCompnents
{
    public partial class SummonEntity : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public SummonEntity()
        {
            InitializeComponent();
            load_entity.Click += Load_entity.Modify;
            TreeView Root = Cbhk_form.register;
            entity_id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            entity_id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                                entity_id_box.Items.Add(subsubitem.Text);
                                entity_id_box.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
            }
        }
    }
}
