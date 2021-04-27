
namespace cbhk_editor.DimensionSpawner.BiomeSource
{
    partial class muti_noise_biomes
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("altitude:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("weirdness:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("offset:");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("temperature:");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("humidity:");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("parameters", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BiomeSource", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7});
            this.biomes_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // biomes_view
            // 
            this.biomes_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.biomes_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.biomes_view.ForeColor = System.Drawing.Color.White;
            this.biomes_view.Location = new System.Drawing.Point(0, 0);
            this.biomes_view.Name = "biomes_view";
            treeNode1.Name = "value:string";
            treeNode1.Text = "biome:";
            treeNode2.Name = "value:float";
            treeNode2.Text = "altitude:";
            treeNode3.Name = "value:float";
            treeNode3.Text = "weirdness:";
            treeNode4.Name = "value:float";
            treeNode4.Text = "offset:";
            treeNode5.Name = "value:float";
            treeNode5.Text = "temperature:";
            treeNode6.Name = "value:float";
            treeNode6.Text = "humidity:";
            treeNode7.Name = "parent_node";
            treeNode7.Text = "parameters";
            treeNode8.Name = "root_node";
            treeNode8.Text = "BiomeSource";
            this.biomes_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.biomes_view.Size = new System.Drawing.Size(202, 227);
            this.biomes_view.TabIndex = 0;
            // 
            // muti_noise_biomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.biomes_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "muti_noise_biomes";
            this.Size = new System.Drawing.Size(202, 227);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView biomes_view;
    }
}
