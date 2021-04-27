using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_nbt : UserControl
    {
        public set_nbt()
        {
            InitializeComponent();

            nbt_box.GotFocus += (a,b) => 
            {
                if(nbt_box.ForeColor == Color.FromArgb(168,168,168))
                {
                    nbt_box.Text = "";
                    nbt_box.ForeColor = Color.White;
                }
            };
            nbt_box.LostFocus += (a,b) => 
            {
                if(nbt_box.Text.Trim() == "")
                {
                    nbt_box.Text = "设置NBT(请自行转义:1层起)";
                    nbt_box.ForeColor = Color.FromArgb(168, 168, 168);
                }
            };
        }

        private void nbt_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text.Trim() != "")
                this_obj.Parent.Tag = "{\"function\":\"minecraft:set_nbt\",\"tag\":\"{" + Regex.Match(this_obj.Text, @"(.*)").ToString() + "}\"},";
            else
                this_obj.Parent.Tag = null;
        }
    }
}
