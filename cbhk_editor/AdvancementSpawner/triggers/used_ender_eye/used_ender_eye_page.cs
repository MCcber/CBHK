using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.used_ender_eye
{
    public partial class used_ender_eye_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public used_ender_eye_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            min_value_box.KeyPress += ControlInput;
            max_value_box.KeyPress += ControlInput;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_distance.Tag != null?","+set_distance.Tag.ToString():"");
                table.Parent.Tag = "\"conditions\":{" + result + "}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void set_distance_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            if (min_value_box.Text.Trim() != "" && max_value_box.Text.Trim() != "")
                this_obj.Tag = "\"distance\":{\"min\":" + min_value_box.Text + ",\"max\":" + max_value_box.Text + "}";
            else
                if (min_value_box.Text.Trim() != "")
                this_obj.Tag = "\"distance\":" + min_value_box.Text;
            else
                if (max_value_box.Text.Trim() != "")
                this_obj.Tag = "\"distance\":" + max_value_box.Text;
            else
                this_obj.Tag = null;

            UpdateInfo(null,null);
        }

        private void ControlInput(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }
    }
}
