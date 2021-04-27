
namespace cbhk_editor.LootTableSpawner
{
    partial class pool_item
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("functions");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("conditions");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("min:0");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("max:0");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("rolls", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("min:0");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("max:0");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("bonus_rolls", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("functions");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("conditions");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("type:item");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("name:apple");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("weight:1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("quality:0");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("expand:false");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("entries", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode8,
            treeNode17});
            this.pool_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // pool_view
            // 
            this.pool_view.BackColor = System.Drawing.Color.Gray;
            this.pool_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pool_view.ForeColor = System.Drawing.Color.White;
            this.pool_view.Location = new System.Drawing.Point(0, 0);
            this.pool_view.Name = "pool_view";
            treeNode1.Name = "arraynode";
            treeNode1.Text = "functions";
            treeNode2.Name = "arraynode";
            treeNode2.Text = "conditions";
            treeNode3.Name = "value:int";
            treeNode3.Text = "min:0";
            treeNode4.Name = "value:int";
            treeNode4.Text = "max:0";
            treeNode5.Name = "parentnode";
            treeNode5.Text = "rolls";
            treeNode6.Name = "value:int";
            treeNode6.Text = "min:0";
            treeNode7.Name = "value:int";
            treeNode7.Text = "max:0";
            treeNode8.Name = "parentnode";
            treeNode8.Text = "bonus_rolls";
            treeNode9.Name = "arraynode";
            treeNode9.Text = "functions";
            treeNode10.Name = "arraynode";
            treeNode10.Text = "conditions";
            treeNode11.Name = "value:string";
            treeNode11.Text = "type:item";
            treeNode12.Name = "value:string";
            treeNode12.Text = "name:apple";
            treeNode13.Name = "value:float";
            treeNode13.Text = "weight:1";
            treeNode14.Name = "value:float";
            treeNode14.Text = "quality:0";
            treeNode15.Name = "value:bool";
            treeNode15.Text = "expand:false";
            treeNode16.Name = "ele";
            treeNode16.Text = "1";
            treeNode17.Name = "obj_parentnode";
            treeNode17.Text = "entries";
            treeNode18.Name = "ele";
            treeNode18.Text = "1";
            this.pool_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.pool_view.Size = new System.Drawing.Size(182, 274);
            this.pool_view.TabIndex = 2;
            // 
            // pool_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pool_view);
            this.Name = "pool_item";
            this.Size = new System.Drawing.Size(182, 274);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView pool_view;
    }
}
