using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.tame_animal
{
    public partial class tame_animal_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public tame_animal_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_entity.Click += ClickSound;
            set_entity.Click += SetInfo.SetEntity;
            set_entity.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{" + set_player.Tag.ToString() + (set_entity.Tag != null ? ",\"entity\":\"" + set_entity.Tag.ToString() + "\"" : "") + "}";
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
