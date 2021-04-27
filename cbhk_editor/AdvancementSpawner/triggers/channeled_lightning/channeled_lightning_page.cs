using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.channeled_lightning
{
    public partial class channeled_lightning_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public channeled_lightning_page()
        {
            InitializeComponent();
            set_victims.Click += ClickSound;
            set_player.Click += ClickSound;

            set_victims.Click += SetInfo.SetEntities;
            set_player.Click += SetInfo.SetPlayer;

            set_victims.Click += UpdateInfo;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+ (set_victims.Tag != null ? ",\"victims\":[" + set_victims.Tag.ToString() + "]" : "");
                table.Parent.Tag = "\"conditions\":{" + result +"}";
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
