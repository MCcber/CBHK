using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.MainForm
{
    public partial class command_result : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        public command_result(string title,List<string> content)
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            MaximumSize = Size;
            Text = title;
            cmd_result_tab.TabPages.Clear();
            foreach (string item in content)
            {
                TabPage page = new TabPage()
                {
                    Text = "第"+(cmd_result_tab.TabPages.Count+1)+"条"
                };
                TextBox result_box = new TextBox()
                {
                    Name = "result_box",
                    BackColor = Color.FromArgb(50, 50, 50),
                    ForeColor = Color.FromArgb(255,255,255),
                    Multiline = true,
                    Dock = DockStyle.Fill,
                    Text = item
                };
                page.Controls.Add(result_box);
                cmd_result_tab.TabPages.Add(page);
            }
        }

        private void click_to_copy_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            TextBox current_box = cmd_result_tab.SelectedTab.Controls.Find("result_box", true)[0] as TextBox;
            current_box.Select(0, current_box.Text.Length);
            Clipboard.SetText(current_box.Text);
        }
    }
}
