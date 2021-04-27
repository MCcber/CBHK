using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.brewed_potion
{
    public partial class brewed_potion_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public brewed_potion_page()
        {
            InitializeComponent();
        }

        private void set_player_Click(object sender, EventArgs e)
        {
            ClickSound(null,null);
            SetInfo.SetPlayer(sender,e);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"condition\":{"+set_player.Tag.ToString()+(potion_id.Text.Trim() != ""? ",\"potion\":\"" + potion_id.Text.Trim() + "\"":"")+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void potion_id_TextChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
    }
}
