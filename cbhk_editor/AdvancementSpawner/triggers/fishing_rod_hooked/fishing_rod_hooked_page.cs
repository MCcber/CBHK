using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.fishing_rod_hooked
{
    public partial class fishing_rod_hooked_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public fishing_rod_hooked_page()
        {
            InitializeComponent();

            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_item.Click += ClickSound;
            set_item.Click += SetInfo.SetItem;
            set_item.Click += UpdateInfo;

            set_rod.Click += ClickSound;
            set_rod.Click += SetInfo.SetItem;
            set_rod.Click += UpdateInfo;

            set_entity.Click += ClickSound;
            set_entity.Click += SetInfo.SetEntity;
            set_entity.Click += UpdateInfo;
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_entity.Tag != null?",\"entity\":"+set_entity.Tag.ToString():"")+(set_item.Tag != null?","+set_item.Tag.ToString():"")+ (set_rod.Tag != null ? "," + set_rod.Tag.ToString().Remove(1,4).Insert(1,"rod") : "");
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
