using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.bred_animals
{
    public partial class bred_animals_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public bred_animals_page()
        {
            InitializeComponent();
            set_child.Click += ClickSound;
            set_parent.Click += ClickSound;
            set_partner.Click += ClickSound;
            set_player.Click += ClickSound;

            set_child.Click += SetInfo.SetEntity;
            set_parent.Click += SetInfo.SetEntity;
            set_partner.Click += SetInfo.SetEntity;
            set_player.Click += SetInfo.SetPlayer;

            set_child.Click += UpdateInfo;
            set_parent.Click += UpdateInfo;
            set_partner.Click += UpdateInfo;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = (set_child.Tag != null ? "\"child\":" + set_child.Tag.ToString()+"," : "")+(set_parent.Tag != null? "\"parent\":" + set_parent.Tag.ToString() + "," : "")+(set_partner.Tag != null ? "\"partner\":" + set_partner.Tag.ToString() + "," : "")+(set_player.Tag != null ? set_player.Tag.ToString() + "," : "");
                table.Parent.Tag = "\"conditions\":{" + result.TrimEnd(',') + "}";
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
