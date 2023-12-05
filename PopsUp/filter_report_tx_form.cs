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
    public partial class filter_report_tx_form : Form
    {
        public filter_report_tx_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form miniPopup = new Form();
            using (PopsUp.baocao3 popup = new PopsUp.baocao3(fromDateTime.Value, toDateTime.Value))
            {
                popup.Owner = miniPopup;

                popup.ShowDialog();
            }
        }
    }
}
