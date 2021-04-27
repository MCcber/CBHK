using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Entity
{
    public partial class DelayTimes : UserControl
    {
        public DelayTimes()
        {
            InitializeComponent();
            load_entity.Click += Load_entity.Modify;
        }
    }
}
