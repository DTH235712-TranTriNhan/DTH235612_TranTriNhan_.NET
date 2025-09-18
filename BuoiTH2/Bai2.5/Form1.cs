using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._5
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
            MessageBox.Show(tong.ToString());
        }
    }
}
