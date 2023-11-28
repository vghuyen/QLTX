using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ_For_Wang_Test
{
    public partial class Form1 : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        //Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
            if ( currentButton  !=  (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    
            }    
        }
        private void DisableButton()
        {
            foreach (Control previousbtn in panelMenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(58, 106, 170);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyVi(), sender);
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLPT(), sender);
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTaiXe(), sender);
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBaoCao(), sender);
        }

        private void btnPT_Click(object sender, EventArgs e)
        {

        }

        private void btnPT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLPT(), sender);
        }

        private void btnWallet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyVi(), sender);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBaoCao(), sender);
        }

        private void btnTX_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTaiXe(), sender);
        }

        private void btnPT_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLPT(), sender);
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQuanLyVi(), sender);
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBaoCao(), sender);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGioHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGioHD(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBangLuong(), sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTX_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.instance.exitApp();
        }
    }
}
