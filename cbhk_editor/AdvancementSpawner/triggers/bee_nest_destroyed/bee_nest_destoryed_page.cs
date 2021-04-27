using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.bee_nest_destroyed
{
    public partial class bee_nest_destoryed_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath+ "\\MainFormClickSounds\\button_click.wav");
        public bee_nest_destoryed_page()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            set_item.Click += ClickSound;
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_item.Click += SetInfo.SetItem;

            set_item.Click += UpdateInfo;
            set_player.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (set_player.Tag != null && id_box.Text.Trim() != "")
            {
                table.Parent.Tag = "\"conditions\":{\"block\":\""+id_box.Text.Trim()+ "\",\"num_bees_inside\":"+bees_count_box.Value+(set_item.Tag != null?","+set_item.Tag.ToString():"")+(set_player.Tag != null?","+set_player.Tag.ToString():"")+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bees_count_box_ValueChanged(object sender, EventArgs e)
        {
            UpdateInfo(null,null);
        }

        private void id_box_TextChanged(object sender, EventArgs e)
        {
            UpdateInfo(null, null);
        }
    }
}
