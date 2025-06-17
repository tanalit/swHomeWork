using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        private object messageBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void labName_Click(object sender, EventArgs e)
        {

        }

        private void labDay_Click(object sender, EventArgs e)
        {

        }

        private void btComfirm_Click(object sender, EventArgs e)
        {
            if (!cbRobot.Checked)
                MessageBox.Show("โปรดยืนยันว่าคุณไม่ใช้โปรแกรมอัตโนมัติ");
                else if (cbRobot.Checked)
                    MessageBox.Show("ยืนยันการจอง");
        }

        private void btClean_Click(object sender, EventArgs e)
        {
          tbName.Clear();
          dateTimePicker1.Value = DateTime.Now;
          comboBox1.SelectedIndex = -1;
          cbbGender.SelectedIndex = -1;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("โปรแกรมนี้สร้างโดย นายธนฤทธิ์ คำวิเศษ 6710301024 เพื่อใช้ในการจองห้องประชุม", "เกี่ยวกับโปรแกรม", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
