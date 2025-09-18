using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._7
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(tbA.Text) + int.Parse(tbB.Text);
            tbKetQua.Text = tong.ToString();
        }

        private void btHieu_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(tbA.Text) - int.Parse(tbB.Text);
            tbKetQua.Text = hieu.ToString();
        }

        private void btTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(tbA.Text) * int.Parse(tbB.Text);
            tbKetQua.Text = tich.ToString();
        }

        private void btThuong_Click(object sender, EventArgs e)
        {
            float thuong = float.Parse(tbA.Text) / float.Parse(tbB.Text);
            tbKetQua.Text = thuong.ToString();
        }
    }
}
