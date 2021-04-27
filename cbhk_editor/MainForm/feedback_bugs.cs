using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class feedback_bugs : Form
    {
        public feedback_bugs()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            BackgroundImage = Image.FromFile(Application.StartupPath + "\\ResourceImages\\my_qq.png");
            MaximumSize = MinimumSize = Size;
            BackgroundImageLayout = ImageLayout.Stretch;
            Show();
        }
    }
}
