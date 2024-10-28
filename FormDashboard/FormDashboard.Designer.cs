namespace FormDashboard
{
    partial class FormDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnReservasi);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 681);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 225);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 59);
            this.panelSlide.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = global::FormDashboard.Properties.Resources.settings;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(42, 485);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(183, 59);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "          Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReservasi
            // 
            this.btnReservasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservasi.FlatAppearance.BorderSize = 0;
            this.btnReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservasi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservasi.Image = global::FormDashboard.Properties.Resources.booking;
            this.btnReservasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservasi.Location = new System.Drawing.Point(42, 420);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(183, 59);
            this.btnReservasi.TabIndex = 4;
            this.btnReservasi.Text = "          Reservasi";
            this.btnReservasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservasi.UseVisualStyleBackColor = true;
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Image = global::FormDashboard.Properties.Resources.bed;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(42, 355);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(183, 59);
            this.btnRoom.TabIndex = 3;
            this.btnRoom.Text = "          Room";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Image = global::FormDashboard.Properties.Resources.customer;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(42, 290);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(183, 59);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "          Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = global::FormDashboard.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(42, 225);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(183, 59);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 195);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Hotel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormDashboard.Properties.Resources.house_3661264;
            this.pictureBox1.Location = new System.Drawing.Point(95, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 195);
            this.panel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(123, 138);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(21, 23);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.linkLabelLogOut);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblDateTime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1079, 99);
            this.panel4.TabIndex = 0;
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogOut.Location = new System.Drawing.Point(928, 40);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(57, 16);
            this.linkLabelLogOut.TabIndex = 2;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.VisitedLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::FormDashboard.Properties.Resources.user_15194213;
            this.pictureBox2.Location = new System.Drawing.Point(869, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDateTime.Location = new System.Drawing.Point(7, 69);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(21, 23);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(271, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1079, 486);
            this.panel5.TabIndex = 2;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
    }
}

