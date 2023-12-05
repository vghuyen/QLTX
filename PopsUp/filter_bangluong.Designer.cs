
namespace PJ_For_Wang_Test.PopsUp
{
    partial class filter_bangluong
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMaTX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 64;
            this.button2.Text = "Xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNam
            // 
            this.txtNam.ForeColor = System.Drawing.Color.LightGray;
            this.txtNam.Location = new System.Drawing.Point(217, 40);
            this.txtNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(89, 22);
            this.txtNam.TabIndex = 63;
            this.txtNam.Text = "Năm";
            this.txtNam.Enter += new System.EventHandler(this.txtNam_Enter);
            this.txtNam.Leave += new System.EventHandler(this.txtNam_Leave);
            // 
            // txtThang
            // 
            this.txtThang.ForeColor = System.Drawing.Color.LightGray;
            this.txtThang.Location = new System.Drawing.Point(123, 40);
            this.txtThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(89, 22);
            this.txtThang.TabIndex = 62;
            this.txtThang.Text = "Tháng";
            this.txtThang.Enter += new System.EventHandler(this.txtThang_Enter);
            this.txtThang.Leave += new System.EventHandler(this.txtThang_Leave);
            // 
            // txtMaTX
            // 
            this.txtMaTX.ForeColor = System.Drawing.Color.LightGray;
            this.txtMaTX.Location = new System.Drawing.Point(29, 40);
            this.txtMaTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTX.Name = "txtMaTX";
            this.txtMaTX.Size = new System.Drawing.Size(88, 22);
            this.txtMaTX.TabIndex = 61;
            this.txtMaTX.Text = "Mã Tài Xế";
            this.txtMaTX.Enter += new System.EventHandler(this.txtMaTX_Enter);
            this.txtMaTX.Leave += new System.EventHandler(this.txtMaTX_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 65;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // filter_bangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtMaTX);
            this.Name = "filter_bangluong";
            this.Text = "filter_bangluong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMaTX;
        private System.Windows.Forms.Button button1;
    }
}