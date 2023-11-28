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
    public partial class PopUpBangLuong_Add : Form
    {
        public PopUpBangLuong_Add()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien order by MaPT";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into tb_BangLuong(MaBangLuong,MaTX, LuongCB,Thang,Nam, BHYT, BHXH, TongLuong) values('{0}','{1}',{2},{3},{4},{5}, {6},  {7})",
               txtMaBL.Text, txtMaTX.Text, Int32.Parse(txtLuongCB.Text), Int32.Parse(txtThang.Text), Int32.Parse(txtNam.Text), Int32.Parse(txtBHYT.Text), Int32.Parse( txtBHXH.Text), 10002);
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
    }
}
