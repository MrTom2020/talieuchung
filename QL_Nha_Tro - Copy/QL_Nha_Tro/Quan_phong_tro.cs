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
    public partial class Quan_phong_tro : Form
    {
        public Quan_phong_tro()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi;
        SqlCommand thuchien,thuhien2;
        string chuoi = @"Data Source=DESKTOP-V6FNPVC;Initial Catalog=QL_NT_2;Integrated Security=True";


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("thu_tien_phong_tro_theo_mk", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = comboBox1.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while (doc.Read())
            {
                txtma.Text = doc[2].ToString();
                txtten.Text = doc[1].ToString();
                txttien.Text = doc[4].ToString();
            }
            
            hienthi(txtghichu);
            ketnoi.Close();
        }
        void show(ComboBox cb)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("ds_makt_tt", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
           
            ketnoi.Close();
        }
        void show1(ComboBox cb)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("dsmakt", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while (doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }

            ketnoi.Close();
        }
        void hienthi(TextBox tx)
        {
            ketnoi.Close();
            ketnoi.Open();
            thuhien2 = new SqlCommand("ghi_chu", ketnoi);
            thuhien2.CommandType = CommandType.StoredProcedure;


             thuhien2.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = comboBox1.SelectedItem.ToString();


            SqlDataReader doc = thuhien2.ExecuteReader();


            while (doc.Read())
            {
                tx.Text = (doc[0].ToString());
            }
            ketnoi.Close();
        }
        private void Quan_phong_tro_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoi);
            show(comboBox1);
            show1(cbbmakhach);
            show(comboBox3);
            show2(cbb_ma_phong);
            show3(cbb_xem_ma_phong);
            show5(cbbmaktdk);
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("BẠN CÓ MUỐN CẬP NHẬT", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(tl == DialogResult.Yes)
            {
                bool ch = false;
                if(cyes.Checked == true)
                {
                    ch = true;
                }
                if(cno.Checked == true)
                {
                    ch = false;
                }
                ketnoi.Open();
                thuhien2 = new SqlCommand("cap_nhat_tinh_trang_thanh_toan", ketnoi);
                thuhien2.CommandType = CommandType.StoredProcedure;
                thuhien2.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = comboBox1.SelectedItem.ToString();
                thuhien2.Parameters.AddWithValue("@tinh_trang", SqlDbType.Bit).Value = ch;
                thuhien2.ExecuteNonQuery();
                MessageBox.Show("Cập nhật tình trạng thành công");
                ketnoi.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult tl2 = MessageBox.Show("BẠN CÓ MUỐN THÊM", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(tl2 == DialogResult.Yes)
            {
                bool ch1 = false;
                if(ctt.Checked == true)
                {
                    ch1 = true;
                }
                
                ketnoi.Open();
                thuchien = new SqlCommand("them_hoa_don_thu_tien_phong", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                float sd, sn;
                sd = float.Parse(txtsodien.Text);
                sn = float.Parse(txtsonuoc.Text);
                thuchien.Parameters.AddWithValue("@makh", SqlDbType.Int).Value = cbbmakhach.SelectedItem.ToString();
                thuchien.Parameters.AddWithValue("@tenkh", SqlDbType.NVarChar).Value = txttenkhach.Text;
                thuchien.Parameters.AddWithValue("@ngay_bat_dau_tinh", SqlDbType.Date).Value = dateTimePicker1.Value;
                thuchien.Parameters.AddWithValue("@maphong", SqlDbType.Int).Value = cbbmaphong.SelectedItem.ToString();
                thuchien.Parameters.AddWithValue("@sodien", SqlDbType.Float).Value = sd;
                thuchien.Parameters.AddWithValue("@sonuoc",SqlDbType.Float).Value = sn;
                thuchien.Parameters.AddWithValue("@ngaythanhtoan", SqlDbType.Date).Value = dateTimePicker2.Value;
                thuchien.Parameters.AddWithValue("@tinh_trang", SqlDbType.Bit).Value = ch1;
                thuchien.ExecuteNonQuery();
                MessageBox.Show("THÊM THANH CÔNG");
                ketnoi.Close();
                
            }
        }
        void show_mp(ComboBox cb)
        {
            ketnoi.Close();
            ketnoi.Open();
            thuchien = new SqlCommand("ma_phong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbbmakhach.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while (doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }
        private void cbbmakhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            lamsach();
            ketnoi.Close();
            ketnoi.Open();
            thuchien = new SqlCommand("ten_khach_tro", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbbmakhach.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                txttenkhach.Text = doc[0].ToString();
            }
            show_mp(cbbmaphong);
            ketnoi.Close();
        }
        void lamsach()
        {
            txttenkhach.Text = string.Empty;
            cbbmaphong.Items.Clear();
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lammoi();
            ketnoi.Open();
            thuchien = new SqlCommand("xem_hoa_don_ct", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = comboBox3.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                txt_xem_ngay.Text = doc[5].ToString();
                txt_ngay_tat_toan.Text = doc[6].ToString();
                txt_xem_ten.Text = doc[1].ToString();
                txt_ma_phong.Text = doc[2].ToString();
                txt_so_dien.Text = doc[3].ToString();
                txt_so_nuoc.Text = doc[4].ToString();
                txt_tien.Text = doc[8].ToString();
                
               
            }
           // hienthi(txtgc);
            ketnoi.Close();

        }
        void lammoi()
        {
           // MessageBox.Show("aawaaa");
            foreach (Control c in this.Controls)
            {
               if(c.GetType() == typeof(TextBox))
                {
                    ((TextBox)c).Text = string.Empty;
                    MessageBox.Show("aaaaa");
                }
               if(c.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)c).SelectedIndex = -1;

                }
            }
            
        }
        private void cyes_Click(object sender, EventArgs e)
        {
            if(cyes.Checked == true)
            {
                cno.Checked = false;
            }
        }
        void show2(ComboBox cb)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("dsphong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }
        private void cno_Click(object sender, EventArgs e)
        {
            if(cno.Checked == true)
            {
                cyes.Checked = false;
            }    
        }
        void show3(ComboBox cb)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("xem_ds_khach_da_tra_phong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }
       

       

        private void button2_Click(object sender, EventArgs e)
        {
            txttenkhach.Text = txtsodien.Text = txtsonuoc.Text = string.Empty;
            cbbmaphong.SelectedIndex = -1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtghichu.Text = txtten.Text = txtma.Text = txttien.Text = string.Empty;
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("BẠN CÓ MUỐN CẬP NHẬT", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tl == DialogResult.Yes)
            {
                int maphong, makt;
                float sd, sn;
                makt = int.Parse(txtmak.Text);
                maphong = int.Parse(cbb_ma_phong.SelectedItem.ToString());
                sd = float.Parse(txtdien.Text);
                sn = float.Parse(txtnuoc.Text);
                bool ch3 = false;
                if(c_good.Checked == true)
                {
                    ch3 = true;
                }
                if(c_bad.Checked == true)
                {
                    ch3 = false;
                }
                ketnoi.Open();
                thuchien = new SqlCommand("thanh_toan_tien_khach_tra_phong", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = maphong;
                thuchien.Parameters.AddWithValue("@makh", SqlDbType.Int).Value = makt;
                thuchien.Parameters.AddWithValue("@sonuoc", SqlDbType.Float).Value = sn;
                thuchien.Parameters.AddWithValue("@sodien", SqlDbType.Float).Value = sd;
                thuchien.Parameters.AddWithValue("@ngay_o", SqlDbType.Date).Value = dt_ngay_bd.Value;
                thuchien.Parameters.AddWithValue("@ngay_thanh_toan", SqlDbType.Date).Value = dt_ngay_tinh.Value;
                thuchien.Parameters.AddWithValue("@tenkh", SqlDbType.NVarChar).Value = txttenkt.Text;
                thuchien.Parameters.AddWithValue("@tinh_trang_phong", SqlDbType.Bit).Value = ch3;
                thuchien.ExecuteNonQuery();
                MessageBox.Show("THÔNG TIN ĐÃ ĐƯỢC ĐƯA VÀO CSDL THÀNH CÔNG");

            }
            ketnoi.Close();
        }

        private void c_good_Click(object sender, EventArgs e)
        {
            if(c_good.Checked == true)
            {
                c_bad.Checked = false;
            }
        }

        private void c_bad_Click(object sender, EventArgs e)
        {
            if(c_bad.Checked == true)
            {
                c_good.Checked = false;
            }
        }
      void show5(ComboBox cb)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("dsmakt", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }
        private void cbb_ma_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           ketnoi.Open();
            thuchien = new SqlCommand("ds_khach_tro_chua_tra_phong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbb_ma_phong.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                txtmak.Text = doc[0].ToString();
                txttenkt.Text = doc[1].ToString();
            }
            ketnoi.Close();
        }
        void show4(TextBox tx)
        {
            ketnoi.Close();
            ketnoi.Open();
            thuchien = new SqlCommand("ghi_chu_tra_phong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbb_xem_ma_phong.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                tx.Text = doc[0].ToString();
            }
            ketnoi.Close();
        }
        private void cbb_xem_ma_phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("khach_tra_phong", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbb_xem_ma_phong.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                txt_xem_mak.Text = doc[0].ToString();
                txt_xem_ten_khach.Text = doc[1].ToString();
                txt_xem_so_dien.Text = doc[3].ToString();
                txt_xem_so_nuoc.Text = doc[4].ToString();
                txt_tinh_trang.Text = doc[6].ToString();
                txt_xem_tien.Text = doc[7].ToString();
                txt_ngay_tt.Text = doc[5].ToString();
            }
            show4(txtgc);
            ketnoi.Close();
        }
        void show6(ComboBox cb)
        {
            ketnoi.Close();
            ketnoi.Open();
            thuchien = new SqlCommand("danh_sach_phong_chua_thue", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cb.Items.Add(doc[0].ToString());
            }
            ketnoi.Close();
        }
        private void cbbmaktdk_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoi.Open();
            thuchien = new SqlCommand("khach_dk", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbbmaktdk.SelectedItem.ToString();
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                txttenkhtdk.Text = doc[0].ToString();
                txtcmndktdk.Text = doc[1].ToString();
                txtsdtktdk.Text = doc[2].ToString();
            }
            show6(cbbktdk);
            ketnoi.Close();

        }

        private void btny_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("BẠN CÓ MUỐN THÊM", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tl == DialogResult.Yes)
            {
                ketnoi.Close();
                ketnoi.Open();

                thuchien = new SqlCommand("dk_phong", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Parameters.AddWithValue("@makt", SqlDbType.Int).Value = cbbmaktdk.SelectedItem.ToString();
                thuchien.Parameters.AddWithValue("@map", SqlDbType.Int).Value = cbbktdk.SelectedItem.ToString();
                thuchien.Parameters.AddWithValue("@tenkt", SqlDbType.NVarChar).Value = txttenkhtdk.Text;
                thuchien.Parameters.AddWithValue("@sdt", SqlDbType.Int).Value = txtsdtktdk.Text;
                thuchien.Parameters.AddWithValue("@cmnd", SqlDbType.Int).Value = txtcmndktdk.Text;
                thuchien.Parameters.AddWithValue("@songuoi", SqlDbType.Int).Value = txtsonguidk.Text;
                thuchien.Parameters.AddWithValue("@tiencoc", SqlDbType.Money).Value = txt_tien_coc.Text;
                thuchien.Parameters.AddWithValue("@ngaythue", SqlDbType.Date).Value = dt_dat.Value;
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txt_xem_ngay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
