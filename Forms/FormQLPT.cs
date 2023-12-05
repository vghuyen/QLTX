using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test.Forms
{
    public partial class FormQLPT : Form
    {
        public FormQLPT()
        {
            InitializeComponent();
            instance = this;
        }

        public static FormQLPT instance;

        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
            dgvQLPT.DataSource = ds.Tables["tb_PhuongTien"];
            dgvQLPT.Rows[0].Selected = true;
            lbl_pt_id.Text = ds.Tables["tb_PhuongTien"].Rows.Count > 0 ? dgvQLPT.Rows[0].Cells[0].Value.ToString() : "";
        }
        
        


        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Add popup = new PopsUp.PopUp_QLPT_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void dgvQLPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {

                txtTimkiem.Text = dgvQLPT.Rows[row].Cells["MaPT"].Value.ToString();

                txtTimkiem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Update popup = new PopsUp.PopUp_QLPT_Update())
            {


                popup.Owner = miniPopup;
                popup.setMaPhuongTien(lbl_pt_id.Text);
                popup.ShowDialog();


            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            string message = "Bạn có thực sự muốn xóa phương tiện này?";
            string title = "Xóa phương tiện";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

                string query = string.Format("DELETE FROM tb_PhuongTien where MaPT = '{0}'", lbl_pt_id.Text);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Xoá thành công");
                    this.getData();               
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                // Do something
            }
            /*
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Delete popup = new PopsUp.PopUp_QLPT_Delete())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }*/
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUp_QLPT_Add popup = new PopsUp.PopUp_QLPT_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }

        }

        private void dgvQLPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLPT_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            onSearch();
        }

        private void onSearch()
        {
            string query = string.Format("select * from tb_PhuongTien where MaPT = '{0}' OR DongXe = '{0}' OR SoKhung = '{0}' OR MaTX = '{0}' OR BienSo = '{0}' OR 'Tìm kiếm' = '{0}'", txtTimkiem.Text);
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
            dgvQLPT.DataSource = ds.Tables["tb_PhuongTien"];
        }

        private void txtMaPT_Enter(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "Tìm kiếm")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void txtMaPT_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.Text = "Tìm kiếm";
                txtTimkiem.ForeColor = Color.LightGray;
            }
        }


        private void dgvQLPT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLPT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                lbl_pt_id.Text = dgvQLPT.Rows[index].Cells[0].Value.ToString();
                dgvQLPT.Rows[index].Selected = true;
            }
        }

        private void txtDongXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = txtTimkiem.Text.Trim();
                if (searchValue.Length < 1 || searchValue.Equals("Tìm kiếm"))
                {

                    txtTimkiem.ForeColor = Color.LightGray;
                    txtTimkiem.Text = "Tìm kiếm";
                }
                onSearch();
            }
        }
    }
}
