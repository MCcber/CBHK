using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    public partial class EntityNBTForm : Form
    {
        public string nbt_result = "";
        public EntityNBTForm(string nbt_string)
        {
            InitializeComponent();
            MaximumSize = Size;
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            nbt_box.Text = nbt_string;
            nbt_box.BackColor = Color.FromArgb(50,50,50);
        }

        private void EntityNBTForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                nbt_result = nbt_box.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
