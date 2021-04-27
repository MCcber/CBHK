using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.FeatureSpawner
{
    public partial class feature_spawner : Form
    {
        Point CurrentPos = new Point();
        Form parent;
        SoundPlayer click_sound;
        Image btn_img = Image.FromFile(Application.StartupPath + "\\ButtonsBgImages\\button.png");
        public feature_spawner()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            feature_view.ExpandAll();
            Icon = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\ResourceImages\\CB图标.ico");
            click_to_return.Click += (a, b) =>
            {
                parent.ShowInTaskbar = true;
                parent.WindowState = FormWindowState.Normal;
                parent.TopMost = true;
                parent.Show();
                parent.TopMost = false;
                Close();
            };
            foreach (ToolStripMenuItem item in feature_title_menu.Items)
            {
                item.BackgroundImage = btn_img;
                item.BackgroundImageLayout = ImageLayout.Stretch;
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.DropDownOpened += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(0, 0, 0);
                };
                item.DropDownClosed += (a, b) =>
                {
                    item.ForeColor = Color.FromArgb(255, 255, 255);
                };
                item.Click += ClickSound;
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    subitem.BackgroundImage = btn_img;
                    subitem.BackgroundImageLayout = ImageLayout.Stretch;
                    subitem.ForeColor = Color.FromArgb(255, 255, 255);
                    subitem.Click += ClickSound;
                }
            }
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
