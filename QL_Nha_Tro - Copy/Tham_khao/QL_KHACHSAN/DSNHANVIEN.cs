using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KHACHSAN
{
    public partial class frmDSNHANVIEN : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DTC\Desktop\báo cáo winform\QL_KHACHSAN\QL_KHACHSAN.mdf;Integrated Security=True");
        public frmDSNHANVIEN()
        {
            InitializeComponent();
        }

        private void btnThoatphong_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                conn.Close();   	//Đóng kết nối
                conn.Dispose(); 	//Giải phóng tài nguyên
                conn = null;
                this.Close();
            }
        }

        private void frmDSNHANVIEN_Load(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MANV AS 'Mã nhân viên', TENNV AS 'Tên nhân viên', GIOITINH AS 'Giới tính', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại', NGAYSINH AS 'Ngày sinh' FROM NHANVIEN ",conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSNHANVIEN.DataSource = table;
            cmbGIOITINH.Text = "tất cả";
        }

        private void dgvDSNHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void btnTim2_Click(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MANV AS 'Mã nhân viên', TENNV AS 'Tên nhân viên', GIOITINH AS 'Giới tính', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại', NGAYSINH AS 'Ngày sinh' FROM NHANVIEN WHERE MANV = '" + txtMANV.Text + "'", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSNHANVIEN.DataSource = table;
            txtTENNV.Text = dgvDSNHANVIEN.Rows[0].Cells[1].Value.ToString();
            if(dgvDSNHANVIEN.Rows[0].Cells[2].Value.ToString() == "True")
            {
                cmbGIOITINH.Text = "Nam";
            } 
            else
            {
                cmbGIOITINH.Text = "Nữ";
            }    
            txtDIACHI.Text = dgvDSNHANVIEN.Rows[0].Cells[3].Value.ToString();
            txtSDT.Text = dgvDSNHANVIEN.Rows[0].Cells[4].Value.ToString();
            txtNGAYSINH.Text = dgvDSNHANVIEN.Rows[0].Cells[5].Value.ToString().Substring(0, 10);
        }

        private void cmbGIOITINH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGIOITINH.Text == "Nam")
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MANV AS 'Mã nhân viên', TENNV AS 'Tên nhân viên', GIOITINH AS 'Giới tính', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại', NGAYSINH AS 'Ngày sinh' FROM NHANVIEN WHERE GIOITINH = 'True'", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvDSNHANVIEN.DataSource = table;
            }
            if (cmbGIOITINH.Text == "Nữ")
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MANV AS 'Mã nhân viên', TENNV AS 'Tên nhân viên', GIOITINH AS 'Giới tính', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại', NGAYSINH AS 'Ngày sinh' FROM NHANVIEN WHERE GIOITINH = 'False'", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvDSNHANVIEN.DataSource = table;
            }
            if (cmbGIOITINH.Text == "tất cả")
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MANV AS 'Mã nhân viên', TENNV AS 'Tên nhân viên', GIOITINH AS 'Giới tính', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại', NGAYSINH AS 'Ngày sinh' FROM NHANVIEN", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvDSNHANVIEN.DataSource = table;
            }



        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {
            btnSuaNhanvien.Enabled = false;
            btnTimNhanVien.Enabled = false;
            btnXoaNhanVien.Enabled = false;
            txtTENNV.Text = "";
            txtSDT.Text = "";
            txtNGAYSINH.Text = "";
            txtMANV.Text = "";
            txtDIACHI.Text = "";
            cmbGIOITINH.Text = "";
        }
    }
}
