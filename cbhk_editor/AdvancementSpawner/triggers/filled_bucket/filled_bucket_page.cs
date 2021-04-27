using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.filled_bucket
{
    public partial class filled_bucket_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public filled_bucket_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{"+set_player.Tag.ToString()+(set_item.Tag != null?","+set_item.Tag.ToString():"")+"}";
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
