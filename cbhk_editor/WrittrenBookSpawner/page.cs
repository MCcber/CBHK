using System;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.WrittrenBookSpawner
{
    public partial class page : UserControl
    {
        public page()
        {
            InitializeComponent();
            display_box.ForeColor = Color.FromArgb(168,168,168);
            insert_box.ForeColor = Color.FromArgb(168, 168, 168);
            display_box.GotFocus += TextBoxGotFocus;
            display_box.LostFocus += TextBoxLostFocus;
            insert_box.GotFocus += TextBoxGotFocus;
            insert_box.LostFocus += TextBoxLostFocus;
            page_area.BackColor = Color.FromArgb(50,50,50);
            sentence_area.BackColor = Color.FromArgb(50,50,50);
            foreach (TabPage item in sentence_property_tab.TabPages)
            {
                item.BackColor = Color.FromArgb(50,50,50);
                foreach (Control subitem in item.Controls)
                {
                    if(subitem is TableLayoutPanel)
                    {
                        foreach (Control table_item in subitem.Controls)
                        {
                            table_item.BackColor = Color.FromArgb(50, 50, 50);
                        }
                    }
                    subitem.BackColor = Color.FromArgb(50,50,50);
                }
            }
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.ForeColor == Color.FromArgb(168, 168, 168))
            {
                this_obj.Text = "";
                this_obj.ForeColor = Color.White;
            }
        }

        private void TextBoxLostFocus(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text.Trim() == "")
            {
                this_obj.Text = "值";
                this_obj.ForeColor = Color.FromArgb(168, 168, 168);
            }
        }

        private void Font_color_box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox this_obj = sender as CheckedListBox;
            foreach (int nIndex in this_obj.CheckedIndices)
            {
                if (nIndex != e.Index)
                    this_obj.SetItemCheckState(nIndex, CheckState.Unchecked);
            }
        }

        private void Suggest_btn_Click(object sender, EventArgs e)
        {
            command_box.Enabled = true;
            url_box.Enabled = page_index.Enabled = false;
        }

        private void Run_btn_Click(object sender,EventArgs e)
        {
            command_box.Enabled = true;
            url_box.Enabled = page_index.Enabled = false;
        }

        private void Open_url_Click(object sender, EventArgs e)
        {
            url_box.Enabled = true;
            command_box.Enabled = page_index.Enabled = false;
        }

        private void Change_page_Click(object sender, EventArgs e)
        {
            page_index.Enabled = true;
            command_box.Enabled = url_box.Enabled = false;
        }
    }
}
