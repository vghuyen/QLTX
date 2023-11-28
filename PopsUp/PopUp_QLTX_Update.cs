﻿using PJ_For_Wang_Test.Forms;
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
    public partial class PopUp_QLTX_Update : Form
    {
        public PopUp_QLTX_Update()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        string txId;

        public void setTxId(string txId) {
            this.txId = txId;
            DataSet a= getData(txId);

        }
        public DataSet getData(string txId)
        {
            string query = string.Format("select * from tb_TaiXe Where MaTX = '{0}'", txId);
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            txtMaTaiXe.Text = ds.Tables["tb_TaiXe"].Rows[0]["MaTX"].ToString();

            txtTenTaiXe.Text = ds.Tables["tb_TaiXe"].Rows[0]["TenTX"].ToString();
            dateTimePicker1.Value = DateTime.Parse(ds.Tables["tb_TaiXe"].Rows[0]["NgaySinh"].ToString()); 
            txtGioiTinh.Text = ds.Tables["tb_TaiXe"].Rows[0]["GioiTinh"].ToString();

            txtSDT.Text = ds.Tables["tb_TaiXe"].Rows[0]["SDT"].ToString();
            txtCCCD.Text = ds.Tables["tb_TaiXe"].Rows[0]["CCCD"].ToString();
            txtDiaChi.Text = ds.Tables["tb_TaiXe"].Rows[0]["GioiTinh"].ToString();


            dateTimePicker2.Value = DateTime.Parse(ds.Tables["tb_TaiXe"].Rows[0]["NgayKyHD"].ToString());
            dateTimePicker3.Value = DateTime.Parse(ds.Tables["tb_TaiXe"].Rows[0]["NgayHetHD"].ToString());
            cbTrangThai.Text = ds.Tables["tb_TaiXe"].Rows[0]["TrangThai"].ToString();
            return ds;
        }

        public void closeForm()
        {

            FormTaiXe.instance.getData();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.closeForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = string.Format("update tb_TaiXe set TenTX = '{1}', NgaySinh = '{2}', GioiTinh = '{3}', SDT = '{4}', CCCD = '{5}', DiaChi = '{6}', NgayKyHD = '{7}', NgayHetHD = '{8}', TrangThai = '{9}' where MaTX = '{0}'",
               txtMaTaiXe.Text, txtTenTaiXe.Text, dateTimePicker1.Value.ToString("yyyyMMdd"), txtGioiTinh.Text, txtSDT.Text, txtCCCD.Text, txtDiaChi.Text,
               dateTimePicker2.Value.ToString("yyyyMMdd"), dateTimePicker3.Value.ToString("yyyyMMdd"), cbTrangThai.Text);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
               


            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            this.closeForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopUp_QLTX_Update_Load(object sender, EventArgs e)
        {
        }
    }
}
