namespace QuanLyHocSinh.GUI.Them
{
    partial class frmThemHS
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbLopHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(323, 307);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(121, 47);
            this.btnDong.TabIndex = 151;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(94, 307);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(121, 47);
            this.btnXacNhan.TabIndex = 149;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Checked = false;
            this.dtpNgaySinh.CustomFormat = "DD/MM/YYYY";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(247, 171);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 30);
            this.dtpNgaySinh.TabIndex = 154;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(247, 110);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(186, 30);
            this.cbGioiTinh.TabIndex = 156;
            this.cbGioiTinh.Text = "Lựa chọn giới tính";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 153;
            this.label4.Text = "Giới Tính:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 150;
            this.label2.Text = "Ngày sinh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 147;
            this.label1.Text = "Họ và tên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(247, 54);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 30);
            this.txtHoTen.TabIndex = 145;
            // 
            // cbLopHoc
            // 
            this.cbLopHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLopHoc.FormattingEnabled = true;
            this.cbLopHoc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLopHoc.Location = new System.Drawing.Point(247, 233);
            this.cbLopHoc.Name = "cbLopHoc";
            this.cbLopHoc.Size = new System.Drawing.Size(186, 30);
            this.cbLopHoc.TabIndex = 158;
            this.cbLopHoc.Text = "Lựa chọn lớp";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 157;
            this.label3.Text = "Lớp Học:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 417);
            this.Controls.Add(this.cbLopHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoTen);
            this.Name = "frmThemHS";
            this.Text = "frmThemHS";
            this.Load += new System.EventHandler(this.frmThemHS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbLopHoc;
        private System.Windows.Forms.Label label3;
    }
}