using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.cured_zombie_villager
{
    public partial class cured_zombie_villager_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public cured_zombie_villager_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_villager.Click += ClickSound;
            set_zombie.Click += ClickSound;

            set_player.Click += SetInfo.SetPlayer;
            set_villager.Click += SetInfo.SetEntity;
            set_zombie.Click += SetInfo.SetEntity;

            set_player.Click += UpdateInfo;
            set_villager.Click += UpdateInfo;
            set_zombie.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+ (set_zombie.Tag != null ? ",\"zombie\":" + set_zombie.Tag.ToString(): "")+ (set_villager.Tag != null ? ",\"villager\":" + set_villager.Tag.ToString() : "");
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
