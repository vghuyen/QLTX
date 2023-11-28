
namespace PJ_For_Wang_Test.PopsUp
{
    partial class topUpForm
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
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btm_topup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TX_code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(132, 51);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(175, 22);
            this.txt_amount.TabIndex = 0;
            // 
            // btm_topup
            // 
            this.btm_topup.Location = new System.Drawing.Point(335, 50);
            this.btm_topup.Name = "btm_topup";
            this.btm_topup.Size = new System.Drawing.Size(85, 23);
            this.btm_topup.TabIndex = 1;
            this.btm_topup.Text = "Nạp tiền";
            this.btm_topup.UseVisualStyleBackColor = true;
            this.btm_topup.Click += new System.EventHandler(this.btm_topup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số tiền nạp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã tài xế:";
            // 
            // txt_TX_code
            // 
            this.txt_TX_code.AutoSize = true;
            this.txt_TX_code.Location = new System.Drawing.Point(129, 13);
            this.txt_TX_code.Name = "txt_TX_code";
            this.txt_TX_code.Size = new System.Drawing.Size(68, 17);
            this.txt_TX_code.TabIndex = 4;
            this.txt_TX_code.Text = "Mã tài xế:";
            // 
            // topUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 104);
            this.Controls.Add(this.txt_TX_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btm_topup);
            this.Controls.Add(this.txt_amount);
            this.Name = "topUpForm";
            this.Text = "topUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btm_topup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_TX_code;
    }
}