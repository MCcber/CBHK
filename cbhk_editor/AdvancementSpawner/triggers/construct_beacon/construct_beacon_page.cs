using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.construct_beacon
{
    public partial class construct_beacon_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public construct_beacon_page()
        {
            InitializeComponent();
            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;
        }

        private void set_player_Click(object sender, EventArgs e)
        {
            ClickSound(null,null);
            SetInfo.SetPlayer(sender, e);
            UpdateInfo(null,null);
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if(set_player.Tag != null)
            {
                string levelInfo = "";
                if (min_value_box.Value != -1 && max_value_box.Value != -1)
                    levelInfo = "\"level\":{\"min\":" + max_value_box.Value + ",\"max\":" + max_value_box.Value + "},";
                else
                    if (min_value_box.Value != -1)
                    levelInfo = "\"level\":" + min_value_box.Value + ",";
                else
                    if (max_value_box.Value != -1)
                    levelInfo = "\"level\":" + max_value_box.Value + ",";

                string result = levelInfo + set_player.Tag.ToString();
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
