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
    public partial class PopUpGioHD_Add : Form
    {
        public PopUpGioHD_Add()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_GioHD";
            DataSet ds = kn.laydulieu(query, "tb_GioHD");

        }

        private void PopUpGioHD_Add_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into tb_GioHD(MaTX, TongGioHD,TongGioThucTe,Thang, Nam) values ('{0}','{1}','{2}','{3}','{4}')",
              txtMaTX.Text, txtTongGioHD.Text, TongGioThucTe.Text, txtThang.Text, txtNam.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Them thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void txtTongGioHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
