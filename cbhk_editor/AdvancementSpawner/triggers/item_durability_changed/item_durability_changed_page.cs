using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.item_durability_changed
{
    public partial class item_durability_changed_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public item_durability_changed_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;

            set_delta.Click += ClickSound;
            set_delta.Click += SetTag;
            set_delta.Click += UpdateInfo;

            set_durability.Click += ClickSound;
            set_durability.Click += SetTag;
            set_durability.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_item.Tag != null?","+set_item.Tag.ToString():"")+(set_delta.Tag != null?","+set_delta.Tag.ToString():"")+ (set_durability.Tag != null ? set_durability.Tag.ToString() : "");
                table.Parent.Tag = "\"conditions\":{"+result.TrimEnd(',')+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void SetTag(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            string CurrentKey = this_obj.Name.Split('_')[1];

            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "},";
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":" + min_value_box.Value + ",";
            else
                if (max_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":" + max_value_box.Value + ",";
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
