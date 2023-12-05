using PJ_For_Wang_Test.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test.PopsUp
{
    public partial class baocao3 : Form
    {

        DateTime fromDate;
        DateTime toDate;
        public baocao3(DateTime from, DateTime to)
        {
            fromDate = from;
            toDate = to;
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();

        public void getData()
        {
            string query = string.Format("select * from tb_TaiXe WHERE NgayHetHD between '{0}' AND '{1}' " +
               " order by MaTX", fromDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), toDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            DataTable dt = ds.Tables["tb_TaiXe"];
            CrystalReport3 dstx = new CrystalReport3();
            dstx.SetDataSource(ds.Tables["tb_TaiXe"]);
            crystalReportViewer1.ReportSource = dstx;
        }

        private void baocao3_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
