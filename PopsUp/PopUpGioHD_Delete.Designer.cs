
namespace PJ_For_Wang_Test.PopsUp
{
    partial class PopUpGioHD_Delete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtTongGioHD = new System.Windows.Forms.TextBox();
            this.txtTongGioThucTe = new System.Windows.Forms.TextBox();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(293, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 40);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Đồng ý";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(29, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Không";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(206, 191);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(162, 26);
            this.txtThang.TabIndex = 28;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(206, 252);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(162, 26);
            this.txtNam.TabIndex = 27;
            // 
            // txtTongGioHD
            // 
            this.txtTongGioHD.Location = new System.Drawing.Point(206, 65);
            this.txtTongGioHD.Name = "txtTongGioHD";
            this.txtTongGioHD.Size = new System.Drawing.Size(162, 26);
            this.txtTongGioHD.TabIndex = 26;
            // 
            // txtTongGioThucTe
            // 
            this.txtTongGioThucTe.Location = new System.Drawing.Point(206, 126);
            this.txtTongGioThucTe.Name = "txtTongGioThucTe";
            this.txtTongGioThucTe.Size = new System.Drawing.Size(162, 26);
            this.txtTongGioThucTe.TabIndex = 25;
            // 
            // txtMaTX
            // 
            this.txtMaTX.Location = new System.Drawing.Point(206, 12);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(162, 26);
            this.txtMaTX.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tháng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tổng Giờ Thực Tế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tổng giờ HĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Tài Xế";
            // 
            // PopUpGioHD_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtTongGioHD);
            this.Controls.Add(this.txtTongGioThucTe);
            this.Controls.Add(this.txtMaTX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpGioHD_Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopUpGioHD_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtTongGioHD;
        private System.Windows.Forms.TextBox txtTongGioThucTe;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}