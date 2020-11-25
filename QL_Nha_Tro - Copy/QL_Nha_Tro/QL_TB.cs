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
    public partial class QL_TB : Form
    {
        public QL_TB()
        {
            InitializeComponent();
        }
        string sql;
        SqlDataReader docDuLieu;
        SqlDataAdapter capNhat;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        string chuoi = @"Data Source=DESKTOP-V6FNPVC;Initial Catalog=QL_NT_2;Integrated Security=True";
        int i = 0;

       

        private void QL_TB_Load(object sender, EventArgs e)
        {
  
            ketnoi = new SqlConnection(chuoi);

            hiethi();

        }
        
        public void hiethi()
        {
            listView1.Items.Clear();      
            sql = @"select MaPhong,SoLuongToiDa,Den,VoiNuoc,DongHo,KhoNuoc FROM Phong";
            thuchien = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            docDuLieu = thuchien.ExecuteReader();
            while(docDuLieu.Read())
            {
                listView1.Items.Add(docDuLieu[0].ToString());
                listView1.Items[i].SubItems.Add(docDuLieu[1].ToString());
                listView1.Items[i].SubItems.Add(docDuLieu[2].ToString());
                listView1.Items[i].SubItems.Add(docDuLieu[3].ToString());
                listView1.Items[i].SubItems.Add(docDuLieu[4].ToString());
                listView1.Items[i].SubItems.Add(docDuLieu[5].ToString());
               
                i++;
            }
            ketnoi.Close();

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = listView1.SelectedItems[0].SubItems[0].Text;

            if (listView1.SelectedItems[1].SubItems[1].Text == "0")
            {
                checkdenngon.Checked = true;
            }
            else
                checkhu.Checked = true;
            if (listView1.SelectedItems[2].SubItems[2].Text == "0")
            {
                checkhukhoanuoc.Checked = true;
            }
            else
                checkhukhoanuoc.Checked = true;
            if (listView1.SelectedItems[3].SubItems[3].Text == "0")
            {
                checkcuangon.Checked = true;
            }
            else
                cbCuahu.Checked = true;
            if (listView1.SelectedItems[4].SubItems[4].Text == "0")
            {
                checkvoinuocngon.Checked = true;
            }
            else
                checkhuvoinuoc.Checked = true;
            if (listView1.SelectedItems[5].SubItems[5].Text == "0")
            {
                checkdhngon.Checked = true;
            }
            else
                checkhudongho.Checked = true;
        }

       


        private void btsua_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            
        }
    }
}
