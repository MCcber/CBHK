using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner.ConditionCompnents.Item
{
    public partial class SelectedItem : UserControl
    {
        public SelectedItem()
        {
            InitializeComponent();
            load_selected_item.Click += Load_item.Modify;
        }
    }
}
