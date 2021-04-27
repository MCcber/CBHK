using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    public partial class WearItem : UserControl
    {
        public WearItem()
        {
            InitializeComponent();
            load_wear_item.Click += Load_item.Modify;
        }
    }
}
