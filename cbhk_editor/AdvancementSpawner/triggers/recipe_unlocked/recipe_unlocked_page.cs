using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.recipe_unlocked
{
    public partial class recipe_unlocked_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public recipe_unlocked_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            recipe_box.TextChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{"+set_player.Tag.ToString()+(recipe_box.Text.Trim() != ""? ",\"recipe\":" + recipe_box.Text.Trim():"")+"}";
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
