
namespace cbhk_editor.DimensionSpawner
{
    partial class dimension_type
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ultrawarm:false");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("natural:true");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("coordinate_scale:1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("has_skylight:true");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("has_ceiling:false");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ambient_light:0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("fixed_time:false");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("piglin_safe:false");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("bed_works:true");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("respawn_anchor_works:false");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("has_raids:true");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("logical_height:256");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("min_y‌:0");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("height‌:256");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("infiniburn:");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("effects:");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("type", new System.Windows.Forms.TreeNode[] {
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
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.dimension_type_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // dimension_type_view
            // 
            this.dimension_type_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dimension_type_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimension_type_view.ForeColor = System.Drawing.Color.White;
            this.dimension_type_view.Location = new System.Drawing.Point(0, 0);
            this.dimension_type_view.Name = "dimension_type_view";
            treeNode1.Name = "value:string";
            treeNode1.Tag = "minecraft:overworld,minecraft:overworld_caves,minecraft:the_end,minecraft:the_net" +
    "her";
            treeNode1.Text = "name:";
            treeNode2.Name = "value:bool";
            treeNode2.Text = "ultrawarm:false";
            treeNode3.Name = "value:bool";
            treeNode3.Text = "natural:true";
            treeNode4.Name = "value:float";
            treeNode4.Text = "coordinate_scale:1";
            treeNode5.Name = "value:bool";
            treeNode5.Text = "has_skylight:true";
            treeNode6.Name = "value:bool";
            treeNode6.Text = "has_ceiling:false";
            treeNode7.Name = "value:float";
            treeNode7.Text = "ambient_light:0";
            treeNode8.Name = "value:bool";
            treeNode8.Text = "fixed_time:false";
            treeNode9.Name = "value:bool";
            treeNode9.Text = "piglin_safe:false";
            treeNode10.Name = "value:bool";
            treeNode10.Text = "bed_works:true";
            treeNode11.Name = "value:bool";
            treeNode11.Text = "respawn_anchor_works:false";
            treeNode12.Name = "value:bool";
            treeNode12.Text = "has_raids:true";
            treeNode13.Name = "value:int";
            treeNode13.Text = "logical_height:256";
            treeNode14.Name = "value:int";
            treeNode14.Text = "min_y‌:0";
            treeNode15.Name = "value:int";
            treeNode15.Text = "height‌:256";
            treeNode16.Name = "value:string";
            treeNode16.Text = "infiniburn:";
            treeNode17.Name = "value:string";
            treeNode17.Tag = "minecraft:overworld,minecraft:the_nether,minecraft:the_end";
            treeNode17.Text = "effects:";
            treeNode18.Name = "root_node";
            treeNode18.Text = "type";
            this.dimension_type_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.dimension_type_view.Size = new System.Drawing.Size(331, 517);
            this.dimension_type_view.TabIndex = 0;
            // 
            // dimension_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.dimension_type_view);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "dimension_type";
            this.Size = new System.Drawing.Size(331, 517);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView dimension_type_view;
    }
}
