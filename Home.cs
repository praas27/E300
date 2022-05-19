using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E300
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void tbGrondbediening_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPlatformbediening_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            tbGrondbediening.Text = Properties.Settings.Default.Gscript;
            tbPlatformbediening.Text = Properties.Settings.Default.Pscript;
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Orders SCRIPT File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "TXE",
                Filter = "trx file files (*.txe)|*.txe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbGrondbediening.Text = openFileDialog1.FileName;
                Properties.Settings.Default.Gscript = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btnPlatform_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Orders SCRIPT File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "script",
                Filter = "trx file files (*.txe)|*.txe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPlatformbediening.Text = openFileDialog1.FileName;
                Properties.Settings.Default.Pscript = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}
