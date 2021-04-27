
namespace cbhk_editor.DimensionSpawner
{
    partial class settings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("name:");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("bedrock_roof_position:-10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("bedrock_floor_position:0");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("sea_level:63");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("disable_mob_generation:false");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("noise_caves_enabled:true");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("aquifers_enabled:true");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("deepslate_enabled:true");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("default_block");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("default_fluid");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("min_y:0");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("height:256");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("density_factor:1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("density_offset:0");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("size_horizontal:1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("size_vertical:1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("simplex_surface_noise:true");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("random_density_offset:true");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("amplified:true");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("xz_scale:1");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("xz_factor:80");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("y_scale:1");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("y_factor:160");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("sampling", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("target:-30");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("size:0");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("offset:0");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("bottom_slide", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("target:-10");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("size:3");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("offset:0");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("top_slide", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("noise", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode24,
            treeNode28,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("structures");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("distance:0");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("spread:0");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("count:0");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("stronghold", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("structures", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("settings", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode33,
            treeNode39});
            this.settings_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // settings_view
            // 
            this.settings_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.settings_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_view.ForeColor = System.Drawing.Color.White;
            this.settings_view.Location = new System.Drawing.Point(0, 0);
            this.settings_view.Name = "settings_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:overworld,minecraft:nether,minecraft:floating_islands,minecraft:end,min" +
    "ecraft:caves,minecraft:amplified";
            treeNode1.Text = "name:";
            treeNode2.Name = "value:int";
            treeNode2.Text = "bedrock_roof_position:-10";
            treeNode3.Name = "value:int";
            treeNode3.Text = "bedrock_floor_position:0";
            treeNode4.Name = "value:int";
            treeNode4.Text = "sea_level:63";
            treeNode5.Name = "value:bool";
            treeNode5.Text = "disable_mob_generation:false";
            treeNode6.Name = "value:bool";
            treeNode6.Text = "noise_caves_enabled:true";
            treeNode7.Name = "value:bool";
            treeNode7.Text = "aquifers_enabled:true";
            treeNode8.Name = "value:bool";
            treeNode8.Text = "deepslate_enabled:true";
            treeNode9.Name = "parent_node";
            treeNode9.Text = "default_block";
            treeNode10.Name = "parent_node";
            treeNode10.Text = "default_fluid";
            treeNode11.Name = "value:int";
            treeNode11.Text = "min_y:0";
            treeNode12.Name = "value:int";
            treeNode12.Text = "height:256";
            treeNode13.Name = "value:double";
            treeNode13.Text = "density_factor:1";
            treeNode14.Name = "value:double";
            treeNode14.Text = "density_offset:0";
            treeNode15.Name = "value:int";
            treeNode15.Text = "size_horizontal:1";
            treeNode16.Name = "value:int";
            treeNode16.Text = "size_vertical:1";
            treeNode17.Name = "value:bool";
            treeNode17.Text = "simplex_surface_noise:true";
            treeNode18.Name = "value:bool";
            treeNode18.Text = "random_density_offset:true";
            treeNode19.Name = "value:bool";
            treeNode19.Text = "amplified:true";
            treeNode20.Name = "value:double";
            treeNode20.Text = "xz_scale:1";
            treeNode21.Name = "value:double";
            treeNode21.Text = "xz_factor:80";
            treeNode22.Name = "value:double";
            treeNode22.Text = "y_scale:1";
            treeNode23.Name = "节点26";
            treeNode23.Text = "y_factor:160";
            treeNode24.Name = "parent_node";
            treeNode24.Text = "sampling";
            treeNode25.Name = "value:int";
            treeNode25.Text = "target:-30";
            treeNode26.Name = "value:int";
            treeNode26.Text = "size:0";
            treeNode27.Name = "value:int";
            treeNode27.Text = "offset:0";
            treeNode28.Name = "parent_node";
            treeNode28.Text = "bottom_slide";
            treeNode29.Name = "value:int";
            treeNode29.Text = "target:-10";
            treeNode30.Name = "value:int";
            treeNode30.Text = "size:3";
            treeNode31.Name = "value:int";
            treeNode31.Text = "offset:0";
            treeNode32.Name = "parent_node";
            treeNode32.Text = "top_slide";
            treeNode33.Name = "parent_node";
            treeNode33.Text = "noise";
            treeNode34.Name = "parent_node";
            treeNode34.Text = "structures";
            treeNode35.Name = "value:int";
            treeNode35.Text = "distance:0";
            treeNode36.Name = "value:int";
            treeNode36.Text = "spread:0";
            treeNode37.Name = "value:int";
            treeNode37.Text = "count:0";
            treeNode38.Name = "parent_node";
            treeNode38.Text = "stronghold";
            treeNode39.Name = "parent_node";
            treeNode39.Text = "structures";
            treeNode40.Name = "value:tag";
            treeNode40.Tag = "";
            treeNode40.Text = "settings";
            this.settings_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40});
            this.settings_view.Size = new System.Drawing.Size(352, 483);
            this.settings_view.TabIndex = 0;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.settings_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "settings";
            this.Size = new System.Drawing.Size(352, 483);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView settings_view;
    }
}
