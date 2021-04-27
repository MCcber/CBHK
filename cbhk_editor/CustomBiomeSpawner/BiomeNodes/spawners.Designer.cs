
namespace cbhk_editor.CustomBiomeSpawner.BiomeNodes
{
    partial class spawners
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("weight:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("minCount:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("maxCount:");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("spawners", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.spawners_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // spawners_view
            // 
            this.spawners_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.spawners_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spawners_view.ForeColor = System.Drawing.Color.White;
            this.spawners_view.Location = new System.Drawing.Point(0, 0);
            this.spawners_view.Name = "spawners_view";
            treeNode1.Name = "value:tag";
            treeNode1.Text = "type:";
            treeNode2.Name = "value:int";
            treeNode2.Text = "weight:";
            treeNode3.Name = "value:int";
            treeNode3.Text = "minCount:";
            treeNode4.Name = "value:int";
            treeNode4.Text = "maxCount:";
            treeNode5.Name = "root_node";
            treeNode5.Text = "spawners";
            this.spawners_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.spawners_view.Size = new System.Drawing.Size(308, 288);
            this.spawners_view.TabIndex = 0;
            // 
            // spawners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spawners_view);
            this.Name = "spawners";
            this.Size = new System.Drawing.Size(308, 288);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView spawners_view;
    }
}
