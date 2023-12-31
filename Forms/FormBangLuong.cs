﻿using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from tb_BangLuong " +
                " Where (tb_BangLuong.MaTX = '{0}' OR '{0}' = 'Mã Tài Xế') AND (tb_BangLuong.Thang = '{1}' OR '{1}' = 'Tháng') AND (tb_BangLuong.Nam = '{2}' OR '{2}' = 'Năm')", txtMaTX.Text, txtThang.Text, txtNam.Text);
            ;
            DataSet ds = kn.laydulieu(query, "tb_BangLuong");
            dgvQLBL.DataSource = ds.Tables["tb_BangLuong"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtMaTX.Text == "Mã Tài Xế")
            {
                txtMaTX.Text = "";
                txtMaTX.ForeColor = Color.Black;
            }
        }

        private void txtThang_Enter(object sender, EventArgs e)
        {

            if (txtThang.Text == "Tháng")
            {
                txtThang.Text = "";
                txtThang.ForeColor = Color.Black;
            }
        }

        private void txtNam_Enter(object sender, EventArgs e)
        {

            if (txtNam.Text == "Năm")
            {
                txtNam.Text = "";
                txtNam.ForeColor = Color.Black;
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

        private void txtThang_Leave(object sender, EventArgs e)
        {

            if (txtThang.Text == "")
            {
                txtThang.Text = "Tháng";
                txtThang.ForeColor = Color.LightGray;
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
