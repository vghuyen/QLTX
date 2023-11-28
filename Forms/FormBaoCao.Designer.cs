
namespace PJ_For_Wang_Test.Forms
{
    partial class FormBaoCao
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDriverTM = new System.Windows.Forms.Button();
            this.btnRPV = new System.Windows.Forms.Button();
            this.btnExpContract = new System.Windows.Forms.Button();
            this.btnRPDriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản Lý / Báo Cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "BÁO CÁO";
            // 
            // btnDriverTM
            // 
            this.btnDriverTM.Location = new System.Drawing.Point(27, 226);
            this.btnDriverTM.Name = "btnDriverTM";
            this.btnDriverTM.Size = new System.Drawing.Size(248, 50);
            this.btnDriverTM.TabIndex = 9;
            this.btnDriverTM.Text = "Bảng lương của tài xế";
            this.btnDriverTM.UseVisualStyleBackColor = true;
            // 
            // btnRPV
            // 
            this.btnRPV.Location = new System.Drawing.Point(27, 172);
            this.btnRPV.Name = "btnRPV";
            this.btnRPV.Size = new System.Drawing.Size(248, 48);
            this.btnRPV.TabIndex = 8;
            this.btnRPV.Text = "Danh sách phương tiện";
            this.btnRPV.UseVisualStyleBackColor = true;
            this.btnRPV.Click += new System.EventHandler(this.btnRPV_Click);
            // 
            // btnExpContract
            // 
            this.btnExpContract.Location = new System.Drawing.Point(27, 282);
            this.btnExpContract.Name = "btnExpContract";
            this.btnExpContract.Size = new System.Drawing.Size(248, 48);
            this.btnExpContract.TabIndex = 7;
            this.btnExpContract.Text = "Danh sách các tài xế hết hạn hợp đồng vào tháng [n]";
            this.btnExpContract.UseVisualStyleBackColor = true;
            // 
            // btnRPDriver
            // 
            this.btnRPDriver.Location = new System.Drawing.Point(27, 117);
            this.btnRPDriver.Name = "btnRPDriver";
            this.btnRPDriver.Size = new System.Drawing.Size(248, 49);
            this.btnRPDriver.TabIndex = 6;
            this.btnRPDriver.Text = "Danh sách tài xế";
            this.btnRPDriver.UseVisualStyleBackColor = true;
            this.btnRPDriver.Click += new System.EventHandler(this.btnRPDriver_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDriverTM);
            this.Controls.Add(this.btnRPV);
            this.Controls.Add(this.btnExpContract);
            this.Controls.Add(this.btnRPDriver);
            this.Name = "FormBaoCao";
            this.Text = "Báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDriverTM;
        private System.Windows.Forms.Button btnRPV;
        private System.Windows.Forms.Button btnExpContract;
        private System.Windows.Forms.Button btnRPDriver;
    }
}