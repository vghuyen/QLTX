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
    public partial class PopUp_SoDuViTren : Form
    {
        public PopUp_SoDuViTren()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public void getData()
        {
            string query = "select * from tb_ViTX order by MaTX";
            DataSet ds = kn.laydulieu(query, "tb_ViTX");
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }
    }
}
