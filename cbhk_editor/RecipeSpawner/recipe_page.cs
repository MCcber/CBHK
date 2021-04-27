using cbhk_editor.MainForm;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.RecipeSpawner
{
    public partial class recipe_page : UserControl
    {
        //需要给经验的槽位
        List<int> exp_index = new List<int> { 0,1,4,5 };
        //需要改变槽位编辑权限的索引
        List<int> change_index = new List<int> { 2,3 };
        public recipe_page()
        {
            InitializeComponent();
            recipe_type.SelectedIndex = 2;
            for (int i = 0; i < 8; i++)
            {
                value_tab ValueTab = new value_tab();
                recipe_value_tab.TabPages.Add(ValueTab.recipe_value_tab.SelectedTab);
                recipe_value_tab.SelectedIndex++;
                recipe_value_tab.SelectedTab.Text = "槽位:"+recipe_value_tab.TabPages.Count;
            }
            recipe_value_tab.SelectedIndex = 0;
            BackColor = Color.FromArgb(50, 50, 50);
            recipe_tab.SelectedTab.BackColor = recipe_value_tab.SelectedTab.BackColor = recipe_table.BackColor = recipe_content.BackColor = Color.FromArgb(50, 50, 50);
            foreach (Control item in recipe_table.Controls)
            {
                item.ForeColor = Color.FromArgb(255,255,255);
                item.BackColor = Color.FromArgb(50,50,50);
            }
            foreach (Control item in recipe_content.Controls)
            {
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.BackColor = Color.FromArgb(50, 50, 50);
            }
            foreach (Control item in recipe_value_tab.SelectedTab.Controls)
            {
                item.ForeColor = Color.FromArgb(255, 255, 255);
                item.BackColor = Color.FromArgb(50, 50, 50);
            }
            TreeView Root = Cbhk_form.register;
            recipe_result.AutoCompleteMode = AutoCompleteMode.Suggest;
            recipe_result.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:item")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if(subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                recipe_result.Items.Add(subsubitem.Text);
                                recipe_result.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void recipe_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void recipe_type_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if(change_index.FindIndex(obj=>this_obj.SelectedIndex == obj)!=-1)
            {
                foreach (Control item in recipe_content.Controls)
                    item.Enabled = true;
            }
            else
            {
                foreach (Control item in recipe_content.Controls)
                {
                    if(item.TabIndex!=0)
                    item.Enabled = false;
                }
            }

            if(exp_index.FindIndex(obj => this_obj.SelectedIndex == obj) != -1)
            {
                reward_xp.Enabled = firing_time.Enabled = true;
            }
            else
                reward_xp.Enabled = firing_time.Enabled = false;
        }
    }
}
