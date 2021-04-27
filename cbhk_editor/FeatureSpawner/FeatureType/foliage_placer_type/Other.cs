using System.Windows.Forms;

namespace cbhk_editor.FeatureSpawner.FeatureType.foliage_placer_type
{
    class Other
    {
        public static TreeNode OtherType(TreeNode current_node)
        {
            switch (current_node.Text.Split(':')[1])
            {
                case "spruce_foliage_placer":
                    {
                        TreeNode trunk_height = new TreeNode()
                        {
                            Text = "trunk_height",
                            Name = "parent_node",
                            Tag = "foliage_value_type"
                        };
                        return trunk_height;
                    }
                case "pine_foliage_placer":
                    {
                        TreeNode height = new TreeNode()
                        {
                            Text = "height",
                            Name = "parent_node",
                            Tag = "foliage_value_type"
                        };
                        return height;
                    }
                case "mega_pine_foliage_placer":
                    {
                        TreeNode crown_height = new TreeNode()
                        {
                            Text = "crown_height",
                            Name = "parent_node",
                            Tag = "foliage_value_type"
                        };
                        return crown_height;
                    }
            }
            return null;
        }
    }
}
