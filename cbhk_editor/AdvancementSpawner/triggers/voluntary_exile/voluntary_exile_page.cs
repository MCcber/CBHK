using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.voluntary_exile
{
    public partial class voluntary_exile_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public voluntary_exile_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_location.Click += ClickSound;
            set_location.Click += SetInfo.SetLocation;
            set_location.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString() + (set_location.Tag != null ? ",\"location\":" + set_location.Tag.ToString() : "");
                table.Parent.Tag = "\"conditions\":{" + result + "}";
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
