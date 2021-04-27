using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    public partial class HaveItems : UserControl
    {
        public HaveItems()
        {
            InitializeComponent();
            load_item_info.Click += Load_item.Modify;
        }
    }
}
