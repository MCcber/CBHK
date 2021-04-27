
namespace cbhk_editor.CustomCarverSpawner.CarverType
{
    partial class canyon
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("vertical_rotation", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("distance_factor", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("thickness", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("width_smoothness:");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("horizontal_radius_factor", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("vertical_radius_default_factor:");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("vertical_radius_center_factor:");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("shape", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode7,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("type", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode12});
            this.canyon_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // canyon_view
            // 
            this.canyon_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.canyon_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canyon_view.ForeColor = System.Drawing.Color.White;
            this.canyon_view.Location = new System.Drawing.Point(0, 0);
            this.canyon_view.Name = "canyon_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode1.Text = "type:";
            treeNode2.Name = "parent_node";
            treeNode2.Text = "vertical_rotation";
            treeNode3.Name = "value:string";
            treeNode3.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode3.Text = "type:";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "distance_factor";
            treeNode5.Name = "value:string";
            treeNode5.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode5.Text = "type:";
            treeNode6.Name = "parent_node";
            treeNode6.Text = "thickness";
            treeNode7.Name = "value:int";
            treeNode7.Text = "width_smoothness:";
            treeNode8.Name = "value:string";
            treeNode8.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode8.Text = "type:";
            treeNode9.Name = "parent_node";
            treeNode9.Text = "horizontal_radius_factor";
            treeNode10.Name = "value:int";
            treeNode10.Text = "vertical_radius_default_factor:";
            treeNode11.Name = "value:int";
            treeNode11.Text = "vertical_radius_center_factor:";
            treeNode12.Name = "parent_node";
            treeNode12.Text = "shape";
            treeNode13.Name = "root_node";
            treeNode13.Text = "type";
            this.canyon_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.canyon_view.Size = new System.Drawing.Size(352, 480);
            this.canyon_view.TabIndex = 0;
            // 
            // canyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.canyon_view);
            this.Name = "canyon";
            this.Size = new System.Drawing.Size(352, 480);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView canyon_view;
    }
}
