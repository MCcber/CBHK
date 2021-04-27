using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.item_used_on_block
{
    public partial class item_used_on_block_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public item_used_on_block_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;

            set_block.Click += ClickSound;
            set_block.Click += SetInfo.SetLocation;
            set_block.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_item.Tag != null?","+set_item.Tag.ToString():"")+(set_block.Tag != null? ",\"location\":" + set_block.Tag.ToString():"");
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
