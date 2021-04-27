
namespace cbhk_editor.LootTableSpawner
{
    partial class entry_item
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("type:item");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("name:apple");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("weight:1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("quality:1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("expand:false");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.entry_view = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // entry_view
            // 
            this.entry_view.BackColor = System.Drawing.Color.Gray;
            this.entry_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entry_view.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.entry_view.ForeColor = System.Drawing.Color.White;
            this.entry_view.Location = new System.Drawing.Point(0, 0);
            this.entry_view.Name = "entry_view";
            treeNode1.Name = "arraynode";
            treeNode1.Text = "functions";
            treeNode2.Name = "arraynode";
            treeNode2.Text = "conditions";
            treeNode3.Name = "value:string";
            treeNode3.Text = "type:item";
            treeNode4.Name = "value:string";
            treeNode4.Text = "name:apple";
            treeNode5.Name = "value:float";
            treeNode5.Text = "weight:1";
            treeNode6.Name = "value:float";
            treeNode6.Text = "quality:1";
            treeNode7.Name = "value:bool";
            treeNode7.Text = "expand:false";
            treeNode8.Name = "ele";
            treeNode8.Text = "1";
            this.entry_view.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.entry_view.Size = new System.Drawing.Size(122, 119);
            this.entry_view.TabIndex = 3;
            // 
            // entry_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.entry_view);
            this.Name = "entry_item";
            this.Size = new System.Drawing.Size(122, 119);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TreeView entry_view;
    }
}
