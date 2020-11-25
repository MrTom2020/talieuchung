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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi;
        SqlCommand thuchien;
        string chon;
        string chuoi = @"Data Source=DESKTOP-V6FNPVC;Initial Catalog=QL_NT_2;Integrated Security=True";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {


                openFileDialog1.ShowDialog();

                chon = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(chon);
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoi);
            show(cbbmakt);
        }
        void lammoi()
        {
            txtdc.Text = txtgmail.Text = txtdc.Text = txtMakh.Text = txttenkh.Text = txtsdt.Text = txtnghe.Text = txtcmnd.Text = string.Empty;
            pictureBox1.Image = null;
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            lammoi();
           
        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = int.Parse(txtMakh.Text);
                int cmnd = int.Parse(txtcmnd.Text);
                int sdt = int.Parse(txtsdt.Text);
                bool tinhtrang = true;
                ketnoi.Open();

                thuchien = new SqlCommand("themkh", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Parameters.AddWithValue("@makh", SqlDbType.Int).Value = makh;
                thuchien.Parameters.AddWithValue("@tenkh", SqlDbType.NVarChar).Value = txttenkh.Text;
                thuchien.Parameters.AddWithValue("@cmnd", SqlDbType.Int).Value = cmnd;
                thuchien.Parameters.AddWithValue("@sdt", SqlDbType.Int).Value = sdt;
                thuchien.Parameters.AddWithValue("@nghenghiep", SqlDbType.NVarChar).Value = txtnghe.Text;
                thuchien.Parameters.AddWithValue("@gmail", SqlDbType.NVarChar).Value = txtgmail.Text;
                thuchien.Parameters.AddWithValue("@hinh", SqlDbType.NVarChar).Value = chon;
                thuchien.Parameters.AddWithValue("@tinhtrang", SqlDbType.Bit).Value = tinhtrang;
                thuchien.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = txtdc.Text;
                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                ketnoi.Close();
                lammoi();
            }
            catch
            {

            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            


                int makh = int.Parse(txtMakh.Text);
                int cmnd = int.Parse(txtcmnd.Text);
                int sdt = int.Parse(txtsdt.Text);
                bool tinhtrang = true;
                ketnoi.Open();
             
                thuchien = new SqlCommand("cap_nhat_thong_tin_kh", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Parameters.AddWithValue("@makh", SqlDbType.Int).Value = makh;
                thuchien.Parameters.AddWithValue("@tenkh", SqlDbType.NVarChar).Value = txttenkh.Text;
                thuchien.Parameters.AddWithValue("@cmnd", SqlDbType.Int).Value = cmnd;
                thuchien.Parameters.AddWithValue("@sdt", SqlDbType.Int).Value = sdt;
                thuchien.Parameters.AddWithValue("@nghenghiep", SqlDbType.NVarChar).Value = txtnghe.Text;
                thuchien.Parameters.AddWithValue("@gmail", SqlDbType.NVarChar).Value = txtgmail.Text;
                thuchien.Parameters.AddWithValue("@hinh", SqlDbType.NVarChar).Value = chon;
                thuchien.Parameters.AddWithValue("@tinhtrang", SqlDbType.Bit).Value = tinhtrang;
                thuchien.Parameters.AddWithValue("@diachi", SqlDbType.NVarChar).Value = txtdc.Text;
                thuchien.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                ketnoi.Close();
                lammoi();
           
           
        }

        private void cbbmakt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lammoi();
            try
            {
                ketnoi.Open();
                thuchien = new SqlCommand("timkh", ketnoi);
                thuchien.CommandType = CommandType.StoredProcedure;
                thuchien.Parameters.AddWithValue("@ma", SqlDbType.Int).Value = cbbmakt.SelectedItem.ToString();
                SqlDataReader doc = thuchien.ExecuteReader();
                while (doc.Read())
                {
                    txtMakh.Text = doc[0].ToString();
                    txttenkh.Text = doc[1].ToString();
                    txtcmnd.Text = doc[2].ToString();
                    txtsdt.Text = doc[3].ToString();
                    txtdc.Text = doc[8].ToString();
                    txtgmail.Text = doc[5].ToString();
                    txtnghe.Text = doc[4].ToString();
                    pictureBox1.Image = Image.FromFile(doc[6].ToString());

                }
            }
            catch
            {

            }
            
            ketnoi.Close();
        }
        void show(ComboBox cb)
        {
            
            ketnoi.Open();

            thuchien = new SqlCommand("dsmakt", ketnoi);
            thuchien.CommandType = CommandType.StoredProcedure;
            SqlDataReader doc = thuchien.ExecuteReader();
            while(doc.Read())
            {
                cbbmakt.Items.Add(doc[0].ToString());
            }
            MessageBox.Show("Danh sách đã được cập nhật");
            ketnoi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quan_phong_tro q = new Quan_phong_tro();
            q.ShowDialog();
        }
    }
}
