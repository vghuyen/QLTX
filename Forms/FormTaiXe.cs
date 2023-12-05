using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using PJ_For_Wang_Test.PopsUp;
using PJ_For_Wang_Test.common;

namespace PJ_For_Wang_Test.Forms
{
    public partial class FormTaiXe : Form
    {
        public static FormTaiXe instance;
        public FormTaiXe()
        {
            InitializeComponent();
            instance = this;
        }
        ketnoi kn = new ketnoi();

        public void getData()
        {
            string query = "select *, "+
                " CASE WHEN TrangThai = 0 THEN N'Đã nghỉ việc' ELSE N'Đang làm việc'  END AS trang_thai from tb_TaiXe"+
                " order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            dgvQLTX.DataSource = ds.Tables["tb_TaiXe"];
            dgvQLTX.Rows[0].Selected = true;
            lbl_tx_id.Text = ds.Tables["tb_TaiXe"].Rows.Count > 0 ? dgvQLTX.Rows[0].Cells[0].Value.ToString() : "";

        }

        private void FormDuAn_Load(object sender, EventArgs e)
        {
            cbtrangthai.DataSource = TrangThaiData.items;
            getData();

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            /*
            string query = string.Format("select * from tb_TaiXe where MaTX = '{0}' OR TenTX = '{1}' OR MaTX = '{2}' ", txtMaTX.Text,txtTenTX.Text,txtSDT.Text );
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            dgvQLTX.DataSource = ds.Tables["tb_TaiXe"];
            */
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvQLTX_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLTX_ADD popup = new PopsUp.PopUp_QLTX_ADD())
            {
                popup.Owner = miniPopup;
                popup.ShowDialog();
            }
        }

       
        private void btnSua_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLTX_Update popup = new PopsUp.PopUp_QLTX_Update())
            {


                popup.Owner = miniPopup;
                popup.setTxId(lbl_tx_id.Text);
                popup.ShowDialog();


            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn xóa tài xế này?";
            string title = "Xóa tài xế";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

                string query = string.Format("DELETE FROM tb_TaiXe where MaTX = '{0}'", lbl_tx_id.Text);
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
            else
            {
                // Do something
            }
            /*
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLTX_Delete popup = new PopsUp.PopUp_QLTX_Delete())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            } */
        }

        private void dgvQLTX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLTX_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                lbl_tx_id.Text = dgvQLTX.Rows[row].Cells[0].Value.ToString();
                dgvQLTX.Rows[row].Selected = true;
            }
        }


        private void txtMaTX_Enter(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "Tìm kiếm")
            {
                txtMaTX.Text = "";
                txtMaTX.ForeColor = Color.Black;
            }
        }

        private void txtMaTX_Leave(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "")
            {
                txtMaTX.Text = "Tìm kiếm";
                txtMaTX.ForeColor = Color.LightGray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            onSearch();
        }

        private void onSearch()
        {
            int trangthai = 2;
            if (cbtrangthai.Text == TrangThaiData.lamViec) trangthai = 1;
            if (cbtrangthai.Text == TrangThaiData.nghiViec) trangthai = 0;
            string query = string.Format("select *, CASE WHEN TrangThai = 0 THEN N'Đã nghỉ việc' ELSE N'Đang làm việc'  END AS trang_thai  from tb_TaiXe where (MaTX = '{0}' OR TenTX = '{0}' OR MaTX = '{0}' or 'Tìm kiếm' = '{0}') AND ({1} = 2 OR TrangThai = {1})", txtMaTX.Text, trangthai);
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            dgvQLTX.DataSource = ds.Tables["tb_TaiXe"];
        }

        private void txtMaTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaTX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = txtMaTX.Text.Trim();
                if (searchValue.Length <1 || searchValue.Equals("Tìm kiếm"))
                {

                    txtMaTX.ForeColor = Color.LightGray;
                    txtMaTX.Text = "Tìm kiếm";
                }
                onSearch();
            }
        }

        private void cbtrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            onSearch();
        }
    }

}

