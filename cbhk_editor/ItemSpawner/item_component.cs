using cbhk_editor.MainForm;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace cbhk_editor.ItemSpawner
{
    public partial class item_component : UserControl
    {
        public item_component()
        {
            InitializeComponent();
            TreeView Root = Cbhk_form.register;
            item_id.AutoCompleteMode = enchantment_id.AutoCompleteMode = attribute_id.AutoCompleteMode = potion_id.AutoCompleteMode = AutoCompleteMode.Suggest;
            item_id.AutoCompleteSource = enchantment_id.AutoCompleteSource = attribute_id.AutoCompleteSource = potion_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (TreeNode item in Root.Nodes)
            {
                #region 写入物品补全数据
                if (item.Text == "minecraft:item")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if(subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                item_id.Items.Add(subsubitem.Text);
                                item_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:",""));
                            }
                        }
                    }
                }
                #endregion

                #region 写入附魔补全数据
                if (item.Text == "minecraft:enchantment")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                enchantment_id.Items.Add(subsubitem.Text);
                                enchantment_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion

                #region 写入属性补全数据
                if (item.Text == "minecraft:attribute")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            foreach (TreeNode subsubitem in subitem.Nodes)
                            {
                                attribute_id.Items.Add(subsubitem.Text.Replace("minecraft:generic.","").Replace("minecraft:",""));
                                attribute_id.AutoCompleteCustomSource.Add(subsubitem.Text.Replace("minecraft:", "").Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion

                #region 写入药水ID补全数据
                if (item.Text == "minecraft:mob_effect")
                {
                    foreach (TreeNode subitem in item.Nodes)
                    {
                        if (subitem.Text == "entries")
                        {
                            for (int i = 0; i < subitem.Nodes.Count; i++)
                            {
                                potion_id.Items.Add(subitem.Nodes[i].Text);
                                potion_id.AutoCompleteCustomSource.Add(subitem.Nodes[i].Text.Replace("minecraft:", ""));
                            }
                        }
                    }
                }
                #endregion
            }
        }

        private void click_to_spawn_uid_Click(object sender, EventArgs e)
        {
            item_uid.Text = UuidHelper.NewUuidString();
        }

        private void add_place_Click(object sender, EventArgs e)
        {
            if(can_place.Text.Trim()!="")
            can_place.Items.Add(can_place.Text);
        }

        private void add_destory_Click(object sender, EventArgs e)
        {
            if (can_destory.Text.Trim() != "")
                can_destory.Items.Add(can_destory.Text);
        }

        private void can_place_SelectedIndexChanged(object sender, EventArgs e)
        {
            can_place.Items.RemoveAt(can_place.Items.IndexOf(can_place.Text));
        }

        private void can_destory_SelectedIndexChanged(object sender, EventArgs e)
        {
            can_destory.Items.RemoveAt(can_destory.Items.IndexOf(can_destory.Text));
        }

        private void item_id_TextChanged(object sender, EventArgs e)
        {
            ComboBox this_obj = sender as ComboBox;
            if(this_obj.Text == "potion")
            {
                item_potion_tab.Enabled = true;
            }
            else
                item_potion_tab.Enabled = false;
        }
    }

    public static class UuidHelper
    {
        [DllImport("rpcrt4.dll", SetLastError = true)]
        private static extern int UuidCreateSequential(out Guid guid);

        /// <summary>
        /// 生成连续的UUID，底层调用了Windows API UuidCreateSequential。经测试发现，
        /// UuidCreateSequential，在多CPU并发状态下，有可能会产生重复数据，因此这个方法进行的并发控制，并延迟1毫秒。
        /// 另外，UuidCreateSequential的生成和网络连接有关（网卡），如果电脑上插了Windows Mobile的手机，会产生新的网络连接，
        /// 导致UuidCreateSequential出错，此时，这个方法将使用传统的Guid来替代Uuid。
        /// </summary>
        /// <returns>在本机生成连续的Guid</returns>
        public static Guid NewUuid()
        {
            Guid result;

            lock (typeof(UuidHelper))
            {
                int hr = UuidCreateSequential(out result);

                if (hr == 0)
                    result = Guid.NewGuid();

                Thread.Sleep(1);
            }

            return result;
        }

        /// <summary>
        /// 生成连续的UUID，底层调用了Windows API UuidCreateSequential
        /// </summary>
        /// <returns>在本机生成连续的Guid</returns>
        public static string NewUuidString()
        {
            Guid result = NewUuid();

            byte[] guidBytes = result.ToByteArray();

            for (int i = 0; i < 8; i++)
            {
                byte t = guidBytes[15 - i];
                guidBytes[15 - i] = guidBytes[i];
                guidBytes[i] = t;
            }

            return new Guid(guidBytes).ToString();
        }
    }
}
