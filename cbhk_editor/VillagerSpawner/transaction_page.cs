using cbhk_editor.ItemSpawner;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace cbhk_editor.VillagerSpawner
{
    public partial class transaction_page : UserControl
    {
        SoundPlayer click = new SoundPlayer();
        TreeView register;
        public transaction_page(SoundPlayer soundPlayer,TreeView rootnode)
        {
            InitializeComponent();
            click = soundPlayer;
            transaction_table.BackColor = Color.FromArgb(50,50,50);
            transaction_table.ForeColor = Color.White;
            foreach (Control item in transaction_table.Controls)
            {
                if (item is Button)
                    item.Click += SetItemNBT;
                item.BackColor = Color.FromArgb(50, 50, 50);
                item.ForeColor = Color.White;
            }
            priceMultiplier_box.KeyPress += Number_KeyPress;
            register = rootnode;
        }

        private void SetItemNBT(object sender, EventArgs e)
        {
            if(click != null)
            click.Play();
            Button this_obj = sender as Button;
            Item_spawner item_Spawner = new Item_spawner(null, click, true);
            if (item_Spawner.ShowDialog() == DialogResult.OK && item_Spawner.ItemNBTs[0].Trim() != "")
                this_obj.Tag = item_Spawner.ItemNBTs[0];
            else
                this_obj.Tag = null;
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox this_obj = sender as TextBox;
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 0x2E)
                e.Handled = true;
            if (e.KeyChar == '.')   //允许输入回退键
            {
                if (this_obj.Text == "")
                {
                    this_obj.Text = "0.";
                    this_obj.Select(this_obj.Text.Length, 0);
                    e.Handled = true;
                }
                else if (this_obj.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }
    }
}
