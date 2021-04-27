using cbhk_editor.AdvancementSpawner.triggers.tool_forms;
using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.placed_block
{
    public partial class placed_block_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public placed_block_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_location.Click += ClickSound;
            set_location.Click += SetInfo.SetLocation;
            set_location.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_location.Tag != null?",\"location\":"+set_location.Tag.ToString():"")+(set_item.Tag != null?","+set_item.Tag.ToString():"")+(set_block.Tag != null?",\"block\":"+set_block.Tag.ToString():"");

                table.Parent.Tag = "\"conditions\":{" + result + "}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void set_block_Click(object sender, EventArgs e)
        {
            Button this_obj = sender as Button;
            ClickSound(null,null);
            block_form bf = new block_form();
            if (bf.ShowDialog() == DialogResult.OK && bf.Tag != null)
            {
                bf.Tag = bf.Tag.ToString().Replace("{\"condition\":\"minecraft:block_state_property\",", "").Replace("},", "");
                this_obj.Tag = bf.Tag;
            }
            else
                this_obj.Tag = null;

            UpdateInfo(null,null);
        }
    }
}
