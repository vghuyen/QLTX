
namespace PJ_For_Wang_Test.PopsUp
{
    partial class PopUp_SoDuViDuoi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtRutTien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Xế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rút Tiền";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtRutTien
            // 
            this.txtRutTien.Location = new System.Drawing.Point(110, 89);
            this.txtRutTien.Name = "txtRutTien";
            this.txtRutTien.Size = new System.Drawing.Size(100, 20);
            this.txtRutTien.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Không";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(135, 147);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 5;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // PopUp_SoDuViDuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 232);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRutTien);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUp_SoDuViDuoi";
            this.Text = "PopUp_SoDuViDuoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtRutTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDongY;
    }
}