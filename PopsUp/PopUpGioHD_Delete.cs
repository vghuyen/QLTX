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
    public partial class PopUpGioHD_Delete : Form
    {
        public PopUpGioHD_Delete()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_GioHD";
            DataSet ds = kn.laydulieu(query, "tb_GioHD");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from tb_GioHD where MaTX = '{0}'", txtMaTX.Text);
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
        }
    }
}
