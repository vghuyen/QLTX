
namespace PJ_For_Wang_Test.Forms
{
    partial class FormQLPT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem2 = new System.Windows.Forms.Button();
            this.dgvQLPT = new System.Windows.Forms.DataGridView();
            this.maPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namSXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soKhungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPhuongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTXDataSet1 = new PJ_For_Wang_Test.QLTXDataSet1();
            this.tb_PhuongTienTableAdapter = new PJ_For_Wang_Test.QLTXDataSet1TableAdapters.tb_PhuongTienTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbl_pt_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhuongTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quản lý / Phương Tiện";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimkiem.Location = new System.Drawing.Point(11, 90);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(112, 22);
            this.txtTimkiem.TabIndex = 17;
            this.txtTimkiem.Text = "Tìm kiếm";
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtMaPT_TextChanged);
            this.txtTimkiem.Enter += new System.EventHandler(this.txtMaPT_Enter);
            this.txtTimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimkiem_KeyDown);
            this.txtTimkiem.Leave += new System.EventHandler(this.txtMaPT_Leave);
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(1, 48);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(202, 20);
            this.lblThongTin.TabIndex = 15;
            this.lblThongTin.Text = "Danh sách phương tiện";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(821, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(902, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem2
            // 
            this.btnThem2.Location = new System.Drawing.Point(731, 84);
            this.btnThem2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem2.Name = "btnThem2";
            this.btnThem2.Size = new System.Drawing.Size(84, 28);
            this.btnThem2.TabIndex = 24;
            this.btnThem2.Text = "Thêm";
            this.btnThem2.UseVisualStyleBackColor = true;
            this.btnThem2.Click += new System.EventHandler(this.btnThem2_Click);
            // 
            // dgvQLPT
            // 
            this.dgvQLPT.AutoGenerateColumns = false;
            this.dgvQLPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLPT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQLPT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLPT.ColumnHeadersHeight = 30;
            this.dgvQLPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPTDataGridViewTextBoxColumn,
            this.maTXDataGridViewTextBoxColumn,
            this.dongXeDataGridViewTextBoxColumn,
            this.mauXeDataGridViewTextBoxColumn,
            this.bienSoDataGridViewTextBoxColumn,
            this.namSXDataGridViewTextBoxColumn,
            this.soKhungDataGridViewTextBoxColumn});
            this.dgvQLPT.DataSource = this.tbPhuongTienBindingSource;
            this.dgvQLPT.EnableHeadersVisualStyles = false;
            this.dgvQLPT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dgvQLPT.Location = new System.Drawing.Point(4, 130);
            this.dgvQLPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLPT.Name = "dgvQLPT";
            this.dgvQLPT.ReadOnly = true;
            this.dgvQLPT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLPT.RowHeadersVisible = false;
            this.dgvQLPT.RowHeadersWidth = 62;
            this.dgvQLPT.RowTemplate.Height = 28;
            this.dgvQLPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLPT.Size = new System.Drawing.Size(1041, 223);
            this.dgvQLPT.TabIndex = 25;
            this.dgvQLPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLPT_CellClick_1);
            this.dgvQLPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLPT_CellContentClick_1);
            // 
            // maPTDataGridViewTextBoxColumn
            // 
            this.maPTDataGridViewTextBoxColumn.DataPropertyName = "MaPT";
            this.maPTDataGridViewTextBoxColumn.HeaderText = "Mã Phương Tiện";
            this.maPTDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maPTDataGridViewTextBoxColumn.Name = "maPTDataGridViewTextBoxColumn";
            this.maPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.HeaderText = "Mã Tài Xế";
            this.maTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            this.maTXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dongXeDataGridViewTextBoxColumn
            // 
            this.dongXeDataGridViewTextBoxColumn.DataPropertyName = "DongXe";
            this.dongXeDataGridViewTextBoxColumn.HeaderText = "Dòng Xe";
            this.dongXeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dongXeDataGridViewTextBoxColumn.Name = "dongXeDataGridViewTextBoxColumn";
            this.dongXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mauXeDataGridViewTextBoxColumn
            // 
            this.mauXeDataGridViewTextBoxColumn.DataPropertyName = "MauXe";
            this.mauXeDataGridViewTextBoxColumn.HeaderText = "Màu Xe";
            this.mauXeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mauXeDataGridViewTextBoxColumn.Name = "mauXeDataGridViewTextBoxColumn";
            this.mauXeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bienSoDataGridViewTextBoxColumn
            // 
            this.bienSoDataGridViewTextBoxColumn.DataPropertyName = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.HeaderText = "Biển Số";
            this.bienSoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bienSoDataGridViewTextBoxColumn.Name = "bienSoDataGridViewTextBoxColumn";
            this.bienSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namSXDataGridViewTextBoxColumn
            // 
            this.namSXDataGridViewTextBoxColumn.DataPropertyName = "NamSX";
            this.namSXDataGridViewTextBoxColumn.HeaderText = "Năm SX ";
            this.namSXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namSXDataGridViewTextBoxColumn.Name = "namSXDataGridViewTextBoxColumn";
            this.namSXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soKhungDataGridViewTextBoxColumn
            // 
            this.soKhungDataGridViewTextBoxColumn.DataPropertyName = "SoKhung";
            this.soKhungDataGridViewTextBoxColumn.HeaderText = "Số Khung";
            this.soKhungDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soKhungDataGridViewTextBoxColumn.Name = "soKhungDataGridViewTextBoxColumn";
            this.soKhungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbPhuongTienBindingSource
            // 
            this.tbPhuongTienBindingSource.DataMember = "tb_PhuongTien";
            this.tbPhuongTienBindingSource.DataSource = this.qLTXDataSet1;
            // 
            // qLTXDataSet1
            // 
            this.qLTXDataSet1.DataSetName = "QLTXDataSet1";
            this.qLTXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_PhuongTienTableAdapter
            // 
            this.tb_PhuongTienTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(143, 87);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbl_pt_id
            // 
            this.lbl_pt_id.AutoSize = true;
            this.lbl_pt_id.Enabled = false;
            this.lbl_pt_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pt_id.Location = new System.Drawing.Point(486, 90);
            this.lbl_pt_id.Name = "lbl_pt_id";
            this.lbl_pt_id.Size = new System.Drawing.Size(46, 17);
            this.lbl_pt_id.TabIndex = 27;
            this.lbl_pt_id.Text = "label2";
            this.lbl_pt_id.Visible = false;
            // 
            // FormQLPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 675);
            this.Controls.Add(this.lbl_pt_id);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvQLPT);
            this.Controls.Add(this.btnThem2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.lblThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormQLPT";
            this.Text = "Quản Lý Phương Tiện";
            this.Load += new System.EventHandler(this.FormQLPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPhuongTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem2;
        private System.Windows.Forms.DataGridView dgvQLPT;
        private QLTXDataSet1 qLTXDataSet1;
        private System.Windows.Forms.BindingSource tbPhuongTienBindingSource;
        private QLTXDataSet1TableAdapters.tb_PhuongTienTableAdapter tb_PhuongTienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mauXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soKhungDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbl_pt_id;
    }
}