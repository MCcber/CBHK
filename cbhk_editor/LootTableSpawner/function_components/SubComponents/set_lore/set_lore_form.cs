using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_lore
{
    public partial class set_lore_form : Form
    {
        public string result = "";
        public set_lore_form()
        {
            InitializeComponent();
            add_Click(null,null);
        }

        private void set_lore_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region 合并描述数据
            foreach (TabPage page in lore_tab.TabPages)
            {
                if (page.Tag != null)
                    result += page.Tag.ToString();
            }
            if (result.Trim() != "")
                result = ",\"lore\":[" + result.TrimEnd(',') + "]";
            else
                result = "";
            DialogResult = DialogResult.OK;
            #endregion
        }

        private void add_Click(object sender, EventArgs e)
        {
            set_lore_page slp = new set_lore_page();
            lore_tab.TabPages.Add(slp.lore_tab.SelectedTab);
            lore_tab.SelectedIndex = lore_tab.TabPages.Count - 1;
            lore_tab.SelectedTab.Text = lore_tab.TabPages.Count + "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            lore_tab.TabPages.RemoveAt(lore_tab.SelectedIndex);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lore_tab.TabPages.Clear();
        }
    }
}
