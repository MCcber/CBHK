using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class join_group : Form
    {
        public join_group()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\ResourceImages\\cbhk_group.jpg");
            MaximumSize = MinimumSize = Size;
            BackgroundImageLayout = ImageLayout.Stretch;
            Show();
        }
    }
}
