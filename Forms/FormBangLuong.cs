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
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_BangLuong";
            DataSet ds = kn.laydulieu(query, "tb_ViTX");
            dgvQLBL.DataSource = ds.Tables["tb_ViTX"];
        }
        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTXDataSet8.tb_BangLuong' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTXDataSet4.tb_BangLuong' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'qLTXDataSet5.tb_BangLuong' table. You can move, or remove it, as needed.

            getData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Form miniPopup = new Form();
            using (PopsUp.PopUpBangLuong_Add popup = new PopsUp.PopUpBangLuong_Add())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUpBangLuong_Update popup = new PopsUp.PopUpBangLuong_Update())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.PopUpBangLuong_Delete popup = new PopsUp.PopUpBangLuong_Delete())
            {


                popup.Owner = miniPopup;
                popup.ShowDialog();


            }
        }
    }
}
