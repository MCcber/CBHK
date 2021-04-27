using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.killed_by_crossbow
{
    public partial class killed_by_crossbow_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public killed_by_crossbow_page()
        {
            InitializeComponent();

            set_entity.Click += ClickSound;
            set_entity.Click += SetInfo.SetEntities;
            set_entity.Click += UpdateInfo;

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_entity.Tag != null? ",\"victims\":["+set_entity.Tag.ToString()+"]" : "")+(set_unique_entity_types.Tag != null?","+set_unique_entity_types.Tag.ToString():"");
                table.Parent.Tag = "\"conditions\":{"+result+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void set_unique_entity_types_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (min_value_box.Value != -1 && max_value_box.Value != -1)
                this_obj.Tag = "\"unique_entity_types\":{\"min\"" + min_value_box.Value + ",\"max\":" + max_value_box.Value + "}";
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"unique_entity_types\":" + min_value_box.Value;
            else
                if (min_value_box.Value != -1)
                this_obj.Tag = "\"unique_entity_types\":" + max_value_box.Value;
            else
                this_obj.Tag = null;

            UpdateInfo(null,null);
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }
    }
}
