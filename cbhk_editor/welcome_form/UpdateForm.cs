using cbhk_editor.MainForm;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.welcome_form
{
    public partial class UpdateForm : Form
    {
        public UpdateForm(string target_url,string target_path)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");

            string result = login_tool.GetFileProcess(target_url, target_path, task_speed);
            if(result == "success")
            {
                Text = "更新完毕!";
                DialogResult = DialogResult.OK;
            }
        }
    }
}
