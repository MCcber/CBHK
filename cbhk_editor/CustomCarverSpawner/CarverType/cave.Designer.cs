
namespace cbhk_editor.CustomCarverSpawner.CarverType
{
    partial class cave
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("horizontal_radius_multiplier", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("vertical_radius_multiplier", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("type:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("floor_level", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Carver", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6});
            this.cave_view = new System.Windows.Forms.TreeView();
            this.carver_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // cave_view
            // 
            this.cave_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cave_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cave_view.ForeColor = System.Drawing.Color.White;
            this.cave_view.Location = new System.Drawing.Point(0, 0);
            this.cave_view.Name = "cave_view";
            this.cave_view.Size = new System.Drawing.Size(324, 480);
            this.cave_view.TabIndex = 0;
            // 
            // carver_view
            // 
            this.carver_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.carver_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carver_view.ForeColor = System.Drawing.Color.White;
            this.carver_view.Location = new System.Drawing.Point(0, 0);
            this.carver_view.Name = "carver_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode1.Text = "type:";
            treeNode2.Name = "parent_node";
            treeNode2.Text = "horizontal_radius_multiplier";
            treeNode3.Name = "value:string";
            treeNode3.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode3.Text = "type:";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "vertical_radius_multiplier";
            treeNode5.Name = "value:string";
            treeNode5.Tag = "minecraft:constant,minecraft:uniform,minecraft:clamped_normal,minecraft:trapezoid" +
    "";
            treeNode5.Text = "type:";
            treeNode6.Name = "parent_node";
            treeNode6.Text = "floor_level";
            treeNode7.Name = "root_node";
            treeNode7.Text = "Carver";
            this.carver_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.carver_view.Size = new System.Drawing.Size(324, 480);
            this.carver_view.TabIndex = 2;
            // 
            // cave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.carver_view);
            this.Controls.Add(this.cave_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "cave";
            this.Size = new System.Drawing.Size(324, 480);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView cave_view;
        public System.Windows.Forms.TreeView carver_view;
    }
}
