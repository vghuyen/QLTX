using PJ_For_Wang_Test.Forms;
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
    public partial class BaoCao2 : Form
    {
        public BaoCao2()
        {
            InitializeComponent();
        }

        private void BaoCao2_Load(object sender, EventArgs e)
        {

            CrystalReport2 dstx = new CrystalReport2();
            crystalReportViewer1.ReportSource = dstx;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
