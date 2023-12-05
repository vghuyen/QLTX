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
            string queryGioHoatDong = string.Format("insert into tb_GioHD(MaTX, TongGioHD,TongGioThucTe,Thang, Nam) " +
                " values ('{0}', {1}, {2}, {3}, {4})",
              txtMaTX.Text, txtTongGioHD.Text, TongGioThucTe.Text, txtThang.Text, txtNam.Text);

            int gioHD = Int32.Parse(txtTongGioHD.Text);
            int gioThucTe = Int32.Parse(TongGioThucTe.Text);

            int luongCoBan = Int32.Parse(txt_luong_co_ban.Text);
            int thang = Int32.Parse(txtThang.Text);
            int nam = Int32.Parse(txtNam.Text);
            double bhyt = Int32.Parse(txt_luong_co_ban.Text) * 1.5 / 100;
            double bhxh = Int32.Parse(txt_luong_co_ban.Text) * 8 / 100;
            double tongLuong = Int32.Parse(txt_luong_co_ban.Text) / gioHD * gioThucTe - bhxh - bhyt;

            string queryBangLuong = string.Format("insert into tb_BangLuong(MaTX, LuongCB,Thang,Nam, BHYT, BHXH, TongLuong) " +
                " values('{0}','{1}',{2},{3},{4},{5}, {6})",
              txtMaTX.Text, luongCoBan, thang, nam, bhyt, bhxh, tongLuong);
            bool kt1 = kn.thucthi(queryGioHoatDong);
            bool kt2 = kn.thucthi(queryBangLuong);
            if (kt1 == true && kt2 == true)
            {
                MessageBox.Show("Thêm thành công");
                getData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            FormGioHD.instance.getData();
            this.Close();
        }

        private void txtTongGioHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
