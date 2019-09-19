namespace BusReservationSystem
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignBussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPessangerList = new System.Windows.Forms.Button();
            this.btnFindBus = new System.Windows.Forms.Button();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.btnCheckRoute = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbBusType = new System.Windows.Forms.ComboBox();
            this.dtpBusTime = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(800, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "Log";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignBussToolStripMenuItem,
            this.asignRouteToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // asignBussToolStripMenuItem
            // 
            this.asignBussToolStripMenuItem.Name = "asignBussToolStripMenuItem";
            this.asignBussToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.asignBussToolStripMenuItem.Text = "Asign Buss";
            // 
            // asignRouteToolStripMenuItem
            // 
            this.asignRouteToolStripMenuItem.Name = "asignRouteToolStripMenuItem";
            this.asignRouteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.asignRouteToolStripMenuItem.Text = "Asign Route";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(3, 3);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(131, 20);
            this.txtCounter.TabIndex = 0;
            this.txtCounter.Text = "Counter Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnPessangerList);
            this.panel2.Controls.Add(this.btnFindBus);
            this.panel2.Controls.Add(this.btnPrintTicket);
            this.panel2.Controls.Add(this.btnCheckRoute);
            this.panel2.Controls.Add(this.btnBookTicket);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 399);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::BusReservationSystem.Properties.Resources.MC_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPessangerList
            // 
            this.btnPessangerList.Location = new System.Drawing.Point(3, 210);
            this.btnPessangerList.Name = "btnPessangerList";
            this.btnPessangerList.Size = new System.Drawing.Size(205, 45);
            this.btnPessangerList.TabIndex = 0;
            this.btnPessangerList.Text = "Pessanger List";
            this.btnPessangerList.UseVisualStyleBackColor = true;
            this.btnPessangerList.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFindBus
            // 
            this.btnFindBus.Location = new System.Drawing.Point(3, 159);
            this.btnFindBus.Name = "btnFindBus";
            this.btnFindBus.Size = new System.Drawing.Size(205, 45);
            this.btnFindBus.TabIndex = 0;
            this.btnFindBus.Text = "Get Available Bus";
            this.btnFindBus.UseVisualStyleBackColor = true;
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.Location = new System.Drawing.Point(3, 108);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(205, 45);
            this.btnPrintTicket.TabIndex = 0;
            this.btnPrintTicket.Text = "Print Ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = true;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // btnCheckRoute
            // 
            this.btnCheckRoute.BackColor = System.Drawing.Color.Crimson;
            this.btnCheckRoute.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCheckRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnCheckRoute.ForeColor = System.Drawing.Color.White;
            this.btnCheckRoute.Location = new System.Drawing.Point(3, 57);
            this.btnCheckRoute.Name = "btnCheckRoute";
            this.btnCheckRoute.Size = new System.Drawing.Size(205, 45);
            this.btnCheckRoute.TabIndex = 0;
            this.btnCheckRoute.Text = "Cancel Ticket";
            this.btnCheckRoute.UseVisualStyleBackColor = false;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(3, 6);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(205, 45);
            this.btnBookTicket.TabIndex = 0;
            this.btnBookTicket.Text = "Book Ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(213, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 399);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCurrentUser.Location = new System.Drawing.Point(3, 6);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(109, 15);
            this.lblCurrentUser.TabIndex = 1;
            this.lblCurrentUser.Text = " Sudha (Magura-1)";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtCounter);
            this.flowLayoutPanel1.Controls.Add(this.cmbBusType);
            this.flowLayoutPanel1.Controls.Add(this.dtpBusTime);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(293, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbBusType
            // 
            this.cmbBusType.FormattingEnabled = true;
            this.cmbBusType.Items.AddRange(new object[] {
            "Search By",
            "Ticket No",
            "Time",
            "Counter Name"});
            this.cmbBusType.Location = new System.Drawing.Point(140, 3);
            this.cmbBusType.Name = "cmbBusType";
            this.cmbBusType.Size = new System.Drawing.Size(124, 21);
            this.cmbBusType.TabIndex = 1;
            this.cmbBusType.Text = "Bus Type";
            // 
            // dtpBusTime
            // 
            this.dtpBusTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBusTime.Location = new System.Drawing.Point(270, 3);
            this.dtpBusTime.Name = "dtpBusTime";
            this.dtpBusTime.Size = new System.Drawing.Size(103, 20);
            this.dtpBusTime.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResetClick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Dashboard";
            this.Text = "Dashboard - BTRS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnPessangerList;
        private System.Windows.Forms.Button btnFindBus;
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.Button btnCheckRoute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignBussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignRouteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbBusType;
        private System.Windows.Forms.DateTimePicker dtpBusTime;
        private System.Windows.Forms.Button button2;
    }
}