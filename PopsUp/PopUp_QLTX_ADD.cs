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
    public partial class PopUp_QLTX_ADD : Form
    {
        public PopUp_QLTX_ADD()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_TaiXe order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
         
        }
        private void PopUp_QLTX_ADD_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string query = string.Format("insert into tb_TaiXe(MaTX, TenTX, SDT, DiaChi,NgayKyHD, NgayHetHD, GioiTinh, TrangThai, CCCD, NgaySinh) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')",
               txtMaTaiXe.Text, txtTenTX.Text, txtSDT.Text, txtDiaChi.Text, dTP_NgayKyHD.Value.ToString("yyyyMMdd"), dTP_NgayHetHD.Value.ToString("yyyyMMdd"), txtGioiTinh.Text, cbTrangThai.Text, txtCCCD.Text, dTP_NgaySinh.Value.ToString("yyyyMMdd"));
            bool kt = kn.thucthi(query);
            string insertViQuery = string.Format("insert into tb_ViTX(MaTX, SoDuViTren, SoDuViDuoi) values('{0}', {1}, {2})", txtMaTaiXe.Text, 0, 0);
            bool ktVi = false;
            if (kt == true) {
                ktVi = kn.thucthi(insertViQuery);
            }
            if (kt == true && ktVi == true)
            {
                MessageBox.Show("Them thanh cong");
                getData();
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
            this.Close();
        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

