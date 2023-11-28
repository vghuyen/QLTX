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
    public partial class FormGioHD : Form
    {
        public FormGioHD()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_GioHD";
            DataSet ds = kn.laydulieu(query, "tb_GioHD");
            dgvGioHD.DataSource = ds.Tables["tb_GioHD"];
        }

        private void FormGioHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTXDataSetGioHD.tb_GioHD' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLTXDataSet9.tb_GioHD' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTXDataSet6.tb_GioHD' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTXDataSet3.tb_GioHD' table. You can move, or remove it, as needed.


            getData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUpGioHD_Add popup = new PopsUp.PopUpGioHD_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUpGioHD_Update popup = new PopsUp.PopUpGioHD_Update())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUpGioHD_Delete popup = new PopsUp.PopUpGioHD_Delete())
            {
                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void dgvGioHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        

        private void txtMaTX_Enter(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "Mã Tài Xế")
            {
                txtMaTX.Text = "";
                txtMaTX.ForeColor = Color.Black;
            }
        }

        private void txtMaTX_Leave(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "")
            {
                txtMaTX.Text = "Mã Tài Xế";
                txtMaTX.ForeColor = Color.LightGray;
            }
        }

        private void txtThang_Enter(object sender, EventArgs e)
        {
            if (txtThang.Text == "Tháng")
            {
                txtThang.Text = "";
                txtThang.ForeColor = Color.LightGray;
            }
        }

        private void txtThang_Leave(object sender, EventArgs e)
        {
            if (txtThang.Text == "")
            {
                txtThang.Text = "Tháng";
                txtThang.ForeColor = Color.LightGray;
            }
        }

        private void txtNam_Enter(object sender, EventArgs e)
        {
            if (txtNam.Text == "Năm")
            {
                txtNam.Text = "";
                txtNam.ForeColor = Color.LightGray;
            }
        }

        private void txtNam_Leave(object sender, EventArgs e)
        {
            if (txtNam.Text == "")
            {
                txtNam.Text = "Năm";
                txtNam.ForeColor = Color.LightGray;
            }
        }
    }
}
