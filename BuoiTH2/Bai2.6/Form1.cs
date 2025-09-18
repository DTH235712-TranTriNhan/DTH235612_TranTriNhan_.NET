using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbA_Click(object sender, EventArgs e)
        {

        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(tbA.Text) + int.Parse(tbB.Text);
            MessageBox.Show(tong.ToString());
        }

        private void btHieu_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(tbA.Text) - int.Parse(tbB.Text);
            MessageBox.Show(hieu.ToString());
        }

        private void btTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(tbA.Text) * int.Parse(tbB.Text);
            MessageBox.Show(tich.ToString());
        }

        private void btThuong_Click(object sender, EventArgs e)
        {
            float thuong = float.Parse(tbA.Text) / float.Parse(tbB.Text);
            MessageBox.Show(thuong.ToString());
        }
    }
}
