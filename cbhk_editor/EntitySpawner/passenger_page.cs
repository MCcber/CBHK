using System.Drawing;
using System.Windows.Forms;

namespace cbhk_editor.EntitySpawner
{
    public partial class passenger_page : UserControl
    {
        public passenger_page()
        {
            InitializeComponent();
            passengerTab.SelectedTab.BackColor = Color.FromArgb(50,50,50);
        }

        private void passenger_entity_btn_Click(object sender, System.EventArgs e)
        {
            Button this_obj = sender as Button;
            EntityNBTForm entityNBTForm = new EntityNBTForm(this_obj.Tag != null ? this_obj.Tag.ToString() : "")
            {
                Text = "设置骑乘实体信息"
            };
            if (entityNBTForm.ShowDialog() == DialogResult.OK)
            {
                this_obj.Tag = entityNBTForm.nbt_result;
            }
        }
    }
}
