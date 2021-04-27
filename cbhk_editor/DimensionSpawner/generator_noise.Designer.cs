﻿
namespace cbhk_editor.DimensionSpawner
{
    partial class generator_noise
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("settings");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("seed:");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:the_end");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("biome_source", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("generator", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.noise_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // noise_view
            // 
            this.noise_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.noise_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noise_view.ForeColor = System.Drawing.Color.White;
            this.noise_view.Location = new System.Drawing.Point(0, 0);
            this.noise_view.Name = "noise_view";
            treeNode1.Name = "value:tag";
            treeNode1.Tag = "minecraft:overworld,minecraft:nether,minecraft:floating_islands,minecraft:end,min" +
    "ecraft:caves,minecraft:amplified,object";
            treeNode1.Text = "settings";
            treeNode2.Name = "value:long";
            treeNode2.Text = "seed:";
            treeNode3.Name = "value:string";
            treeNode3.Tag = "minecraft:vanilla_layered,minecraft:the_end,minecraft:multi_noise,minecraft:fixed" +
    ",minecraft:checkerboard";
            treeNode3.Text = "type:the_end";
            treeNode4.Name = "parent_node";
            treeNode4.Text = "biome_source";
            treeNode5.Name = "root_node";
            treeNode5.Text = "generator";
            this.noise_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.noise_view.Size = new System.Drawing.Size(270, 500);
            this.noise_view.TabIndex = 0;
            // 
            // generator_noise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.noise_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "generator_noise";
            this.Size = new System.Drawing.Size(270, 500);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView noise_view;
    }
}
