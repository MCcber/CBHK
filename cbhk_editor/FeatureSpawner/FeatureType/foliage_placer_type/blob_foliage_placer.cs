using System.IO;
using System.Windows.Forms;

namespace cbhk_editor.FeatureSpawner.FeatureType.foliage_placer_type
{
    class blob_foliage_placer
    {
        public static TreeNode BlobFoliagePlacer(TreeNode current_node)
        {
            if(File.Exists(Application.StartupPath + "\\FeatureSettings\\FeatureType\\foliage_placer_type\\blob_foliage_placer.ini"))
            {
                string[] MatchKeys = File.ReadAllText(Application.StartupPath + "\\FeatureSettings\\FeatureType\\foliage_placer_type\\blob_foliage_placer.ini").Split(',');
                for (int i = 0; i < MatchKeys.Length; i++)
                {
                    if (MatchKeys[i] == current_node.Text)
                    {
                        TreeNode height = new TreeNode()
                        {
                            Text = "height:",
                            Name = "value:int"
                        };
                        return height;
                    }
                }
            }
            return null;
        }
    }
}
