using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Entity
{
    public partial class HurtedDamage : UserControl
    {
        public HurtedDamage()
        {
            InitializeComponent();
            load_entity.Click += Load_entity.Modify;
        }
    }
}
