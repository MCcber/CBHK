using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.copy_nbt
{
    public partial class copy_nbt_form : Form
    {
        public string result = "";
        public copy_nbt_form()
        {
            InitializeComponent();
            add_Click(null,null);
        }

        private void add_Click(object sender, EventArgs e)
        {
            ops_page op = new ops_page();
            ops_tab.TabPages.Add(op.ops_tab.SelectedTab);
            ops_tab.SelectedIndex = ops_tab.TabPages.Count - 1;
            ops_tab.SelectedTab.Text = ops_tab.TabPages.Count+"";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ops_tab.TabPages.RemoveAt(ops_tab.SelectedIndex);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ops_tab.TabPages.Clear();
        }

        private void copy_nbt_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                #region 合并复制源数据
                string sourceInfo = ",\"source\":\""+ Regex.Match(source_box.Text.Trim(),@"[A-z]+").ToString()+"\"";
                #endregion

                #region 合并复制操作数据
                string opsInfo = ",\"ops\":[";
                foreach (TabPage item in ops_tab.TabPages)
                {
                    if(item.Tag != null)
                    opsInfo += item.Tag.ToString();
                }
                if (opsInfo != "\"ops\":[")
                    opsInfo = opsInfo.TrimEnd(',') + "]";
                else
                    opsInfo = "";
                #endregion

                #region 合并最终结果
                result = "{\"function\":\"minecraft:copy_nbt\"" + sourceInfo + opsInfo +"},";
                DialogResult = DialogResult.OK;
                #endregion
            }
        }
    }
}
