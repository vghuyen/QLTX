
namespace PJ_For_Wang_Test.Forms
{
    partial class FormGioHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGioHD = new System.Windows.Forms.DataGridView();
            this.tbGioHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTXDataSetGioHD = new PJ_For_Wang_Test.QLTXDataSetGioHD();
            this.tb_GioHDTableAdapter = new PJ_For_Wang_Test.QLTXDataSetGioHDTableAdapters.tb_GioHDTableAdapter();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGioHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGioThucTeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGioHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSetGioHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý / Giờ hoạt động";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ hoạt động của tài xế";
            // 
            // txtMaTX
            // 
            this.txtMaTX.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaTX.Location = new System.Drawing.Point(14, 78);
            this.txtMaTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(88, 22);
            this.txtMaTX.TabIndex = 2;
            this.txtMaTX.Text = "Mã Tài Xế";
            this.txtMaTX.Enter += new System.EventHandler(this.txtMaTX_Enter);
            this.txtMaTX.Leave += new System.EventHandler(this.txtMaTX_Leave);
            // 
            // txtThang
            // 
            this.txtThang.ForeColor = System.Drawing.Color.LightGray;
            this.txtThang.Location = new System.Drawing.Point(108, 78);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(89, 22);
            this.txtThang.TabIndex = 3;
            this.txtThang.Text = "Tháng";
            this.txtThang.Enter += new System.EventHandler(this.txtThang_Enter);
            this.txtThang.Leave += new System.EventHandler(this.txtThang_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(658, 74);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(742, 74);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNam
            // 
            this.txtNam.ForeColor = System.Drawing.Color.LightGray;
            this.txtNam.Location = new System.Drawing.Point(202, 78);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(89, 22);
            this.txtNam.TabIndex = 7;
            this.txtNam.Text = "Năm";
            this.txtNam.Enter += new System.EventHandler(this.txtNam_Enter);
            this.txtNam.Leave += new System.EventHandler(this.txtNam_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(574, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 26);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvGioHD
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGioHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGioHD.AutoGenerateColumns = false;
            this.dgvGioHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGioHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGioHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGioHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGioHD.ColumnHeadersHeight = 30;
            this.dgvGioHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGioHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.maTXDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.tongGioHDDataGridViewTextBoxColumn,
            this.tongGioThucTeDataGridViewTextBoxColumn,
            this.LuongCB,
            this.hSLuongDataGridViewTextBoxColumn});
            this.dgvGioHD.DataSource = this.tbGioHDBindingSource;
            this.dgvGioHD.EnableHeadersVisualStyles = false;
            this.dgvGioHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dgvGioHD.Location = new System.Drawing.Point(14, 134);
            this.dgvGioHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGioHD.Name = "dgvGioHD";
            this.dgvGioHD.ReadOnly = true;
            this.dgvGioHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGioHD.RowHeadersVisible = false;
            this.dgvGioHD.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvGioHD.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGioHD.RowTemplate.Height = 28;
            this.dgvGioHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHD.Size = new System.Drawing.Size(1075, 277);
            this.dgvGioHD.TabIndex = 10;
            this.dgvGioHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHD_CellClick);
            this.dgvGioHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHD_CellContentClick_1);
            // 
            // tbGioHDBindingSource
            // 
            this.tbGioHDBindingSource.DataMember = "tb_GioHD";
            this.tbGioHDBindingSource.DataSource = this.qLTXDataSetGioHD;
            // 
            // qLTXDataSetGioHD
            // 
            this.qLTXDataSetGioHD.DataSetName = "QLTXDataSetGioHD";
            this.qLTXDataSetGioHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_GioHDTableAdapter
            // 
            this.tb_GioHDTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Location = new System.Drawing.Point(329, 84);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(46, 17);
            this.lbl_selected.TabIndex = 11;
            this.lbl_selected.Text = "label3";
            this.lbl_selected.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTXDataGridViewTextBoxColumn
            // 
            this.maTXDataGridViewTextBoxColumn.DataPropertyName = "MaTX";
            this.maTXDataGridViewTextBoxColumn.HeaderText = "Mã tài xế";
            this.maTXDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maTXDataGridViewTextBoxColumn.Name = "maTXDataGridViewTextBoxColumn";
            this.maTXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            this.thangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongGioHDDataGridViewTextBoxColumn
            // 
            this.tongGioHDDataGridViewTextBoxColumn.DataPropertyName = "TongGioHD";
            this.tongGioHDDataGridViewTextBoxColumn.HeaderText = "Số giờ hoạt động";
            this.tongGioHDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongGioHDDataGridViewTextBoxColumn.Name = "tongGioHDDataGridViewTextBoxColumn";
            this.tongGioHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tongGioThucTeDataGridViewTextBoxColumn
            // 
            this.tongGioThucTeDataGridViewTextBoxColumn.DataPropertyName = "TongGioThucTe";
            this.tongGioThucTeDataGridViewTextBoxColumn.HeaderText = "Số giờ thực tế";
            this.tongGioThucTeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tongGioThucTeDataGridViewTextBoxColumn.Name = "tongGioThucTeDataGridViewTextBoxColumn";
            this.tongGioThucTeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LuongCB
            // 
            this.LuongCB.DataPropertyName = "LuongCB";
            this.LuongCB.HeaderText = "Lương cơ bản";
            this.LuongCB.MinimumWidth = 6;
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.ReadOnly = true;
            // 
            // hSLuongDataGridViewTextBoxColumn
            // 
            this.hSLuongDataGridViewTextBoxColumn.DataPropertyName = "HSLuong";
            this.hSLuongDataGridViewTextBoxColumn.HeaderText = "Hệ số lương";
            this.hSLuongDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hSLuongDataGridViewTextBoxColumn.Name = "hSLuongDataGridViewTextBoxColumn";
            this.hSLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormGioHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.dgvGioHD);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtMaTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGioHD";
            this.Text = "Giờ hoạt động";
            this.Load += new System.EventHandler(this.FormGioHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGioHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTXDataSetGioHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGioHD;
        private QLTXDataSetGioHD qLTXDataSetGioHD;
        private System.Windows.Forms.BindingSource tbGioHDBindingSource;
        private QLTXDataSetGioHDTableAdapters.tb_GioHDTableAdapter tb_GioHDTableAdapter;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGioHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGioThucTeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSLuongDataGridViewTextBoxColumn;
    }
}