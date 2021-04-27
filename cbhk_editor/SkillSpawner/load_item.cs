using cbhk_editor.ItemSpawner;
using cbhk_editor.MainForm;
using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.SkillSpawner
{
    class Load_item
    {
        public static string ItemType { get; set; }
        public static string NBT { get; set; }
        public static void Modify(object sender,EventArgs e)
        {
            Control this_obj = sender as Control;
            SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + "\\MainFormClickSounds\\button_click.wav");
            TreeView Root = Cbhk_form.register;
            Item_spawner Is = new Item_spawner(null, soundPlayer, true);
            if (Is.ShowDialog() == DialogResult.OK)
            {
                NBT = Is.ItemNBTs[0];
                ItemType = Is.ItemIds[0];
                if (NBT.Trim() != "")
                    this_obj.Tag = NBT;
                else
                    this_obj.Tag = null;
                if (ItemType.Trim() != "")
                    this_obj.Name = ItemType.Replace(":",".");
            }
        }
    }
}
