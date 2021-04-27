using System;
using System.Windows.Forms;

namespace cbhk_editor.TagSpawner
{
    public partial class Tag_page : UserControl
    {
        public Tag_page(TreeView register)
        {
            InitializeComponent();
            foreach (TreeNode node_type in register.Nodes)
            {
                if(node_type.Text == "minecraft:entity_type")
                {
                    foreach (TreeNode entry in node_type.Nodes)
                    {
                        if(entry.Text.Contains("entries"))
                        {
                            foreach (TreeNode item in entry.Nodes)
                            {
                                id_list_box.Items.Add(item.Text,false);
                            }
                            break;
                        }
                    }
                }
                if(node_type.Text == "minecraft:item")
                {
                    foreach (TreeNode entry in node_type.Nodes)
                    {
                        if (entry.Text.Contains("entries"))
                        {
                            foreach (TreeNode item in entry.Nodes)
                            {
                                id_list_box.Items.Add(item.Text, false);
                            }
                            break;
                        }
                    }
                }
            }
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (this_obj.Text != "")
            {
                id_list_box.SelectedIndex = id_list_box.FindString("minecraft:" + this_obj.Text);
            }
            else
            {
                id_list_box.SelectedIndex = 0;
            }
        }

        private void Select_all_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < id_list_box.Items.Count; i++)
            {
                id_list_box.SetItemChecked(i,true);
            }
        }

        private void Reverse_select_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < id_list_box.Items.Count; i++)
            {
                if(id_list_box.GetItemChecked(i))
                id_list_box.SetItemChecked(i, false);
                else
                    id_list_box.SetItemChecked(i, true);
            }
        }
    }
}
