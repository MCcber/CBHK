using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.FireWorkSpawner
{
    public partial class firework_page : UserControl
    {
        SoundPlayer click;
        List<string> color_array = new List<string> { "black1973019", "red11743532", "green3887386", "brown5320730", "blue2437522", "purple8073150", "cyan2651799", "light_gray11250603", "gray4408131", "pink14188952", "lime4312372", "yellow14602026", "light_blue6719955", "magenta12801229", "orange15435844", "white15790320" };

        public firework_page(SoundPlayer soundPlayer)
        {
            InitializeComponent();
            shape_box.SetItemChecked(0,true);
            click = soundPlayer;
            color_list.KeyPress += CanNotInput;
            fade_color_list.KeyPress += CanNotInput;
            duration_box.KeyPress += CanNotInput;
            foreach (string item in color_array)
            {
                color_box.Items.Add(item);
            }
            foreach (Control item in firework_color_area.Controls)
            {
                if(item is Button)
                {
                    Button this_obj = item as Button;
                    this_obj.Click += ClickSound;
                }
            }
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click.Play();
        }

        private void shape_box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox this_obj = sender as CheckedListBox;
            if (this_obj.CheckedItems.Count > 0)
            {
                for (int i = 0; i < this_obj.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        this_obj.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
        }

        private void select_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < color_box.Items.Count; i++)
            {
                color_box.SetItemChecked(i,true);
            }
        }

        private void reverse_select_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < color_box.Items.Count; i++)
            {
                if(color_box.GetItemChecked(i))
                color_box.SetItemChecked(i, false);
                else
                    color_box.SetItemChecked(i, true);
            }
        }

        private void add_to_color_Click(object sender, EventArgs e)
        {
            foreach (string item in color_box.CheckedItems)
            {
                if (color_list.FindString(item) == -1)
                    color_list.Items.Add(Regex.Match(item,@"\d+").ToString());
            }
        }

        private void add_to_fade_color_Click(object sender, EventArgs e)
        {
            foreach (string item in color_box.CheckedItems)
            {
                if (fade_color_list.FindString(item) == -1)
                    fade_color_list.Items.Add(Regex.Match(item, @"\d+").ToString());
            }
        }

        private void random_color_CheckedChanged(object sender, EventArgs e)
        {
            color_count.Enabled = (sender as CheckBox).Checked;
        }

        private void random_fade_color_CheckedChanged(object sender, EventArgs e)
        {
            fade_color_count.Enabled = (sender as CheckBox).Checked;
        }

        private void color_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            this_obj.Items.RemoveAt(this_obj.SelectedIndex);
        }

        private void fade_color_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            this_obj.Items.RemoveAt(this_obj.SelectedIndex);
        }

        private void random_shape_Click(object sender, EventArgs e)
        {
            click.Play();
            Random random = new Random();
            shape_box.SetItemChecked(random.Next(0, shape_box.Items.Count - 1), true);
        }

        private void random_trajectory_Click(object sender, EventArgs e)
        {
            click.Play();
            Random random = new Random();
            twinkle.Checked = Procrastination.Checked = false;
            int select_index = random.Next(0, 2);
            if (select_index == 0)
                twinkle.Checked = true;
            else
                Procrastination.Checked = true;
        }

        private void random_duration_Click(object sender, EventArgs e)
        {
            click.Play();
            Random random = new Random();
            duration_box.SelectedIndex = random.Next(0,duration_box.Items.Count);
        }

        private void shotAtAngle_box_CheckedChanged(object sender, EventArgs e)
        {
            summon_model.Checked = (sender as CheckBox).Checked;
            summon_model.Enabled = !summon_model.Checked;
        }

        private void CanNotInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
