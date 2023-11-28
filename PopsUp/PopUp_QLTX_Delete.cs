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
    public partial class PopUp_QLTX_Delete : Form
    {
        public PopUp_QLTX_Delete()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_TaiXe order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
        }

        private void PopUp_QLTX_Delete_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = string.Format("DELETE FROM tb_TaiXe where MaTX = '{0}'", txtMaTaiXe.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Xoá thành công");
                getData();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
            this.Close();
        }

        private void txtMaTaiXe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
