namespace QuanLyHocSinh.GUI.ChiTiet
{
    partial class frmDiemHS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemGiuaKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuoiKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenHS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDanhSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 352);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbTenHS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 74);
            this.panel2.TabIndex = 1;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa,
            this.colTen,
            this.colDiemMieng,
            this.colDiemGiuaKi,
            this.colCuoiKi,
            this.colTongKet});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(924, 352);
            this.dgvDanhSach.TabIndex = 1;
            this.dgvDanhSach.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellEndEdit);
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 30F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colMa
            // 
            this.colMa.FillWeight = 80F;
            this.colMa.HeaderText = "Mã Môn";
            this.colMa.Name = "colMa";
            // 
            // colTen
            // 
            this.colTen.FillWeight = 200F;
            this.colTen.HeaderText = "Tên Môn Học";
            this.colTen.Name = "colTen";
            // 
            // colDiemMieng
            // 
            this.colDiemMieng.FillWeight = 70F;
            this.colDiemMieng.HeaderText = "Điểm Miệng";
            this.colDiemMieng.Name = "colDiemMieng";
            // 
            // colDiemGiuaKi
            // 
            this.colDiemGiuaKi.FillWeight = 70F;
            this.colDiemGiuaKi.HeaderText = "Giữa Kì";
            this.colDiemGiuaKi.Name = "colDiemGiuaKi";
            // 
            // colCuoiKi
            // 
            this.colCuoiKi.FillWeight = 70F;
            this.colCuoiKi.HeaderText = "Cuối Kì";
            this.colCuoiKi.Name = "colCuoiKi";
            // 
            // colTongKet
            // 
            this.colTongKet.FillWeight = 70F;
            this.colTongKet.HeaderText = "Tổng Kết";
            this.colTongKet.Name = "colTongKet";
            // 
            // lbTenHS
            // 
            this.lbTenHS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHS.Location = new System.Drawing.Point(158, 18);
            this.lbTenHS.Name = "lbTenHS";
            this.lbTenHS.Size = new System.Drawing.Size(266, 33);
            this.lbTenHS.TabIndex = 0;
            this.lbTenHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng Điểm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDiemHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDiemHS";
            this.Text = "frmDiemHS";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemGiuaKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuoiKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongKet;
        private System.Windows.Forms.Label lbTenHS;
        private System.Windows.Forms.Label label1;
    }
}