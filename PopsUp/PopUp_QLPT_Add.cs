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
    public partial class PopUp_QLPT_Add : Form
    {
        public PopUp_QLPT_Add()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien order by MaPT";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopUp_QLPT_Add_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into tb_PhuongTien(MaPT,MaTX,DongXe,MauXe,BienSo,NamSX, SoKhung) values('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')",
            txtMaPT.Text, txtMaTX.Text, txtDongXe.Text, txtMauXe.Text, txtBienSoXe.Text, txtNSX.Text, txtSoKhung.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công");
                FormQLPT.instance.getData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
