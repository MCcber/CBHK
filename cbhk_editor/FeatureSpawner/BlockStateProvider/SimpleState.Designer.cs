
namespace cbhk_editor.FeatureSpawner.BlockStateProvider
{
    partial class SimpleState
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Name:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Properties");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("state", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("SimpleState", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.SimpleStateView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // SimpleStateView
            // 
            this.SimpleStateView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SimpleStateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleStateView.ForeColor = System.Drawing.Color.White;
            this.SimpleStateView.Location = new System.Drawing.Point(0, 0);
            this.SimpleStateView.Name = "SimpleStateView";
            treeNode1.Name = "value:tag";
            treeNode1.Text = "Name:";
            treeNode2.Name = "parent_node";
            treeNode2.Text = "Properties";
            treeNode3.Name = "parent_node";
            treeNode3.Text = "state";
            treeNode4.Name = "root_node";
            treeNode4.Text = "SimpleState";
            this.SimpleStateView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.SimpleStateView.Size = new System.Drawing.Size(190, 114);
            this.SimpleStateView.TabIndex = 0;
            // 
            // SimpleState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.SimpleStateView);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SimpleState";
            this.Size = new System.Drawing.Size(190, 114);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView SimpleStateView;
    }
}
