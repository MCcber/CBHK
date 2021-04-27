using cbhk_editor.MainForm;
using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.AdvancementSpawner.triggers.target_hit
{
    public partial class target_hit_page : UserControl
    {
        SoundPlayer click_sound = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
        public target_hit_page()
        {
            InitializeComponent();
            set_player.Click += ClickSound;
            set_player.Click += SetInfo.SetPlayer;
            set_player.Click += UpdateInfo;

            set_shooter.Click += ClickSound;
            set_shooter.Click += SetInfo.SetEntity;
            set_shooter.Click += UpdateInfo;

            TreeView Root = Cbhk_form.register;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:entity_type")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode subitem in entry.Nodes)
                            {
                                set_projectile.Items.Add(subitem.Text);
                                set_projectile.AutoCompleteCustomSource.Add(subitem.Text);
                            }
                        }
                    }
                }
            }
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (set_player.Tag != null)
            {
                string result = set_player.Tag.ToString()+(set_projectile.Text.Trim() != ""? ",\"projectile\":\"" + set_projectile.Text.Trim()+"\"":"")+(set_shooter.Tag != null? ",\"shooter\":" + set_shooter.Tag.ToString(): "")+(signal_strength_box.Value != -1? ",\"signal_strength\":"+ signal_strength_box.Value : "");
                table.Parent.Tag = "\"conditions\":{"+result+"}";
            }
            else
                table.Parent.Tag = null;
        }

        private void ClickSound(object sender, EventArgs e)
        {
            click_sound.Play();
        }

        private void signal_strength_box_ValueChanged(object sender, EventArgs e)
        {
            UpdateInfo(null,null);
        }
    }
}
