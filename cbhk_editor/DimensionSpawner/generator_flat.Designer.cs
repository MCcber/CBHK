
namespace cbhk_editor.DimensionSpawner
{
    partial class generator_flat
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("biome:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("lakes:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("features:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("layers");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("distance:0");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("spread:0");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("count:0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("stronghold", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("structures");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("structures", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("generator", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.flat_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // flat_view
            // 
            this.flat_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.flat_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flat_view.ForeColor = System.Drawing.Color.White;
            this.flat_view.Location = new System.Drawing.Point(0, 0);
            this.flat_view.Name = "flat_view";
            treeNode1.Name = "value:string";
            treeNode1.Text = "biome:";
            treeNode2.Name = "value:bool";
            treeNode2.Text = "lakes:";
            treeNode3.Name = "value:bool";
            treeNode3.Text = "features:";
            treeNode4.Name = "array_node";
            treeNode4.Text = "layers";
            treeNode5.Name = "value:int";
            treeNode5.Text = "distance:0";
            treeNode6.Name = "value:int";
            treeNode6.Text = "spread:0";
            treeNode7.Name = "value:int";
            treeNode7.Text = "count:0";
            treeNode8.Name = "parent_node";
            treeNode8.Text = "stronghold";
            treeNode9.Name = "array_node";
            treeNode9.Text = "structures";
            treeNode10.Name = "parent_node";
            treeNode10.Text = "structures";
            treeNode11.Name = "parent_node";
            treeNode11.Text = "settings";
            treeNode12.Name = "root_node";
            treeNode12.Text = "generator";
            this.flat_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.flat_view.Size = new System.Drawing.Size(261, 500);
            this.flat_view.TabIndex = 0;
            // 
            // generator_flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flat_view);
            this.Name = "generator_flat";
            this.Size = new System.Drawing.Size(261, 500);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView flat_view;
    }
}
