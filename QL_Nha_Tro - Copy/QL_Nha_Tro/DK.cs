using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QL_Nha_Tro
{
    public partial class DK : Form 
    {
        
       
        SqlCommand thuc_hien;
        string s;
        SqlDataReader doc;

        public DK()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       public void load_cbbMaPhong()
        {
            MessageBox.Show("aaaaa1a");
            try
            {
                kn.cnn.Open();
                s = @"select MaPhong FROM PHONG";
                thuc_hien = new SqlCommand(s, kn.cnn);
                doc = thuc_hien.ExecuteReader();
                //  i = 0;
                MessageBox.Show("aaaaa2a");
                while (doc.Read())
                {

                    cbbMaPhong.Items.Add(doc[0].ToString());
                }
                kn.cnn.Close();
            }
            catch
            {

            }
           

        }
        public void them()
        {
            try
            {


                kn.cnn.Open();
                int maphong = int.Parse(cbbMaPhong.SelectedItem.ToString());
                int makh = int.Parse(txtMaKH.Text.ToString());
                int soluong = int.Parse(txtSoLUongToiDa.Text.ToString());
                int cmnd = int.Parse(txtcnnd.Text.ToString());
                int sdt = int.Parse(txtsdt.Text.ToString());
                int tien_thue = int.Parse(txttienthuephong.Text.ToString());
                int tien_coc = int.Parse(txttiendatcoc.Text.ToString());
                s = @"insert into DangKy(MaPhong,MaKH,SoLuongToiDa,TienThuePhong,TienCoc,CMND,TenKH,SDT,NgayThue)
               VALUES('" + maphong + @"','" + makh + @"','" + soluong + @"','" + tien_thue + @"','" + tien_coc + @"','" + cmnd + @"','" + txthovaten.Text + @"','" + sdt + @"','" + dateNgayThue.Value + @"')";
                thuc_hien = new SqlCommand(s, kn.cnn);
                thuc_hien.ExecuteNonQuery();
                kn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("ahihi do ngoc");
            }
           
        }
        private void DK_Load(object sender, EventArgs e)
        {
           
            kn.cnn = new SqlConnection(kn.cnnStr);
            load_cbbMaPhong();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            kn.cnn = new SqlConnection(kn.cnnStr);
            them();
        }
    }
}
