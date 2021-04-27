
namespace cbhk_editor.DimensionSpawner.BiomeSource
{
    partial class multi_noise
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("firstOctave:-7");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("amplitudes");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("altitude_noise", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("firstOctave:-7");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("amplitudes");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("temperature_noise", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("firstOctave:-7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("amplitudes");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("humidity_noise", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("firstOctave:-7");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("amplitudes");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("weirdness_noise", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("biomes");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("BiomeSource", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode12,
            treeNode13});
            this.multi_noise_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // multi_noise_view
            // 
            this.multi_noise_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.multi_noise_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multi_noise_view.ForeColor = System.Drawing.Color.White;
            this.multi_noise_view.Location = new System.Drawing.Point(0, 0);
            this.multi_noise_view.Name = "multi_noise_view";
            treeNode1.Name = "value:int";
            treeNode1.Text = "firstOctave:-7";
            treeNode2.Name = "list_node";
            treeNode2.Text = "amplitudes";
            treeNode3.Name = "parent_node";
            treeNode3.Text = "altitude_noise";
            treeNode4.Name = "value:int";
            treeNode4.Text = "firstOctave:-7";
            treeNode5.Name = "list_node";
            treeNode5.Text = "amplitudes";
            treeNode6.Name = "parent_node";
            treeNode6.Text = "temperature_noise";
            treeNode7.Name = "value:int";
            treeNode7.Text = "firstOctave:-7";
            treeNode8.Name = "list_node";
            treeNode8.Text = "amplitudes";
            treeNode9.Name = "parent_node";
            treeNode9.Text = "humidity_noise";
            treeNode10.Name = "value:int";
            treeNode10.Text = "firstOctave:-7";
            treeNode11.Name = "list_node";
            treeNode11.Text = "amplitudes";
            treeNode12.Name = "parent_node";
            treeNode12.Text = "weirdness_noise";
            treeNode13.Name = "array_node";
            treeNode13.Text = "biomes";
            treeNode14.Name = "root_node";
            treeNode14.Text = "BiomeSource";
            this.multi_noise_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.multi_noise_view.Size = new System.Drawing.Size(384, 578);
            this.multi_noise_view.TabIndex = 0;
            // 
            // multi_noise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.multi_noise_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "multi_noise";
            this.Size = new System.Drawing.Size(384, 578);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView multi_noise_view;
    }
}
