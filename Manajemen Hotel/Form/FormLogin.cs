using AMRConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

namespace Manajemen_Hotel
{
    public partial class FormLogin : Form
    {
        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHidden_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHidden, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxHidden.Show();
        }

        private void pictureBoxHidden_Click(object sender, EventArgs e)
        {
            pictureBoxHidden.Hide();
            txtPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
           bool check = db.IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
             if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi kolom terlebih dahulu", "Required Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (check)
                    {
                        FormDashboard.FormDashboard fd = new FormDashboard.FormDashboard();
                        fd.Username = txtUsername.Text;
                        txtUsername.Clear();
                        txtPassword.Clear();
                        fd.Show();  
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Salah", "Username atau Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

    }

}

