
namespace cbhk_editor.FeatureSpawner.FeatureType
{
    partial class Tree
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("trunk_provider");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("leaves_provider");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:constant");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("value:0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("radius", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("type:constant");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("value:0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("offset", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("type:minecraft:acacia_foliage_placer");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("foliage_placer", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("base_height:");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("height_rand_a:");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("height_rand_b:");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("trunk_placer", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("min_clipped_height:");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("type:two_layers_feature_size");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("minimum_size", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("decorators");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("max_water_depth:");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("ignore_vines:");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("heightmap:");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Tree", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode10,
            treeNode15,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            this.MCTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // MCTreeView
            // 
            this.MCTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MCTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MCTreeView.ForeColor = System.Drawing.Color.White;
            this.MCTreeView.Location = new System.Drawing.Point(0, 0);
            this.MCTreeView.Name = "MCTreeView";
            treeNode1.Name = "parent_node";
            treeNode1.Tag = "Blockstate";
            treeNode1.Text = "trunk_provider";
            treeNode2.Name = "parent_node";
            treeNode2.Tag = "Blockstate ";
            treeNode2.Text = "leaves_provider";
            treeNode3.Name = "value:tag";
            treeNode3.Tag = "foliage_value_type";
            treeNode3.Text = "type:constant";
            treeNode4.Name = "value:int";
            treeNode4.Text = "value:0";
            treeNode5.Name = "parent_node";
            treeNode5.Text = "radius";
            treeNode6.Name = "节点1";
            treeNode6.Tag = "foliage_value_type";
            treeNode6.Text = "type:constant";
            treeNode7.Name = "value:tag";
            treeNode7.Tag = "foliage_value_type";
            treeNode7.Text = "value:0";
            treeNode8.Name = "parent_node";
            treeNode8.Text = "offset";
            treeNode9.Name = "value:tag";
            treeNode9.Text = "type:minecraft:acacia_foliage_placer";
            treeNode10.Name = "parent_node";
            treeNode10.Text = "foliage_placer";
            treeNode11.Name = "value:tag";
            treeNode11.Tag = "straight_trunk_placer,forking_trunk_placer,giant_trunk_placer,mega_jungle_trunk_p" +
    "lacer,dark_oak_trunk_placer,fancy_trunk_placer";
            treeNode11.Text = "type:";
            treeNode12.Name = "value:int";
            treeNode12.Text = "base_height:";
            treeNode13.Name = "value:int";
            treeNode13.Text = "height_rand_a:";
            treeNode14.Name = "value:int";
            treeNode14.Text = "height_rand_b:";
            treeNode15.Name = "parent_node";
            treeNode15.Text = "trunk_placer";
            treeNode16.Name = "value:int";
            treeNode16.Text = "min_clipped_height:";
            treeNode17.Name = "value:tag";
            treeNode17.Tag = "two_layers_feature_size,three_layers_feature_size";
            treeNode17.Text = "type:two_layers_feature_size";
            treeNode18.Name = "parent_node";
            treeNode18.Text = "minimum_size";
            treeNode19.Name = "array_node";
            treeNode19.Tag = "trunk_vine,leave_vine,cocoa,beehive,alter_ground";
            treeNode19.Text = "decorators";
            treeNode20.Name = "value:int";
            treeNode20.Text = "max_water_depth:";
            treeNode21.Name = "value:bool";
            treeNode21.Text = "ignore_vines:";
            treeNode22.Name = "value:tag";
            treeNode22.Tag = "WORLD_SURFACE_WG,WORLD_SURFACE,OCEAN_FLOOR_WG,OCEAN_FLOOR,MOTION_BLOCKING,MOTION_" +
    "BLOCKING_NO_LEAVES";
            treeNode22.Text = "heightmap:";
            treeNode23.Name = "root_node";
            treeNode23.Text = "Tree";
            this.MCTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.MCTreeView.Size = new System.Drawing.Size(395, 553);
            this.MCTreeView.TabIndex = 0;
            // 
            // Tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.MCTreeView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Tree";
            this.Size = new System.Drawing.Size(395, 553);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView MCTreeView;
    }
}
