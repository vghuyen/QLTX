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
            ComboboxItem comboboxItem = new ComboboxItem("Đã nghỉ việc", 0);
            ComboboxItem comboboxItem1 = new ComboboxItem("Đang làm việc", 1);
            var items = new[] { comboboxItem1, comboboxItem };

            cbTrangThai.DataSource = items;
            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int trangthai = cbTrangThai.Text == "Đã nghỉ việc" ? 0 : 1;
            string query = string.Format("insert into tb_TaiXe(MaTX, TenTX, SDT, DiaChi,NgayKyHD, NgayHetHD, GioiTinh, TrangThai, CCCD, NgaySinh) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}', N'{9}')",
               txtMaTaiXe.Text, txtTenTX.Text, txtSDT.Text, txtDiaChi.Text, dTP_NgayKyHD.Value.ToString("yyyyMMdd"), dTP_NgayHetHD.Value.ToString("yyyyMMdd"), txtGioiTinh.Text, trangthai, txtCCCD.Text, dTP_NgaySinh.Value.ToString("yyyyMMdd"));
            bool kt = kn.thucthi(query);
            string insertViQuery = string.Format("insert into tb_ViTX(MaTX, SoDuViTren, SoDuViDuoi) values('{0}', {1}, {2})", txtMaTaiXe.Text, 0, 0);
            bool ktVi = false;
            if (kt == true) {
                ktVi = kn.thucthi(insertViQuery);
            }
            if (kt == true && ktVi == true)
            {
                MessageBox.Show("Thêm thành công");
                FormTaiXe.instance.getData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
           
        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public ComboboxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}


