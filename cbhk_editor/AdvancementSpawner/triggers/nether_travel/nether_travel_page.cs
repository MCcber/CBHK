using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.nether_travel
{
    public partial class nether_travel_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public nether_travel_page()
        {
            InitializeComponent();
            set_absolute.Click += ClickSound;
            set_absolute.Click += SetTag;
            set_absolute.Click += UpdateInfo;

            set_horizontal.Click += ClickSound;
            set_horizontal.Click += SetTag;
            set_horizontal.Click += UpdateInfo;

            set_x.Click += ClickSound;
            set_x.Click += SetTag;
            set_x.Click += UpdateInfo;

            set_y.Click += ClickSound;
            set_y.Click += SetTag;
            set_y.Click += UpdateInfo;

            set_z.Click += ClickSound;
            set_z.Click += SetTag;
            set_z.Click += UpdateInfo;

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString();
                string distanceInfo = (set_absolute.Tag != null ? set_absolute.Tag.ToString() : "") + (set_horizontal.Tag != null ? set_horizontal.Tag.ToString() : "") + (set_x.Tag != null ? set_x.Tag.ToString() : "") + (set_y.Tag != null ? set_y.Tag.ToString() : "") + (set_z.Tag != null ? set_z.Tag.ToString(): "");

                if (distanceInfo.Trim() != "")
                    distanceInfo = ",\"distance\":{"+distanceInfo.TrimEnd(',')+"}";

                result += distanceInfo;

                table.Parent.Tag = "\"conditions\":{" + result + "}";
            }
            else
                table.Parent.Tag = null;
        }

        private void SetTag(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            string value_type = this_obj.Name.Split('_')[1];
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                this_obj.Tag = "\"" + value_type + "\":{\"min\"" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "},";
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"" + value_type + "\":" + min_value_box.Value + ",";
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"" + value_type + "\":" + max_value_box.Value + ",";
            else
                this_obj.Tag = null;

            UpdateInfo(null, null);
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
