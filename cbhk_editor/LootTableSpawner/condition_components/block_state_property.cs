using cbhk_editor.MainForm;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class block_state_property : UserControl
    {
        TreeView blocks = Cbhk_form.Blocks;
        string history_block = "";
        public block_state_property()
        {
            InitializeComponent();
            InitUISettings();
        }

        private void InitUISettings()
        {
            block_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            block_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode a_block in blocks.Nodes)
            {
                block_id.Items.Add(a_block.Text);
                block_id.AutoCompleteCustomSource.Add(a_block.Text.Replace("minecraft:",""));
            }
        }

        private void update_Click(object sender, System.EventArgs e)
        {
            block_id.Text = block_id.Text.Trim();
            int block_index = block_id.FindStringExact(block_id.Text.Trim());
            if (block_index != -1 && history_block.Trim() != block_id.Text)
            {
                block_id.Select(block_id.Text.Length,0);
                table.Parent.Tag = null;
                history_block = block_id.Text;

                bool NotNeedProperty = true;
                if(property_box.Controls.Count > 0)
                foreach (Control item in property_box.Controls)
                {
                    if (item.Tag != null)
                    {
                        NotNeedProperty = false;
                        break;
                    }
                }

                    foreach (TreeNode item in blocks.Nodes[block_index].Nodes)
                    {

                        if (item.Text == "properties")
                        {
                            #region 处理属性
                            foreach (TreeNode a_property in item.Nodes)
                            {
                                if (property_box.Controls.Find(a_property.Text, true).Length != 0)
                                    continue;
                                //属性设置按钮
                                Button property_btn = new Button()
                                {
                                    Name = a_property.Text,
                                    Text = a_property.Text,
                                    Dock = DockStyle.Top
                                };

                                #region 属性设置框
                                List<string> property_items = new List<string> { };
                                property_items.AddRange(a_property.Nodes[0].Text.Replace("[", "").Replace("]", "").Split(','));
                                for (int i = 0; i < property_items.Count; i++)
                                {
                                    property_items[i] = property_items[i].Replace("\"", "").Trim();
                                }
                                ComboBox property_set_box = new ComboBox()
                                {
                                    Size = property_btn.Size,
                                    Location = property_btn.Location,
                                    BackColor = Color.FromArgb(50, 50, 50),
                                    ForeColor = Color.White
                                };
                                //绑定数据键入
                                property_set_box.KeyDown += (a, b) =>
                                {
                                    if (b.KeyCode == Keys.Escape)
                                        property_box.Controls.Remove(property_set_box);
                                    else
                                    if (b.KeyCode == Keys.Enter)
                                    {
                                        property_btn.Tag = property_set_box.Text.Trim();

                                        #region 为当前条件合并数据
                                        //合并所有属性数据
                                        string ele = "";
                                        foreach (Control a_property_btn in property_box.Controls)
                                        {
                                            if (a_property_btn is Button && a_property_btn.Tag != null && a_property_btn.Tag.ToString().Trim() != "")
                                            {
                                                bool double_quotation_marks = Regex.Match(a_property_btn.Tag.ToString(), @"\d+").Success;
                                                double_quotation_marks = !a_property_btn.Tag.ToString().Contains("false") || !a_property_btn.Tag.ToString().Contains("true");

                                                ele += "\"" + a_property_btn.Text + "\":" + (!double_quotation_marks ? "\"" + a_property_btn.Tag.ToString() + "\"," : a_property_btn.Tag.ToString() + ",");
                                            }
                                        }
                                        ele = ele.TrimEnd(',');
                                        string block_state_property_string = "{\"condition\":\"minecraft:block_state_property\",\"block\":\"" + block_id.Text + "\",\"properties\":{" + ele + "}},";
                                        //当前条件页
                                        table.Parent.Tag = block_state_property_string;
                                        #endregion
                                        property_box.Controls.Remove(property_set_box);
                                    }
                                    else
                                        b.Handled = true;
                                };
                                //失去焦点则删除
                                property_set_box.LostFocus += (c, d) => { property_box.Controls.Remove(property_set_box); };
                                //添加成员
                                property_set_box.Items.AddRange(property_items.ToArray());
                                #endregion

                                //按钮点击事件
                                property_btn.Click += (f, g) =>
                                {
                                    property_box.Controls.Add(property_set_box);
                                    property_set_box.BringToFront();
                                };
                                property_box.Controls.Add(property_btn);
                            }
                            #endregion
                        }
                    }

                    if(NotNeedProperty)
                    table.Parent.Tag = "{\"condition\":\"minecraft:block_state_property\",\"block\":\"" + block_id.Text.Trim() + "\"},";

            }
            else
                if (block_index == -1)
                property_box.Controls.Clear();
        }

        private void block_id_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!block_id.Text.Contains("minecraft:"))
                {
                    block_id.Text = "minecraft:" + block_id.Text.Trim();
                    block_id.Select(block_id.Text.Length,0);
                }
            }
        }

        private void block_id_TextChanged(object sender, System.EventArgs e)
        {
                update_Click(null, null);
        }
    }
}
