using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.entity_killed_player
{
    public partial class entity_killed_player_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public entity_killed_player_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_direct_entity.Click += ClickSound;
            set_direct_entity.Click += SetInfo.SetEntity;
            set_direct_entity.Click += UpdateInfo;

            set_damage.Click += ClickSound;
            set_damage.Click += SetInfo.SetEntity;
            set_damage.Click += UpdateInfo;

        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if(set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_direct_entity.Tag != null?",\"entity\":"+set_direct_entity.Tag.ToString()+",":"")+(set_damage.Tag != null?",\"killing_blow\":" +set_damage.Tag.ToString():"");
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
