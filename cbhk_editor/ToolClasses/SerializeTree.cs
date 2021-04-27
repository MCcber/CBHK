using System;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace cbhk_editor.ToolClasses
{
    class SerializeTree
    {
        /// <summary>   
        /// TreeView串行化类   
        /// </summary>   
        public class TreeViewDataAccess
        {
            //public TreeViewDataAccess() { }

            /// <summary>   
            /// TreeViewData   
            /// </summary>   
            [Serializable()]
            public struct TreeViewData
            {
                public TreeNodeData[] Nodes;

                /// <summary>   
                /// 递归初始化TreeView数据   
                /// </summary>   
                /// <param name="treeview"></param>   
                public TreeViewData(TreeView treeview)
                {
                    Nodes = new TreeNodeData[treeview.Nodes.Count];
                    if (treeview.Nodes.Count == 0)
                    {
                        return;
                    }
                    for (int i = 0; i <= treeview.Nodes.Count - 1; i++)
                    {
                        Nodes[i] = new TreeNodeData(treeview.Nodes[i]);
                    }
                }

                /// <summary>   
                /// 通过TreeViewData弹出TreeView   
                /// </summary>   
                /// <param name="treeview"></param>   
                public void PopulateTree(TreeView treeview)
                {
                    if (this.Nodes == null || this.Nodes.Length == 0)
                    {
                        return;
                    }
                    treeview.BeginUpdate();
                    for (int i = 0; i <= this.Nodes.Length - 1; i++)
                    {
                        treeview.Nodes.Add(this.Nodes[i].ToTreeNode());
                    }
                    treeview.EndUpdate();
                }
            }

            /// <summary>   
            /// TreeNodeData   
            /// </summary>   
            [Serializable()]
            public struct TreeNodeData
            {
                public string Text;
                public int ImageIndex;
                public int SelectedImageIndex;
                public bool Checked;
                public bool Expanded;
                public object Tag;
                public TreeNodeData[] Nodes;

                /// <summary>   
                /// TreeNode构造函数   
                /// </summary>   
                /// <param name="node"></param>   
                public TreeNodeData(TreeNode node)
                {
                    this.Text = node.Text;
                    this.ImageIndex = node.ImageIndex;
                    this.SelectedImageIndex = node.SelectedImageIndex;
                    this.Checked = node.Checked;
                    this.Expanded = node.IsExpanded;
                    this.Nodes = new TreeNodeData[node.Nodes.Count];

                    if ((!(node.Tag == null)) && node.Tag.GetType().IsSerializable)
                    {
                        this.Tag = node.Tag;
                    }
                    else
                    {
                        this.Tag = null;
                    }
                    if (node.Nodes.Count == 0)
                    {
                        return;
                    }
                    for (int i = 0; i <= node.Nodes.Count - 1; i++)
                    {
                        Nodes[i] = new TreeNodeData(node.Nodes[i]);
                    }
                }

                /// <summary>   
                /// TreeNodeData返回TreeNode   
                /// </summary>   
                /// <returns></returns>   
                public TreeNode ToTreeNode()
                {
                    TreeNode ToTreeNode = new TreeNode(this.Text, this.ImageIndex, this.SelectedImageIndex);
                    ToTreeNode.Checked = this.Checked;
                    ToTreeNode.Tag = this.Tag;
                    if (this.Expanded)
                    {
                        ToTreeNode.Expand();
                    }
                    if (this.Nodes == null && this.Nodes.Length == 0)
                    {
                        return null;
                    }
                    if (ToTreeNode != null && this.Nodes.Length == 0)
                    {
                        return ToTreeNode;
                    }
                    for (int i = 0; i <= this.Nodes.Length - 1; i++)
                    {
                        ToTreeNode.Nodes.Add(this.Nodes[i].ToTreeNode());
                    }
                    return ToTreeNode;
                }
            }
            /// <summary>   
            /// 加载TreeView   
            /// </summary>   
            /// <param name="treeView"></param>   
            /// <param name="path"></param>   
            public static void LoadTreeViewData(TreeView treeView, string path)
            {

                BinaryFormatter ser = new BinaryFormatter();
                Stream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                TreeViewData treeData = ((TreeViewData)(ser.Deserialize(file)));
                treeData.PopulateTree(treeView);
                file.Close();

            }

            /// <summary>   
            /// 保存TreeView到文件   
            /// </summary>   
            /// <param name="treeView"></param>   
            /// <param name="path"></param>   
            public static void SaveTreeViewData(TreeView treeView, string path)
            {
                BinaryFormatter ser = new BinaryFormatter();
                Stream file = new FileStream(path, FileMode.Create);
                ser.Serialize(file, new TreeViewData(treeView));
                file.Close();

            }
        }

        //柳永法加的，序列化，及反序列化DataTable   
        class SerializeDataTable
        {
            public static DataTable LoadDataTable(string path)
            {

                BinaryFormatter ser = new BinaryFormatter();
                Stream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                DataTable dt = (DataTable)ser.Deserialize(file);
                file.Close();
                return dt;
            }

            public static void SaveDataTable(DataTable dt, string path)
            {
                BinaryFormatter ser = new BinaryFormatter();
                Stream file = new FileStream(path, FileMode.Create);
                ser.Serialize(file, dt);
                file.Close();

            }
        }
    }
}
