using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KHACHSAN
{
    public partial class Form1 : Form
    {
        //kiểm  tra form con có tồn tại hay chưa
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }

            }
            return check;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDSPHONG"))
            {
                frmDSPHONG frm = new frmDSPHONG();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDSNHANVIEN"))
            {
                frmDSNHANVIEN frm = new frmDSNHANVIEN();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDSKHACHHANG"))
            {
                frmDSKHACHHANG frm = new frmDSKHACHHANG();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHOADON"))
            {
                frmHOADON frm = new frmHOADON();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
