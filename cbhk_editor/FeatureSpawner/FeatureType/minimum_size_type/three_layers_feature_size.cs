using System.Windows.Forms;

namespace cbhk_editor.FeatureSpawner.FeatureType.minimum_size_type
{
    class three_layers_feature_size
    {
        public static TreeNode[] GetNodes(TreeNode current_node)
        {
            if (current_node.Text.Split(':')[1] == "three_layers_feature_size")
            {
                TreeNode limit = new TreeNode()
                {
                    Text = "limit:",
                    Name = "value:int"
                };
                TreeNode lower_size = new TreeNode()
                {
                    Text = "lower_size:",
                    Name = "value:int"
                };
                TreeNode upper_size = new TreeNode()
                {
                    Text = "upper_size:",
                    Name = "value:int"
                };
                TreeNode upper_limit = new TreeNode()
                {
                    Text = "upper_limit:",
                    Name = "value:int"
                };
                TreeNode middle_size = new TreeNode()
                {
                    Text = "middle_size:",
                    Name = "value:int"
                };
                TreeNode[] nodes = new TreeNode[] { limit, lower_size, upper_size,upper_limit,middle_size };
                return nodes;
            }
            else
                return null;
        }
    }
}
