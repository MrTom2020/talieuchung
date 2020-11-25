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
    public partial class frmHOADON : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DTC\Desktop\báo cáo winform\QL_KHACHSAN\QL_KHACHSAN.mdf;Integrated Security=True");
        public frmHOADON()
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

        private void frmHOADON_Load(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvHOADON.DataSource = table;
            txtSOCMND.Text = "";
            txtMAHD.Text = "";
            txtMANV.Text = "";
            txtMAPHONG.Text = "";
        }

        private void btnTim4_Click(object sender, EventArgs e)
        {
            if(txtMAHD.Text != "")
            {
                if(txtMANV.Text != "")
                {
                    if(txtSOCMND.Text != "")
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND MAHD = '" + txtMAHD.Text + "' AND HOADON.MANV = '" + txtMANV.Text + "' AND HOADON.SOCMND = '" + txtSOCMND.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                    else
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND MAHD = '" + txtMAHD.Text + "' AND HOADON.MANV = '" + txtMANV.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                }
                else
                {
                    if (txtSOCMND.Text != "")
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND MAHD = '" + txtMAHD.Text + "' AND HOADON.SOCMND = '" + txtSOCMND.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                    else
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND MAHD = '" + txtMAHD.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                }
            }
            else
            {
                if (txtMANV.Text != "")
                {
                    if (txtSOCMND.Text != "")
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND HOADON.MANV = '" + txtMANV.Text + "' AND HOADON.SOCMND = '" + txtSOCMND.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                    else
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND HOADON.MANV = '" + txtMANV.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                }
                else
                {
                    if (txtSOCMND.Text != "")
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND HOADON.SOCMND = '" + txtSOCMND.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }
                    else
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvHOADON.DataSource = table;
                    }    
                }
            }
        }

        private void btnXoaphong_Click(object sender, EventArgs e)
        {
            if(txtMAPHONG.Text == "")
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvHOADON.DataSource = table;
            }
            else
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MAHD AS 'Mã hóa đơn', TENNV AS 'Nhân viên thanh toán', HOTEN AS 'Tên khách hàng', GIOVAO AS 'Giờ vào',  HOADON.MAPHONG AS 'Mã phòng' FROM HOADON, KHACHHANG, NHANVIEN, PHONG, LOAIPHONG WHERE HOADON.SOCMND = KHACHHANG.SOCMND AND HOADON.MAPHONG = PHONG.MAPHONG AND HOADON.MANV = NHANVIEN.MANV AND PHONG.MALOAI = LOAIPHONG.MALOAI AND HOADON.MAPHONG = '" + txtMAPHONG.Text + "'", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvHOADON.DataSource = table;
            }    
        }
    }
}
