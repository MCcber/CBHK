using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.player_killed_entity
{
    public partial class player_killed_entity_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public player_killed_entity_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_killing_blow.Click += ClickSound;
            set_killing_blow.Click += SetInfo.SetDamage;
            set_killing_blow.Click += UpdateInfo;

            set_entity.Click += ClickSound;
            set_entity.Click += SetInfo.SetEntity;
            set_entity.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{" + set_player.Tag.ToString() + (set_killing_blow.Tag != null ? ",\"killing_blow\":" + set_killing_blow.Tag.ToString() : "") + (set_entity.Tag != null ? ",\"entity\":" + set_entity.Tag.ToString() : "") + "}";
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
