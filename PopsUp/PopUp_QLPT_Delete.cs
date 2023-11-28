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
    public partial class PopUp_QLPT_Delete : Form
    {
        public PopUp_QLPT_Delete()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_PhuongTien order by MaPT";
            DataSet ds = kn.laydulieu(query, "tb_PhuongTien");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from tb_PhuongTien where MaPT = '{0}'", txtMaPT.Text);
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
        }

        private void PopUp_QLPT_Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
