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
    public partial class PopUp_QLPT_Update : Form
    {
        string maPhuongTien;

        public void setMaPhuongTien(string maPhuongTien)
        {
            this.maPhuongTien = maPhuongTien;
            this.getData(maPhuongTien);
        }

        public PopUp_QLPT_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData(string maPhuongTien)
        {
            string query = string.Format("select * from tb_PhuongTien WHERE MaPT = '{0}' ", maPhuongTien);
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
            txtMaPT.Text = ds.Tables["tb_PhuongTien"].Rows[0]["MaPT"].ToString();

            txtBienSoXe.Text = ds.Tables["tb_PhuongTien"].Rows[0]["BienSo"].ToString();
            txtDongXe.Text = ds.Tables["tb_PhuongTien"].Rows[0]["DongXe"].ToString();
            txtMauXe.Text = ds.Tables["tb_PhuongTien"].Rows[0]["MauXe"].ToString();

            txtNSX.Text = ds.Tables["tb_PhuongTien"].Rows[0]["NamSX"].ToString();
            txtSoKhung.Text = ds.Tables["tb_PhuongTien"].Rows[0]["SoKhung"].ToString();

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("update tb_PhuongTien set DongXe = N'{1}', MauXe = N'{2}', BienSo = N'{3}', NamSX = N'{4}', SoKhung = N'{5}' where MaPT = '{0}'",
               txtMaPT.Text,txtDongXe.Text, txtMauXe.Text, txtBienSoXe.Text, txtNSX.Text, txtSoKhung.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                this.Close();
                FormQLPT.instance.getData();



            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopUp_QLPT_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
