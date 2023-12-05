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
    public partial class PopUpGioHD_Update : Form
    {

        string selectedId;
        public void setSelectedId(string id)
        {
            this.selectedId = id;
        }
        public PopUpGioHD_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {

            string query = string.Format("select * from tb_GioHD WHERE id = {0}", Int32.Parse(this.selectedId));
            DataSet ds = kn.laydulieu(query, "tb_GioHD");

            txtMaTX.Text = ds.Tables["tb_GioHD"].Rows[0]["MaTX"].ToString();

            txtTongGioHD.Text = ds.Tables["tb_GioHD"].Rows[0]["TongGioHD"].ToString();

            txtTongGioThucTe.Text = ds.Tables["tb_GioHD"].Rows[0]["TongGioThucTe"].ToString();

            txtThang.Text = ds.Tables["tb_GioHD"].Rows[0]["Thang"].ToString();
            txtNam.Text = ds.Tables["tb_GioHD"].Rows[0]["Nam"].ToString();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = string.Format("update tb_GioHD set  TongGioHD = '{1}', TongGioThucTe = '{2}' where Thang = '{3}' AND Nam = '{4}' AND MaTX = '{0}'",
             txtMaTX.Text, txtTongGioHD.Text, txtTongGioThucTe.Text, txtThang.Text, txtNam.Text, Text);

            bool kt1 = kn.thucthi(query);

            int gioHD = Int32.Parse(txtTongGioHD.Text);
            int gioThucTe = Int32.Parse(txtTongGioThucTe.Text);

            int luongCoBan = Int32.Parse(txt_luong_co_ban.Text);
            int thang = Int32.Parse(txtThang.Text);
            int nam = Int32.Parse(txtNam.Text);
            double bhyt = Int32.Parse(txt_luong_co_ban.Text) * 1.5 / 100;
            double bhxh = Int32.Parse(txt_luong_co_ban.Text) * 8 / 100;
            double tongLuong = Int32.Parse(txt_luong_co_ban.Text) / gioHD * gioThucTe - bhxh - bhyt;

            string queryBangLuong = string.Format("update tb_BangLuong SET LuongCB = {0}, BHYT ={1}, BHXH = {2}, TongLuong = {3}  where Thang = '{4}' AND Nam = '{5}' AND MaTX = '{6}' ",
               luongCoBan, bhyt, bhxh, tongLuong, thang, nam, txtMaTX.Text);
            bool kt2 = kn.thucthi(queryBangLuong);
            if (kt1 == true && kt2 == true)
            {
                MessageBox.Show("Sửa thành công");
                FormGioHD.instance.getData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void PopUpGioHD_Update_Load(object sender, EventArgs e)
        {
            getData();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
