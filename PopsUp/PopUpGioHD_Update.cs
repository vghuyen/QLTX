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
    public partial class PopUpGioHD_Update : Form
    {
        public PopUpGioHD_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_TaiXe order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = string.Format("update tb_TaiXe set  TongGioHD = '{1}', TongGioThucTe = '{2}', Thang = '{3}', Nam = '{4}' where MaTX = '{0}'",
             txtMaTX.Text, txtTongGioHD.Text, txtTongGioThucTe.Text, txtThang.Text, txtNam.Text, Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sua thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("Sua that bai");
            }
        }
    }
}
