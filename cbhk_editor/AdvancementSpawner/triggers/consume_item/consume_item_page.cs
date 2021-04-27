using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.consume_item
{
    public partial class consume_item_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public consume_item_page()
        {
            InitializeComponent();

            set_item.Click += ClickSound;
            set_item.Click += UpdateInfo;

            set_player.Click += ClickSound;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_item.Tag != null ? "," + set_item.Tag.ToString(): "");
                table.Parent.Tag = "\"conditions\":{"+result+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
