using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.inventory_changed
{
    public partial class inventory_changed_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public inventory_changed_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItems;
            set_item.Click += UpdateInfo;

            set_empty.Click += ClickSound;
            set_empty.Click += SetTag;

            set_full.Click += ClickSound;
            set_full.Click += SetTag;

            set_occupied.Click += ClickSound;
            set_occupied.Click += SetTag;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string SlotInfo = "";
                SlotInfo = (set_empty.Tag != null ?set_empty.Tag.ToString(): "")+ (set_full.Tag != null ? set_full.Tag.ToString() : "")+ (set_occupied.Tag != null ? set_occupied.Tag.ToString() : "");

                if (SlotInfo.Trim() != "")
                    SlotInfo = "slots:{"+SlotInfo.TrimEnd(',')+"},";

                string result = set_player.Tag.ToString()+(set_item.Tag != null?",\"items\":"+"["+set_item.Tag.ToString()+"]":"")+(SlotInfo.Trim() != ""? ","+SlotInfo : "");
                table.Parent.Tag = "\"conditions\":{"+result+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void SetTag(object sender,EventArgs e)
        {
            Button this_obj = sender as Button;
            string CurrentKey = this_obj.Name.Split('_')[1];

            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":{\"min\":" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "},";
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":"+min_value_box.Value+",";
            else
                if(max_value_box.Value != -1)
                this_obj.Tag = "\"" + CurrentKey + "\":" + max_value_box.Value+",";
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
