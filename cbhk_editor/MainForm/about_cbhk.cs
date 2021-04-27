using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class about_cbhk : Form
    {
        public about_cbhk()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            MaximumSize = MinimumSize = Size;
            Show();
        }
    }
}
