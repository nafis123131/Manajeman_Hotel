namespace FormDashboard.User_Control
{
    partial class UserControlSetting
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabSearchUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCariUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateDanDelete = new System.Windows.Forms.TabPage();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.txtPasswordUpdate_Delete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsernameUpdate_Delete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabSearchUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageUpdateDanDelete.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSearchUser
            // 
            this.tabSearchUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabSearchUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabSearchUser.Controls.Add(this.tabPageAddUser);
            this.tabSearchUser.Controls.Add(this.tabPageSearchUser);
            this.tabSearchUser.Controls.Add(this.tabPageUpdateDanDelete);
            this.tabSearchUser.Location = new System.Drawing.Point(27, 26);
            this.tabSearchUser.Name = "tabSearchUser";
            this.tabSearchUser.SelectedIndex = 0;
            this.tabSearchUser.Size = new System.Drawing.Size(1050, 408);
            this.tabSearchUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.btnAddUser);
            this.tabPageAddUser.Controls.Add(this.txtPassword);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.txtUsername);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1042, 378);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Tambah User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(184, 164);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(115, 37);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(566, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(268, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(184, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(268, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username : ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User : ";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUser.Controls.Add(this.txtCariUsername);
            this.tabPageSearchUser.Controls.Add(this.label7);
            this.tabPageSearchUser.Controls.Add(this.label4);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1042, 378);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Cari User";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            this.tabPageSearchUser.Enter += new System.EventHandler(this.tabPageSearchUser_Enter);
            this.tabPageSearchUser.Leave += new System.EventHandler(this.tabPageSearchUser_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewUser.Location = new System.Drawing.Point(19, 111);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(1001, 246);
            this.dataGridViewUser.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtCariUsername
            // 
            this.txtCariUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCariUsername.Location = new System.Drawing.Point(179, 68);
            this.txtCariUsername.Name = "txtCariUsername";
            this.txtCariUsername.Size = new System.Drawing.Size(268, 23);
            this.txtCariUsername.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search User :";
            // 
            // tabPageUpdateDanDelete
            // 
            this.tabPageUpdateDanDelete.Controls.Add(this.btnDeleteUser);
            this.tabPageUpdateDanDelete.Controls.Add(this.btnUpdateUser);
            this.tabPageUpdateDanDelete.Controls.Add(this.txtPasswordUpdate_Delete);
            this.tabPageUpdateDanDelete.Controls.Add(this.label5);
            this.tabPageUpdateDanDelete.Controls.Add(this.txtUsernameUpdate_Delete);
            this.tabPageUpdateDanDelete.Controls.Add(this.label6);
            this.tabPageUpdateDanDelete.Controls.Add(this.label8);
            this.tabPageUpdateDanDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDanDelete.Name = "tabPageUpdateDanDelete";
            this.tabPageUpdateDanDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDanDelete.Size = new System.Drawing.Size(1042, 378);
            this.tabPageUpdateDanDelete.TabIndex = 2;
            this.tabPageUpdateDanDelete.Text = "Update dan Delete";
            this.tabPageUpdateDanDelete.UseVisualStyleBackColor = true;
            this.tabPageUpdateDanDelete.Leave += new System.EventHandler(this.tabPageUpdateDanDelete_Leave);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(334, 165);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(115, 37);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(181, 165);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(115, 37);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // txtPasswordUpdate_Delete
            // 
            this.txtPasswordUpdate_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordUpdate_Delete.Location = new System.Drawing.Point(563, 126);
            this.txtPasswordUpdate_Delete.Name = "txtPasswordUpdate_Delete";
            this.txtPasswordUpdate_Delete.Size = new System.Drawing.Size(268, 23);
            this.txtPasswordUpdate_Delete.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password : ";
            // 
            // txtUsernameUpdate_Delete
            // 
            this.txtUsernameUpdate_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameUpdate_Delete.Location = new System.Drawing.Point(181, 126);
            this.txtUsernameUpdate_Delete.Name = "txtUsernameUpdate_Delete";
            this.txtUsernameUpdate_Delete.Size = new System.Drawing.Size(268, 23);
            this.txtUsernameUpdate_Delete.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Update dan Delete User :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabSearchUser);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlSetting_Load);
            this.tabSearchUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageUpdateDanDelete.ResumeLayout(false);
            this.tabPageUpdateDanDelete.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCariUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPageUpdateDanDelete;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtPasswordUpdate_Delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsernameUpdate_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabControl tabSearchUser;
    }
}
