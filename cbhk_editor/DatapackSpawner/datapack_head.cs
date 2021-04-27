using System;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.DatapackSpawner
{
    public partial class datapack_head : UserControl
    {
        SoundPlayer soundPlayer = null;
        public datapack_head(SoundPlayer click)
        {
            InitializeComponent();
            soundPlayer = click;
            foreach (Control item in Controls)
            {
                if(item is TableLayoutPanel)
                {
                    foreach (Control subitem in item.Controls)
                    {
                        if (subitem is Button && !subitem.Name.Contains("nbt"))
                        {
                            subitem.Click += LoadJson;
                        }
                    }
                }
            }
        }

        private void Load_nbt_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Button this_obj = sender as Button;
            //获取NBT文本框的引用
            TableLayoutPanel this_table = this_obj.Parent as TableLayoutPanel;
            OpenFileDialog open_nbt = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists  =true,
                DefaultExt = ".nbt",
                DereferenceLinks = true,
                Multiselect = true,
                Filter = "NBT文件|*.nbt",
                RestoreDirectory = true,
                Title = "请选择NBT文件"
            };
            if(open_nbt.ShowDialog() == DialogResult.OK)
            {
                TableLayoutPanelCellPosition this_pos =  this_table.GetPositionFromControl(this_obj);
                TextBox nbt_box = this_table.GetControlFromPosition(this_pos.Column-1,this_pos.Row) as TextBox;
                foreach (string item in open_nbt.FileNames)
                {
                    nbt_box.Text += item;
                }
            }
        }

        private void LoadJson(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Button this_obj = sender as Button;
            //获取NBT文本框的引用
            TableLayoutPanel this_table = this_obj.Parent as TableLayoutPanel;
            OpenFileDialog open_json = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".json",
                DereferenceLinks = true,
                Multiselect = true,
                Filter = "JSON文件|*.json",
                RestoreDirectory = true,
                Title = "请选择JSON文件"
            };
            if (open_json.ShowDialog() == DialogResult.OK)
            {
                TableLayoutPanelCellPosition this_pos = this_table.GetPositionFromControl(this_obj);
                TextBox nbt_box = this_table.GetControlFromPosition(this_pos.Column - 1, this_pos.Row) as TextBox;
                foreach (string item in open_json.FileNames)
                {
                    nbt_box.Text += item;
                }
            }
        }
    }
}
