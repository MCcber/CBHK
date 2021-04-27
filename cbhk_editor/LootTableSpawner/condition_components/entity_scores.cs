using System;
using System.Windows.Forms;

namespace cbhk_editor.LootTableSpawner.condition_components
{
    public partial class entity_scores : UserControl
    {
        public entity_scores()
        {
            InitializeComponent();

            min_box.KeyPress += InputNumber;
            max_box.KeyPress += InputNumber;

            min_box.PreviewKeyDown += previewKeyDown;
            max_box.PreviewKeyDown += previewKeyDown;
        }

        private void entity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            string scoreInfo = "";
            foreach (string item in score_box.Items)
            {
                scoreInfo += item;
            }
            if (scoreInfo.Trim() != "")
                table.Parent.Tag = "{\"condition\": \"minecraft:entity_scores\",\"entity\": \"" + entity.Text.Trim() + "\",\"scores\":{" + scoreInfo.TrimEnd(',') + "}},";
            else
                table.Parent.Tag = null;
        }

        private void add_score_Click(object sender, EventArgs e)
        {
            string scoreInfo = "";
            if (min_box.Text.Trim() != "" && max_box.Text.Trim() != "")
                scoreInfo = "\"" + score_box.Text.Trim() + "\":{\"min\":" + min_box.Text.Trim() + ",\"max\":" + max_box.Text.Trim() + "},";
            else
                if (min_box.Text.Trim() != "")
                scoreInfo = "\"" + score_box.Text.Trim() +"\":"+min_box.Text.Trim()+",";
            else
                if(max_box.Text.Trim() != "")
                scoreInfo = "\"" + score_box.Text.Trim() + "\":" + max_box.Text.Trim()+",";
            if(scoreInfo.Trim() != "")
            score_box.Items.Add(scoreInfo);
            UpdateInfo();
        }

        private void InputNumber(object sender,KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键 
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
                {
                    e.Handled = true;
                }
            }
        }

        private void previewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
                e.IsInputKey = true;
        }

        private void score_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            score_box.Items.RemoveAt(score_box.SelectedIndex);
            UpdateInfo();
        }

        private void entity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
