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
    public partial class baocao1 : Form
    {
        public baocao1()
        {
            InitializeComponent();
        }

        private void baocao1_Load(object sender, EventArgs e)
        {
            DSTX dstx = new DSTX();
            crystalReportViewer1.ReportSource = dstx;
        }
    }
}
