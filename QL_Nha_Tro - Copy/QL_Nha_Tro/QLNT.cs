using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nha_Tro
{
    public partial class QLNT : Form
    {
        public QLNT()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdangky_Click(object sender, EventArgs e)
        {
            DK dk = new DK();
            dk.ShowDialog();
        }

        private void btnqltb_Click(object sender, EventArgs e)
        {
            QL_TB tb = new QL_TB();
            tb.ShowDialog();
        }

        private void btnthutienphong_Click(object sender, EventArgs e)
        {
            Thu_tien_phong tt = new Thu_tien_phong();
            tt.ShowDialog();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttendangnhap.Text=="congga" && txtpass.Text=="123")
            {
                grchucnang.Enabled = true;
                grdangnhap.Enabled = false;
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            grchucnang.Enabled = false;
            grdangnhap.Enabled =  true;
        }

        private void QLNT_Load(object sender, EventArgs e)
        {

        }
    }
}
