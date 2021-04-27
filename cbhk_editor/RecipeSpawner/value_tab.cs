using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.RecipeSpawner
{
    public partial class value_tab : UserControl
    {
        public value_tab()
        {
            InitializeComponent();
            recipe_value_tab.SelectedTab.BackColor = key_id.BackColor = key_tag.BackColor = Color.FromArgb(50,50,50);
        }
    }
}
