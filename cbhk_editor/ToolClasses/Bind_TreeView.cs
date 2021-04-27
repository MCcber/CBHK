using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace cbhk_editor.ToolClasses
{
    class Bind_TreeView
    {
        /// <summary>
        /// 绑定树形控件
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="strJson"></param>
        public void BindTreeView(TreeNode treeView, string strJson)
        {
            if (IsJOjbect(strJson))
            {
                JObject jo = (JObject)JsonConvert.DeserializeObject(strJson);

                foreach (var item in jo)
                {
                    TreeNode tree;
                    if (item.Value.GetType() == typeof(JObject))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                    else if (item.Value.GetType() == typeof(JArray))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                    else
                    {
                        tree = new TreeNode(item.Key + ":" + item.Value.ToString());
                        treeView.Nodes.Add(tree);
                    }
                }
            }
            if (IsJArray(strJson))
            {
                JArray ja = (JArray)JsonConvert.DeserializeObject(strJson);
                int i = 0;
                foreach (JObject item in ja)
                {
                    TreeNode tree = new TreeNode();
                    foreach (var itemOb in item)
                    {
                        TreeNode treeOb;
                        if (itemOb.Value.GetType() == typeof(JObject))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            treeView.Nodes.Add(treeOb);

                        }
                        else if (itemOb.Value.GetType() == typeof(JArray))
                        {
                            treeOb = new TreeNode(itemOb.Key);
                            AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                            treeView.Nodes.Add(treeOb);
                        }
                        else
                        {
                            treeOb = new TreeNode(itemOb.Key + ":" + itemOb.Value.ToString());
                            treeView.Nodes.Add(treeOb);
                        }
                    }
                    treeView.Nodes.Add(tree);
                }
            }
            treeView.ExpandAll();
        }
        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="parantNode"></param>
        /// <param name="value"></param>
        public void AddTreeChildNode(ref TreeNode parantNode, string value)
        {
            if (IsJOjbect(value))
            {
                JObject jo = (JObject)JsonConvert.DeserializeObject(value);
                foreach (var item in jo)
                {
                    TreeNode tree;
                    if (item.Value.GetType() == typeof(JObject))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                    else if (item.Value.GetType() == typeof(JArray))
                    {
                        tree = new TreeNode(item.Key);
                        AddTreeChildNode(ref tree, item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                    else
                    {
                        tree = new TreeNode(item.Key + ":" + item.Value.ToString());
                        parantNode.Nodes.Add(tree);
                    }
                }
            }
            try
            {
                if (IsJArray(value))
                {
                    JArray ja = (JArray)JsonConvert.DeserializeObject(value);
                    int i = 0;
                    foreach (JObject item in ja)
                    {
                        TreeNode tree = new TreeNode();
                        parantNode.Nodes.Add(tree);
                        foreach (var itemOb in item)
                        {
                            TreeNode treeOb;
                            if (itemOb.Value.GetType() == typeof(JObject))
                            {
                                treeOb = new TreeNode(itemOb.Key);
                                AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                                tree.Nodes.Add(treeOb);

                            }
                            else if (itemOb.Value.GetType() == typeof(JArray))
                            {
                                treeOb = new TreeNode(itemOb.Key);
                                AddTreeChildNode(ref treeOb, itemOb.Value.ToString());
                                tree.Nodes.Add(treeOb);
                            }
                            else
                            {
                                treeOb = new TreeNode(itemOb.Key + ":" + itemOb.Value.ToString());
                                tree.Nodes.Add(treeOb);
                            }
                        }
                    }
                }
            }
            catch
            {
                parantNode.Nodes.Add(new TreeNode() { Text = value });
                return;
            }
        }
        /// <summary>
        ///  判断是否JOjbect类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsJOjbect(string value)
        {
            try
            {
                JObject ja = JObject.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判断是否JArray类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsJArray(string value)
        {
            try
            {
                JArray ja = JArray.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
