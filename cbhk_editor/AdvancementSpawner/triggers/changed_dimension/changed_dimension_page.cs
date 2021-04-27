using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.changed_dimension
{
    public partial class changed_dimension_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public changed_dimension_page()
        {
            InitializeComponent();
            from_box.KeyPress += ControlInput;
            to_box.KeyPress += ControlInput;

            from_box.TextChanged += UpdateInfo;
            to_box.TextChanged += UpdateInfo;
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (set_player.Tag != null)
            {
                table.Parent.Tag = "\"conditions\":{"+set_player.Tag.ToString()+(from_box.Text.Trim() != ""?",\"from\":\""+from_box.Text.Trim()+"\"":"")+(to_box.Text.Trim() != ""?",\"to\":\""+to_box.Text.Trim()+"\"":"")+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void ControlInput(object sender,KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void set_player_Click(object sender, EventArgs e)
        {
            ClickSound(null,null);
            SetInfo.SetPlayer(sender,e);
            UpdateInfo(null,null);
        }
    }
}
