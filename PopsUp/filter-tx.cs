using PJ_For_Wang_Test.common;
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
    public partial class filter_tx : Form
    {
        public filter_tx()
        {
            InitializeComponent();
        }

        private void filter_tx_Load(object sender, EventArgs e)
        {
            cbtrangthai.DataSource = TrangThaiData.items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.baocao1 popup = new PopsUp.baocao1())
            {
                int trangthai = 2;
                if (cbtrangthai.Text == TrangThaiData.lamViec) trangthai = 1;
                if (cbtrangthai.Text == TrangThaiData.nghiViec) trangthai = 0;
                popup.Owner = miniPopup;
                popup.setTrangThai(trangthai);

                popup.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
