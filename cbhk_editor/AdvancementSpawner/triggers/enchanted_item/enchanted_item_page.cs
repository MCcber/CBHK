using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.enchanted_item
{
    public partial class enchanted_item_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public enchanted_item_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;

            min_value_box.ValueChanged += UpdateInfo;
            max_value_box.ValueChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = "";
                string levelInfo = "";
                if (min_value_box.Value != -1 && max_value_box.Value != -1)
                    levelInfo = ",\"levels\":{\"min\":" + max_value_box.Value + ",\"max\":" + max_value_box.Value + "}";
                else
                    if (min_value_box.Value != -1)
                    levelInfo = ",\"levels\":" + min_value_box.Value;
                else
                    if (max_value_box.Value != -1)
                    levelInfo = ",\"levels\":"+max_value_box.Value;

                result = set_player.Tag.ToString()+(set_item.Tag != null?","+set_item.Tag.ToString():"")+levelInfo;

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
