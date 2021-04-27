using cbhk_editor.MainForm;
using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.function_components.SubComponents.set_attributes
{
    public partial class attribute_page : UserControl
    {
        public attribute_page()
        {
            InitializeComponent();

            name_box.TextChanged += UpdateInfo;
            id_box.TextChanged += UpdateInfo;
            operation_box.TextChanged += UpdateInfo;
            min_value_box.TextChanged += UpdateInfo;
            max_value_box.TextChanged += UpdateInfo;
            slot_box.SelectedIndexChanged += UpdateInfo;

            id_box.KeyPress += ControlInput;
            operation_box.KeyPress += ControlInput;

            min_value_box.KeyPress += InputFloat;
            max_value_box.KeyPress += InputFloat;

            TreeView Root = Cbhk_form.register;
            id_box.AutoCompleteMode = AutoCompleteMode.Suggest;
            id_box.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (TreeNode item in Root.Nodes)
            {
                if(item.Text == "minecraft:attribute")
                {
                    foreach (TreeNode entry in item.Nodes)
                    {
                        if(entry.Text == "entries")
                        {
                            foreach (TreeNode a_item in entry.Nodes)
                            {
                                id_box.Items.Add(a_item.Text);
                                id_box.AutoCompleteCustomSource.Add(a_item.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
            }
        }

        private void ControlInput(object sender,KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void InputFloat(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')   //允许输入回退键
            {
                TextBox tb = sender as TextBox;

                if (tb.Text == "")
                {
                    tb.Text = "0.";
                    tb.Select(tb.Text.Length, 0);
                    e.Handled = true;
                }
                else if (tb.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void UpdateInfo(object sender,EventArgs e)
        {
            if (id_box.Text.Trim() != "")
            {
                #region 合并属性名称
                string attributeNameInfo = "";
                if (name_box.Text.Trim() != "")
                    attributeNameInfo = "\"name\":"+name_box.Text.Trim();
                #endregion

                #region 合并属性数据
                string attributeIdInfo = "";
                if (id_box.Text.Trim() != "")
                    attributeIdInfo = ",\"attribute\":" + id_box.Text.Trim();
                #endregion

                #region 合并操作方式
                string operationInfo = "";
                if (operation_box.Text.Trim() != "")
                    operationInfo = ",\"operation\":"+operation_box.Text.Trim();
                #endregion

                #region 合并属性值
                string attributeValueInfo = "";
                if (min_value_box.Text.Trim() != "" && max_value_box.Text.Trim() != "")
                    attributeValueInfo = ",\"amount\":{\"min\":" + min_value_box.Text.Trim() + ",\"max\":" + max_value_box.Text.Trim() + "}";
                else
                    if (min_value_box.Text.Trim() != "")
                    attributeValueInfo = ",\"amount\":"+min_value_box.Text.Trim();
                if (max_value_box.Text.Trim() != "")
                    attributeValueInfo = ",\"amount\":" + max_value_box.Text.Trim();
                #endregion

                #region 合并槽位数据
                string SlotInfo = ",\"slot\":[";
                if (slot_box.Items.Count > 0)
                {
                    foreach (string item in slot_box.Items)
                    {
                        SlotInfo += "\""+item+"\",";
                    }
                    if (SlotInfo == ",\"slot\":[")
                        SlotInfo = SlotInfo.TrimEnd(',') + "]";
                    else
                        SlotInfo = "";
                }
                #endregion

                #region 合并最终结果
                if (attributeIdInfo.Trim() != "")
                    table.Parent.Tag = "{" + attributeNameInfo + attributeIdInfo + operationInfo + attributeValueInfo + SlotInfo + "},";
                else
                    table.Parent.Tag = null;
                #endregion
            }
            else
                table.Parent.Tag = null;
        }

        private void slot_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            this_obj.Items.RemoveAt(this_obj.SelectedIndex);
        }

        private void add_slot_Click(object sender, EventArgs e)
        {
            slot_box.Items.Add(slot_box.Text.Trim());
            slot_box.Text = "";
            UpdateInfo(null,null);
        }
    }
}
