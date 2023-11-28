
namespace PJ_For_Wang_Test.PopsUp
{
    partial class PopUpGioHD_Add
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.TongGioThucTe = new System.Windows.Forms.TextBox();
            this.txtTongGioHD = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Xế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng giờ HĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng Giờ Thực Tế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tháng ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm";
            // 
            // txtMaTX
            // 
            this.txtMaTX.Location = new System.Drawing.Point(206, 52);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(162, 26);
            this.txtMaTX.TabIndex = 7;
            // 
            // TongGioThucTe
            // 
            this.TongGioThucTe.Location = new System.Drawing.Point(206, 176);
            this.TongGioThucTe.Name = "TongGioThucTe";
            this.TongGioThucTe.Size = new System.Drawing.Size(162, 26);
            this.TongGioThucTe.TabIndex = 9;
            // 
            // txtTongGioHD
            // 
            this.txtTongGioHD.Location = new System.Drawing.Point(206, 115);
            this.txtTongGioHD.Name = "txtTongGioHD";
            this.txtTongGioHD.Size = new System.Drawing.Size(162, 26);
            this.txtTongGioHD.TabIndex = 12;
            this.txtTongGioHD.TextChanged += new System.EventHandler(this.txtTongGioHD_TextChanged);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(206, 241);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(162, 26);
            this.txtThang.TabIndex = 14;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(206, 302);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(162, 26);
            this.txtNam.TabIndex = 13;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(29, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Không";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Đồng ý";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PopUpGioHD_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 466);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtTongGioHD);
            this.Controls.Add(this.TongGioThucTe);
            this.Controls.Add(this.txtMaTX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpGioHD_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopUpGioHD_Add";
            this.Load += new System.EventHandler(this.PopUpGioHD_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.TextBox TongGioThucTe;
        private System.Windows.Forms.TextBox txtTongGioHD;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}