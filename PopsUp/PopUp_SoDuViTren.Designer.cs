
namespace PJ_For_Wang_Test.PopsUp
{
    partial class PopUp_SoDuViTren
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDuViTren = new System.Windows.Forms.TextBox();
            this.txtNapTien = new System.Windows.Forms.TextBox();
            this.btnKhong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Dư Ví Trên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nạp Tiền";
            // 
            // txtSoDuViTren
            // 
            this.txtSoDuViTren.Location = new System.Drawing.Point(153, 25);
            this.txtSoDuViTren.Name = "txtSoDuViTren";
            this.txtSoDuViTren.Size = new System.Drawing.Size(100, 20);
            this.txtSoDuViTren.TabIndex = 2;
            // 
            // txtNapTien
            // 
            this.txtNapTien.Location = new System.Drawing.Point(153, 80);
            this.txtNapTien.Name = "txtNapTien";
            this.txtNapTien.Size = new System.Drawing.Size(100, 20);
            this.txtNapTien.TabIndex = 3;
            // 
            // btnKhong
            // 
            this.btnKhong.Location = new System.Drawing.Point(36, 149);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(75, 23);
            this.btnKhong.TabIndex = 4;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Đồng ý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PopUp_SoDuViTren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.txtNapTien);
            this.Controls.Add(this.txtSoDuViTren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUp_SoDuViTren";
            this.Text = "PopUp_SoDuViTren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDuViTren;
        private System.Windows.Forms.TextBox txtNapTien;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button button2;
    }
}