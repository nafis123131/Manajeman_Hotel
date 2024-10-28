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

namespace FormDashboard.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            tabSearchUser.SelectedTab = tabPageAddUser;

        }

        private void Clear1()
        {
            txtUsernameUpdate_Delete.Clear();
            txtPasswordUpdate_Delete.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
           //txtCariUsername.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            txtCariUsername.Clear();
        }

        private void tabPageUpdateDanDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool check;
                if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty) MessageBox.Show("Please fill out all fields.", "Required all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (check)
                    Clear();
            }
        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
