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

        public int trangthai;

        ketnoi kn = new ketnoi();

        public void setTrangThai(int trangthai)
        {
            this.trangthai = trangthai;
        }

        private void baocao1_Load(object sender, EventArgs e)
        {
            string query = string.Format("select *," +
                " CASE WHEN TrangThai = 0 THEN N'Đã nghỉ việc' ELSE N'Đang làm việc'  END AS trang_thai " +
                " from tb_TaiXe where {0} = 2 OR TrangThai = {0}", trangthai);
            DataSet ds = kn.laydulieu(query, "tb_TaiXe");
            // dgvQLTX.DataSource = ds.Tables["tb_TaiXe"];
            DSTX dstx = new DSTX();
            dstx.SetDataSource(ds.Tables["tb_TaiXe"]);
            crystalReportViewer1.ReportSource = dstx;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
