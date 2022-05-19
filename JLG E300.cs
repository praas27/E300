using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E300
{
    public partial class FormStart : Form
    {
        private Form activeForm;

        private void OpenSchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelStart.Controls.Add(childForm);
            this.panelStart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            OpenSchildForm(new Home(), sender);
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.ForeColor = Color.FromArgb(0, 129, 249);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Home(), sender);
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.ForeColor = Color.FromArgb(0, 129, 249);
        }
        private void btnGround_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Grond_Bediening(), sender);
            pnlNav.Height = btnGround.Height;
            pnlNav.Top = btnGround.Top;
            pnlNav.Left = btnGround.Left;
            btnGround.ForeColor = Color.FromArgb(0, 129, 249);
        }

        private void btnPlatform_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Platform_Bediening(), sender);
            pnlNav.Height = btnPlatform.Height;
            pnlNav.Top = btnPlatform.Top;
            pnlNav.Left = btnPlatform.Left;
            btnPlatform.ForeColor = Color.FromArgb(0, 129, 249);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Auto_Bediening(), sender);
            pnlNav.Height = btnAuto.Height;
            pnlNav.Top = btnAuto.Top;
            pnlNav.Left = btnAuto.Left;
            btnAuto.ForeColor = Color.FromArgb(0, 129, 249);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.FromArgb(147, 140, 151);
        }

        private void btnGround_Leave(object sender, EventArgs e)
        {
            btnGround.ForeColor = Color.FromArgb(147, 140, 151);
        }

        private void btnPlatform_Leave(object sender, EventArgs e)
        {
            btnPlatform.ForeColor = Color.FromArgb(147, 140, 151);
        }

        private void btnAuto_Leave(object sender, EventArgs e)
        {
            btnAuto.ForeColor = Color.FromArgb(147, 140, 151);
        }
    }
}
