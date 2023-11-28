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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void btnRPDriver_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.baocao1 popup = new PopsUp.baocao1())
            {
                popup.Owner = miniPopup;
        
                popup.ShowDialog();
            }
        }

        private void btnRPV_Click(object sender, EventArgs e)
        {
            Form miniPopup = new Form();
            using (PopsUp.BaoCao2 popup = new PopsUp.BaoCao2())
            {
                popup.Owner = miniPopup;

                popup.ShowDialog();
            }
        }
    }
}
