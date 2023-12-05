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
    public partial class filter_bangluong : Form
    {
        public filter_bangluong()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from tb_BangLuong " +
                " Where (tb_BangLuong.MaTX = '{0}' OR '{0}' = 'Mã Tài Xế') AND (tb_BangLuong.Thang = '{1}' OR '{1}' = 'Tháng') AND (tb_BangLuong.Nam = '{2}' OR '{2}' = 'Năm')", txtMaTX.Text, txtThang.Text, txtNam.Text);
            ;
            DataSet ds = kn.laydulieu(query, "tb_BangLuong");
            
            Form miniPopup = new Form();
            using (PopsUp.BaoCaoBangLuong popup = new PopsUp.BaoCaoBangLuong())
            {
                popup.setDataSource(ds.Tables["tb_BangLuong"]);
                popup.Owner = miniPopup;

                popup.ShowDialog();
            }
        }

        private void txtMaTX_Enter(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "Mã Tài Xế")
            {
                txtMaTX.Text = "";
                txtMaTX.ForeColor = Color.Black;
            }
        }


        private void txtThang_Enter(object sender, EventArgs e)
        {

            if (txtThang.Text == "Tháng")
            {
                txtThang.Text = "";
                txtThang.ForeColor = Color.Black;
            }
        }

        private void txtNam_Enter(object sender, EventArgs e)
        {

            if (txtNam.Text == "Năm")
            {
                txtNam.Text = "";
                txtNam.ForeColor = Color.Black;
            }
        }

        private void txtMaTX_Leave(object sender, EventArgs e)
        {

            if (txtMaTX.Text == "")
            {
                txtMaTX.Text = "Mã Tài Xế";
                txtMaTX.ForeColor = Color.LightGray;
            }
        }

        private void txtThang_Leave(object sender, EventArgs e)
        {

            if (txtThang.Text == "")
            {
                txtThang.Text = "Tháng";
                txtThang.ForeColor = Color.LightGray;
            }
        }

        private void txtNam_Leave(object sender, EventArgs e)
        {

            if (txtNam.Text == "")
            {
                txtNam.Text = "Năm";
                txtNam.ForeColor = Color.LightGray;
            }

        }
    }
}
