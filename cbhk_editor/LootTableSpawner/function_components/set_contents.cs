using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components
{
    public partial class set_contents : UserControl
    {
        public set_contents()
        {
            InitializeComponent();

            content_box.GotFocus += (a,b) => 
            {
                if (content_box.ForeColor == Color.FromArgb(168, 168, 168))
                {
                    content_box.Text = "";
                    content_box.ForeColor = Color.White;
                }
            };

            content_box.LostFocus += (a,b) => 
            {
                if(content_box.Text.Trim() == "")
                {
                    content_box.Text = "格式:{...},{...}";
                    content_box.ForeColor = Color.FromArgb(168,168,168);
                }
            };
        }

        private void content_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text.Trim() != "")
                table.Parent.Tag = "{\"function\":\"minecraft:set_contents\",\"entries\":[" + this_obj.Text.Trim() + "]},";
            else
                table.Parent.Tag = null;
        }
    }
}
