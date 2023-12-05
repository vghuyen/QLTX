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
    public partial class BaoCaoBangLuong : Form
    {
        public BaoCaoBangLuong()
        {
            InitializeComponent();
        }

        public Object dataSource;
        public void setDataSource(Object dataSource)
        {
            this.dataSource = dataSource;
        }
        private void BaoCaoBangLuong_Load(object sender, EventArgs e)
        {
            CrystalReportBangLuong dstx = new CrystalReportBangLuong();
            dstx.SetDataSource(dataSource);
            crystalReportViewer1.ReportSource = dstx;
        }
    }
}
