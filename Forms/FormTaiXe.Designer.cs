﻿
namespace PJ_For_Wang_Test.Forms
{
    partial class FormTaiXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblTenDuAn = new System.Windows.Forms.Label();
            this.lblMaDuAn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvQLTX = new System.Windows.Forms.DataGridView();
            this.lbl_tx_id = new System.Windows.Forms.Label();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKyHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHetHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTX)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaTX
            // 
            this.txtMaTX.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaTX.Location = new System.Drawing.Point(57, 90);
            this.txtMaTX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(126, 22);
            this.txtMaTX.TabIndex = 71;
            this.txtMaTX.Text = "Tìm kiếm";
            this.txtMaTX.TextChanged += new System.EventHandler(this.txtMaTX_TextChanged);
            this.txtMaTX.Enter += new System.EventHandler(this.txtMaTX_Enter);
            this.txtMaTX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaTX_KeyDown);
            this.txtMaTX.Leave += new System.EventHandler(this.txtMaTX_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-168, -4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 70;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(808, -74);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 69;
            this.button5.Text = "Gán Xe";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, -74);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 68;
            this.button2.Text = "Hủy Gán";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(-172, -57);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(151, 20);
            this.lblThongTin.TabIndex = 63;
            this.lblThongTin.Text = "Danh sách tài xế";
            // 
            // lblTenDuAn
            // 
            this.lblTenDuAn.AutoSize = true;
            this.lblTenDuAn.Location = new System.Drawing.Point(-100, -90);
            this.lblTenDuAn.Name = "lblTenDuAn";
            this.lblTenDuAn.Size = new System.Drawing.Size(46, 17);
            this.lblTenDuAn.TabIndex = 62;
            this.lblTenDuAn.Text = "Tài xế";
            // 
            // lblMaDuAn
            // 
            this.lblMaDuAn.AutoSize = true;
            this.lblMaDuAn.Location = new System.Drawing.Point(-171, -90);
            this.lblMaDuAn.Name = "lblMaDuAn";
            this.lblMaDuAn.Size = new System.Drawing.Size(65, 17);
            this.lblMaDuAn.TabIndex = 61;
            this.lblMaDuAn.Text = "Quản lý /";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Quản lý / Tài Xế";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(789, 90);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 77;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(961, 90);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(881, 90);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 24);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvQLTX
            // 
            this.dgvQLTX.AllowUserToAddRows = false;
            this.dgvQLTX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLTX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLTX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQLTX.ColumnHeadersHeight = 30;
            this.dgvQLTX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLTX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTXDataGridViewTextBoxColumn,
            this.tenTXDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.ngayKyHDDataGridViewTextBoxColumn,
            this.ngayHetHDDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn,
            this.Column1,
            this.cCCDDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dgvQLTX.EnableHeadersVisualStyles = false;
            this.dgvQLTX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dgvQLTX.Location = new System.Drawing.Point(54, 135);
            this.dgvQLTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLTX.Name = "dgvQLTX";
            this.dgvQLTX.ReadOnly = true;
            this.dgvQLTX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQLTX.RowHeadersVisible = false;
            this.dgvQLTX.RowHeadersWidth = 62;
            this.dgvQLTX.RowTemplate.Height = 28;
            this.dgvQLTX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLTX.Size = new System.Drawing.Size(1184, 304);
            this.dgvQLTX.TabIndex = 79;
            this.dgvQLTX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLTX_CellClick_1);
            this.dgvQLTX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLTX_CellContentClick);
            // 
            // lbl_tx_id
            // 
            this.lbl_tx_id.AutoSize = true;
            this.lbl_tx_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tx_id.Location = new System.Drawing.Point(510, 93);
            this.lbl_tx_id.Name = "lbl_tx_id";
            this.lbl_tx_id.Size = new System.Drawing.Size(46, 17);
            this.lbl_tx_id.TabIndex = 80;
            this.lbl_tx_id.Text = "label2";
            this.lbl_tx_id.Visible = false;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(189, 89);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(121, 24);
            this.cbtrangthai.TabIndex = 81;
            this.cbtrangthai.SelectedIndexChanged += new System.EventHandler(this.cbtrangthai_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearch.Location = new System.Drawing.Point(329, 88);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 82;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.FillWeight = 74.33148F;
            this.maTXDataGridViewTextBoxColumn.HeaderText = "Mã Tài Xế";
            this.maTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            this.maTXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenTXDataGridViewTextBoxColumn
            // 
            this.tenTXDataGridViewTextBoxColumn.DataPropertyName = "TenTX";
            this.tenTXDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.tenTXDataGridViewTextBoxColumn.HeaderText = "Tên Tài Xế";
            this.tenTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tenTXDataGridViewTextBoxColumn.Name = "tenTXDataGridViewTextBoxColumn";
            this.tenTXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayKyHDDataGridViewTextBoxColumn
            // 
            this.ngayKyHDDataGridViewTextBoxColumn.DataPropertyName = "NgayKyHD";
            this.ngayKyHDDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.ngayKyHDDataGridViewTextBoxColumn.HeaderText = "Ngày Ký HĐ";
            this.ngayKyHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayKyHDDataGridViewTextBoxColumn.Name = "ngayKyHDDataGridViewTextBoxColumn";
            this.ngayKyHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayHetHDDataGridViewTextBoxColumn
            // 
            this.ngayHetHDDataGridViewTextBoxColumn.DataPropertyName = "NgayHetHD";
            this.ngayHetHDDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.ngayHetHDDataGridViewTextBoxColumn.HeaderText = "Ngày Hết  HĐ";
            this.ngayHetHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngayHetHDDataGridViewTextBoxColumn.Name = "ngayHetHDDataGridViewTextBoxColumn";
            this.ngayHetHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "trang_thai";
            this.trangThaiDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.trangThaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            this.trangThaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TrangThai";
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.FillWeight = 69.51871F;
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 675);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbtrangthai);
            this.Controls.Add(this.lbl_tx_id);
            this.Controls.Add(this.dgvQLTX);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.lblTenDuAn);
            this.Controls.Add(this.lblMaDuAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTaiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Xế";
            this.Load += new System.EventHandler(this.FormDuAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblTenDuAn;
        private System.Windows.Forms.Label lblMaDuAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvQLTX;
        private System.Windows.Forms.Label lbl_tx_id;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKyHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHetHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
    }
}