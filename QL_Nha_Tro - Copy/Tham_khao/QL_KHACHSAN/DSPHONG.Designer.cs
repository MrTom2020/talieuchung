namespace QL_KHACHSAN
{
    partial class frmDSPHONG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSPHONG = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMAPHONG = new System.Windows.Forms.TextBox();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.btnThemphong = new System.Windows.Forms.Button();
            this.btnSuaphong = new System.Windows.Forms.Button();
            this.btnXoaphong = new System.Windows.Forms.Button();
            this.btnLuuphong = new System.Windows.Forms.Button();
            this.btnThoatphong = new System.Windows.Forms.Button();
            this.cmbTINHTRANG = new System.Windows.Forms.ComboBox();
            this.cmbMALOAI = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnKiemtraphong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPHONG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHÒNG";
            // 
            // dgvDSPHONG
            // 
            this.dgvDSPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPHONG.Location = new System.Drawing.Point(280, 60);
            this.dgvDSPHONG.Name = "dgvDSPHONG";
            this.dgvDSPHONG.Size = new System.Drawing.Size(419, 227);
            this.dgvDSPHONG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá:";
            // 
            // txtMAPHONG
            // 
            this.txtMAPHONG.Location = new System.Drawing.Point(101, 60);
            this.txtMAPHONG.Name = "txtMAPHONG";
            this.txtMAPHONG.Size = new System.Drawing.Size(100, 20);
            this.txtMAPHONG.TabIndex = 3;
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(101, 146);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(100, 20);
            this.txtGIA.TabIndex = 3;
            this.txtGIA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnThemphong
            // 
            this.btnThemphong.Location = new System.Drawing.Point(20, 187);
            this.btnThemphong.Name = "btnThemphong";
            this.btnThemphong.Size = new System.Drawing.Size(75, 23);
            this.btnThemphong.TabIndex = 4;
            this.btnThemphong.Text = "Thêm";
            this.btnThemphong.UseVisualStyleBackColor = true;
            this.btnThemphong.Click += new System.EventHandler(this.btnThemphong_Click);
            // 
            // btnSuaphong
            // 
            this.btnSuaphong.Location = new System.Drawing.Point(101, 187);
            this.btnSuaphong.Name = "btnSuaphong";
            this.btnSuaphong.Size = new System.Drawing.Size(75, 23);
            this.btnSuaphong.TabIndex = 4;
            this.btnSuaphong.Text = "Sửa và lưu";
            this.btnSuaphong.UseVisualStyleBackColor = true;
            this.btnSuaphong.Click += new System.EventHandler(this.btnSuaphong_Click);
            // 
            // btnXoaphong
            // 
            this.btnXoaphong.Location = new System.Drawing.Point(182, 187);
            this.btnXoaphong.Name = "btnXoaphong";
            this.btnXoaphong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaphong.TabIndex = 4;
            this.btnXoaphong.Text = "Xóa";
            this.btnXoaphong.UseVisualStyleBackColor = true;
            this.btnXoaphong.Click += new System.EventHandler(this.btnXoaphong_Click);
            // 
            // btnLuuphong
            // 
            this.btnLuuphong.Location = new System.Drawing.Point(20, 229);
            this.btnLuuphong.Name = "btnLuuphong";
            this.btnLuuphong.Size = new System.Drawing.Size(75, 23);
            this.btnLuuphong.TabIndex = 4;
            this.btnLuuphong.Text = "Lưu";
            this.btnLuuphong.UseVisualStyleBackColor = true;
            this.btnLuuphong.Click += new System.EventHandler(this.btnLuuphong_Click);
            // 
            // btnThoatphong
            // 
            this.btnThoatphong.Location = new System.Drawing.Point(182, 229);
            this.btnThoatphong.Name = "btnThoatphong";
            this.btnThoatphong.Size = new System.Drawing.Size(75, 23);
            this.btnThoatphong.TabIndex = 4;
            this.btnThoatphong.Text = "Thoát";
            this.btnThoatphong.UseVisualStyleBackColor = true;
            this.btnThoatphong.Click += new System.EventHandler(this.btnThoatphong_Click);
            // 
            // cmbTINHTRANG
            // 
            this.cmbTINHTRANG.FormattingEnabled = true;
            this.cmbTINHTRANG.Items.AddRange(new object[] {
            "tất cả",
            "trống",
            "đang dùng",
            "hỏng"});
            this.cmbTINHTRANG.Location = new System.Drawing.Point(101, 91);
            this.cmbTINHTRANG.Name = "cmbTINHTRANG";
            this.cmbTINHTRANG.Size = new System.Drawing.Size(100, 21);
            this.cmbTINHTRANG.TabIndex = 5;
            this.cmbTINHTRANG.SelectedIndexChanged += new System.EventHandler(this.cmbTINHTRANG_SelectedIndexChanged);
            // 
            // cmbMALOAI
            // 
            this.cmbMALOAI.FormattingEnabled = true;
            this.cmbMALOAI.Items.AddRange(new object[] {
            "tất cả",
            "VIP3",
            "VIP2",
            "VIP1"});
            this.cmbMALOAI.Location = new System.Drawing.Point(101, 119);
            this.cmbMALOAI.Name = "cmbMALOAI";
            this.cmbMALOAI.Size = new System.Drawing.Size(100, 21);
            this.cmbMALOAI.TabIndex = 5;
            this.cmbMALOAI.SelectedIndexChanged += new System.EventHandler(this.cmbMALOAI_SelectedIndexChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(101, 229);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Tag = "";
            this.btnTim.Text = "Tìm phòng";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(20, 264);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnKiemtraphong
            // 
            this.btnKiemtraphong.Location = new System.Drawing.Point(101, 264);
            this.btnKiemtraphong.Name = "btnKiemtraphong";
            this.btnKiemtraphong.Size = new System.Drawing.Size(156, 23);
            this.btnKiemtraphong.TabIndex = 4;
            this.btnKiemtraphong.Tag = "";
            this.btnKiemtraphong.Text = "Duyệt phòng theo tình trạng";
            this.btnKiemtraphong.UseVisualStyleBackColor = true;
            this.btnKiemtraphong.Click += new System.EventHandler(this.btnKiemtraphong_Click);
            // 
            // frmDSPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 299);
            this.Controls.Add(this.cmbMALOAI);
            this.Controls.Add(this.cmbTINHTRANG);
            this.Controls.Add(this.btnThoatphong);
            this.Controls.Add(this.btnXoaphong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnSuaphong);
            this.Controls.Add(this.btnKiemtraphong);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLuuphong);
            this.Controls.Add(this.btnThemphong);
            this.Controls.Add(this.txtGIA);
            this.Controls.Add(this.txtMAPHONG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSPHONG);
            this.Controls.Add(this.label1);
            this.Name = "frmDSPHONG";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Phòng";
            this.Load += new System.EventHandler(this.frmDSPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPHONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSPHONG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMAPHONG;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.Button btnThemphong;
        private System.Windows.Forms.Button btnSuaphong;
        private System.Windows.Forms.Button btnXoaphong;
        private System.Windows.Forms.Button btnLuuphong;
        private System.Windows.Forms.Button btnThoatphong;
        private System.Windows.Forms.ComboBox cmbTINHTRANG;
        private System.Windows.Forms.ComboBox cmbMALOAI;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnKiemtraphong;
    }
}