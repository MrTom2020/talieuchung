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
    public partial class frmDSPHONG : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DTC\Desktop\báo cáo winform\QL_KHACHSAN\QL_KHACHSAN.mdf;Integrated Security=True");
        public frmDSPHONG()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void frmDSPHONG_Load(object sender, EventArgs e)
        {
            btnLuuphong.Enabled = false;
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;
        }

        private void cmbTINHTRANG_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMALOAI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI AND MAPHONG = '" + txtMAPHONG.Text + "'", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;
            if (dgvDSPHONG.Rows[0].Cells[1].Value != null)
            {
            cmbTINHTRANG.Text = dgvDSPHONG.Rows[0].Cells[1].Value.ToString();
            cmbMALOAI.Text = dgvDSPHONG.Rows[0].Cells[2].Value.ToString();
            txtGIA.Text = dgvDSPHONG.Rows[0].Cells[3].Value.ToString();
            }    
            
        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {
            btnLuuphong.Enabled = true;
            btnSuaphong.Enabled = false;
            btnXoaphong.Enabled = false;
            btnTim.Enabled = false;
            btnKiemtraphong.Enabled = false;
            txtMAPHONG.Text = "";
            txtGIA.Enabled = false;
            cmbMALOAI.Text = "";
            cmbTINHTRANG.Text = "trống";
            cmbTINHTRANG.Enabled = false;
        }

        private void btnLuuphong_Click(object sender, EventArgs e)
        {
            //mở kết nối
            conn.Open();
            //tạo câu lệnh truy vấn để thêm vào cơ sở dữ liệu
            //string sqla = "INSERT INTO LOAIPHONG (MALOAI, GIA)" + "VALUES (@maloai, @gia)";
            //using (SqlCommand cmda = new SqlCommand(sqla, conn))
            //{
            //    tạo tham số để thêm vào cơ sở dữ liệu
            //    cmda.Parameters.Add("@maloai", SqlDbType.Char).Value = cmbMALOAI.Text;
            //    cmda.Parameters.Add("@gia", SqlDbType.Decimal).Value = txtGIA.Text;
            //    cmda.ExecuteNonQuery();
            //}
            //sử lí khi thêm mã phòng bị trùng
            //cập nhật dữ liệu vào cơ sở dữ liệu
            string sqlb = "INSERT INTO PHONG (MAPHONG, TINHTRANG,MALOAI) " + " VALUES (@maphong, @tinhtrang, @maloai) ";
            using (SqlCommand cmdb = new SqlCommand(sqlb, conn))
                {
                    //tạo tham số để thêm vào cơ sở dữ liệu
                    cmdb.Parameters.Add("@maphong", SqlDbType.Char).Value = txtMAPHONG.Text;
                    cmdb.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = cmbTINHTRANG.Text;
                    cmdb.Parameters.Add("@maloai", SqlDbType.Char).Value = cmbMALOAI.Text;
                    cmdb.ExecuteNonQuery();
                }   
            
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;
            //đóng kết nối
            conn.Close();
        }

        private void btnKiemtraphong_Click(object sender, EventArgs e)
        {
            if (cmbTINHTRANG.Text != "tất cả" && cmbMALOAI.Text != "tất cả")
            {
                //tạo câu lệnh truy vấn để lấy dữ liệu
                var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI AND TINHTRANG = N'" + cmbTINHTRANG.Text + "' AND LOAIPHONG.MALOAI = '" + cmbMALOAI.Text + "'", conn);
                //tạo bảng trong win form để chứa dữ liệu
                var table = new DataTable();
                //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                dap.Fill(table);
                //hiển thị những thứ cần hiển thị
                dgvDSPHONG.DataSource = table;
            }
            else
            {
                if (cmbTINHTRANG.Text != "tất cả" && cmbMALOAI.Text == "tất cả")
                {
                    //tạo câu lệnh truy vấn để lấy dữ liệu
                    var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI AND TINHTRANG = N'" + cmbTINHTRANG.Text + "'", conn);
                    //tạo bảng trong win form để chứa dữ liệu
                    var table = new DataTable();
                    //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                    dap.Fill(table);
                    //hiển thị những thứ cần hiển thị
                    dgvDSPHONG.DataSource = table;
                }
                else
                {
                    if (cmbTINHTRANG.Text == "tất cả" && cmbMALOAI.Text != "tất cả")
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI AND LOAIPHONG.MALOAI = '" + cmbMALOAI.Text + "'", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvDSPHONG.DataSource = table;
                    }
                    else
                    {
                        //tạo câu lệnh truy vấn để lấy dữ liệu
                        var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
                        //tạo bảng trong win form để chứa dữ liệu
                        var table = new DataTable();
                        //đổ dữ liệu từ bảng của Sql sang bảng của Win form
                        dap.Fill(table);
                        //hiển thị những thứ cần hiển thị
                        dgvDSPHONG.DataSource = table;
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnLuuphong.Enabled = false;
            btnSuaphong.Enabled = true;
            btnXoaphong.Enabled = true;
            btnTim.Enabled = true;
            btnKiemtraphong.Enabled = true;
            txtMAPHONG.Text = "";
            txtGIA.Text = "";
            txtGIA.Enabled = true;
            cmbMALOAI.Text = "";
            cmbTINHTRANG.Text = "";
            cmbTINHTRANG.Enabled = true;
            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;

        }

        private void btnSuaphong_Click(object sender, EventArgs e)
        {
            conn.Open();
            //sửa dữ liệu
            string sqlb = "UPDATE PHONG " + " SET TINHTRANG = @tinhtrang, MALOAI = @maloai WHERE  MAPHONG = @maphong";
            using (SqlCommand cmdb = new SqlCommand(sqlb, conn))
            {
                //tạo tham số để thêm vào cơ sở dữ liệu
                cmdb.Parameters.Add("@maphong", SqlDbType.Char).Value = txtMAPHONG.Text;
                cmdb.Parameters.Add("@tinhtrang", SqlDbType.NVarChar).Value = cmbTINHTRANG.Text;
                cmdb.Parameters.Add("@maloai", SqlDbType.Char).Value = cmbMALOAI.Text;
                cmdb.ExecuteNonQuery();
            }

            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;
            conn.Close();
        }

        private void btnXoaphong_Click(object sender, EventArgs e)
        {
            conn.Open();
            //sửa dữ liệu
            string sqlb = "DELETE FROM PHONG " + " WHERE  MAPHONG = @maphong";
            using (SqlCommand cmdb = new SqlCommand(sqlb, conn))
            {
                //tạo tham số để thêm vào cơ sở dữ liệu
                cmdb.Parameters.Add("@maphong", SqlDbType.Char).Value = txtMAPHONG.Text;
                cmdb.ExecuteNonQuery();
            }

            //tạo câu lệnh truy vấn để lấy dữ liệu
            var dap = new SqlDataAdapter("SELECT MAPHONG AS 'Mã phòng', TINHTRANG AS 'Tình Trạng', PHONG.MALOAI AS 'Loại phòng', GIA AS 'Giá' FROM PHONG, LOAIPHONG WHERE LOAIPHONG.MALOAI = PHONG.MALOAI", conn);
            //tạo bảng trong win form để chứa dữ liệu
            var table = new DataTable();
            //đổ dữ liệu từ bảng của Sql sang bảng của Win form
            dap.Fill(table);
            //hiển thị những thứ cần hiển thị
            dgvDSPHONG.DataSource = table;
            conn.Close();
        }
    }
}
