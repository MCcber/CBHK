using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Entity
{
    public partial class EveryHurted : UserControl
    {
        public EveryHurted()
        {
            InitializeComponent();
            load_entity.Click += Load_entity.Modify;
        }
    }
}
