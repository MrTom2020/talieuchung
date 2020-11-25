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
    public partial class frmDSKHACHHANG : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\HKII_Nam_2\Windown_Form\QL_Nha_Tro\Tham_khao\QL_KHACHSAN\QL_KHACHSAN.mdf;Integrated Security=True");
        public frmDSKHACHHANG()
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

        private void frmDSKHACHHANG_Load(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT SOCMND AS 'Mã khách hàng', HOTEN AS 'Họ và tên khách hàng', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại' FROM KHACHHANG ", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSKHACHHANG.DataSource = table;
        }

        private void btnTim3_Click(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT SOCMND AS 'Mã khách hàng', HOTEN AS 'Họ và tên khách hàng', DIACHI AS 'Địa chỉ', SDT AS 'Số điện thoại' FROM KHACHHANG WHERE SOCMND = '" + txtSOCMND.Text + "'", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSKHACHHANG.DataSource = table;
        }
    }
}
