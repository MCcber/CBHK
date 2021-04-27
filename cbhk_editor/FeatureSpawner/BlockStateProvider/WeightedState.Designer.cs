
namespace cbhk_editor.FeatureSpawner.BlockStateProvider
{
    partial class WeightedState
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("weight:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("data", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("WeightedState", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.WeightedStateView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // WeightedStateView
            // 
            this.WeightedStateView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.WeightedStateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeightedStateView.ForeColor = System.Drawing.Color.White;
            this.WeightedStateView.Location = new System.Drawing.Point(0, 0);
            this.WeightedStateView.Name = "WeightedStateView";
            treeNode1.Name = "value:int";
            treeNode1.Text = "weight:";
            treeNode2.Name = "value:tag";
            treeNode2.Text = "Name:";
            treeNode3.Name = "parent_node";
            treeNode3.Text = "Properties";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "data";
            treeNode5.Name = "root_node";
            treeNode5.Text = "WeightedState";
            this.WeightedStateView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.WeightedStateView.Size = new System.Drawing.Size(199, 115);
            this.WeightedStateView.TabIndex = 0;
            // 
            // WeightedState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.WeightedStateView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "WeightedState";
            this.Size = new System.Drawing.Size(199, 115);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView WeightedStateView;
    }
}
