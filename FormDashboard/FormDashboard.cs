using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormDashboard
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin untuk Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservasi);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MovePanel(btnSetting);
        }
    }
}
