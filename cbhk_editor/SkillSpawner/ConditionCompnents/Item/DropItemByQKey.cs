using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    public partial class DropItemByQKey : UserControl
    {
        public DropItemByQKey()
        {
            InitializeComponent();
            load_item.Click += Load_item.Modify;
        }
    }
}
