using PJ_For_Wang_Test.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test.PopsUp
{
    public partial class topUpForm : Form
    {
        
        ketnoi kn = new ketnoi();
        bool isTopUp = true;

        public topUpForm()
        {
            InitializeComponent();
        }

        private void btm_topup_Click(object sender, EventArgs e)
        {
            string maTx = txt_TX_code.Text;
            int amount = Int32.Parse(txt_amount.Text);
            if (this.isTopUp)
            {
                topUp(amount, maTx);
            } else
            {
                withraw(amount, maTx);
            }
            FormQuanLyVi.instance.getData();

        }

        private void topUp(int amount, string maTx)
        {
            string query = string.Format("UPDATE tb_ViTX  SET SoDuViTren = SoDuViTren + {0}  where MaTX = '{1}' and {2} <= 20000000 AND {3} >0", amount, maTx, amount, amount);
            bool result = kn.thucthi(query);
            if (result == true)
            {
                MessageBox.Show("Nạp tiền thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nạp tiền thất bại");
            }
        }


        private void withraw(int amount, string maTx)
        {
            string query = string.Format("UPDATE tb_ViTX  SET SoDuViDuoi = SoDuViDuoi - {0}  where MaTX = '{1}' and SoDuViDuoi - {2} > 0 ", amount, maTx, amount);
            bool result = kn.thucthi(query);
            if (result == true)
            {
                MessageBox.Show("Rút tiền thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Rút tiền thất bại, xin vui lòng kiểm tra số dư ví dưới");
            }
        }
        public void setTXCode(string text)
        {
            txt_TX_code.Text = text;
        }
        public void setIsTopUp(bool isTopUp)
        {
            this.isTopUp = isTopUp;
            label1.Text = isTopUp ? "Số tiền nạp:" : "Số tiền rút:";
            btm_topup.Text = isTopUp ? "Nạp:" : "Rút:";
        }
    }
}
