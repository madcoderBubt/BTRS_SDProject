namespace BusReservationSystem
{
    partial class UserLog
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbRegister_Role = new System.Windows.Forms.ComboBox();
            this.cmbRegister_Counter = new System.Windows.Forms.ComboBox();
            this.txtRegister_Password = new System.Windows.Forms.TextBox();
            this.txtRegister_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegister_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.PictureBox();
            this.btnLinkR = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLog_Passsword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpRegister.SuspendLayout();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusReservationSystem.Properties.Resources.bus;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BTRS - SDProject";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(595, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(625, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpRegister);
            this.panel2.Controls.Add(this.grpLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 241);
            this.panel2.TabIndex = 1;
            // 
            // grpRegister
            // 
            this.grpRegister.BackgroundImage = global::BusReservationSystem.Properties.Resources.bus_back;
            this.grpRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpRegister.Controls.Add(this.btnRegister);
            this.grpRegister.Controls.Add(this.cmbRegister_Role);
            this.grpRegister.Controls.Add(this.cmbRegister_Counter);
            this.grpRegister.Controls.Add(this.txtRegister_Password);
            this.grpRegister.Controls.Add(this.txtRegister_Phone);
            this.grpRegister.Controls.Add(this.label7);
            this.grpRegister.Controls.Add(this.label6);
            this.grpRegister.Controls.Add(this.label5);
            this.grpRegister.Controls.Add(this.txtRegister_Name);
            this.grpRegister.Controls.Add(this.label4);
            this.grpRegister.Location = new System.Drawing.Point(317, 24);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(324, 194);
            this.grpRegister.TabIndex = 1;
            this.grpRegister.TabStop = false;
            this.grpRegister.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(20, 125);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(283, 40);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbRegister_Role
            // 
            this.cmbRegister_Role.FormattingEnabled = true;
            this.cmbRegister_Role.Items.AddRange(new object[] {
            "Designation"});
            this.cmbRegister_Role.Location = new System.Drawing.Point(200, 100);
            this.cmbRegister_Role.Name = "cmbRegister_Role";
            this.cmbRegister_Role.Size = new System.Drawing.Size(103, 21);
            this.cmbRegister_Role.TabIndex = 5;
            this.cmbRegister_Role.Text = "Role";
            // 
            // cmbRegister_Counter
            // 
            this.cmbRegister_Counter.FormattingEnabled = true;
            this.cmbRegister_Counter.Items.AddRange(new object[] {
            "Counter"});
            this.cmbRegister_Counter.Location = new System.Drawing.Point(77, 100);
            this.cmbRegister_Counter.Name = "cmbRegister_Counter";
            this.cmbRegister_Counter.Size = new System.Drawing.Size(117, 21);
            this.cmbRegister_Counter.TabIndex = 4;
            this.cmbRegister_Counter.Text = "Counter";
            // 
            // txtRegister_Password
            // 
            this.txtRegister_Password.Location = new System.Drawing.Point(77, 76);
            this.txtRegister_Password.Name = "txtRegister_Password";
            this.txtRegister_Password.Size = new System.Drawing.Size(226, 20);
            this.txtRegister_Password.TabIndex = 3;
            this.txtRegister_Password.UseSystemPasswordChar = true;
            this.txtRegister_Password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRegister_Phone
            // 
            this.txtRegister_Phone.Location = new System.Drawing.Point(77, 51);
            this.txtRegister_Phone.Name = "txtRegister_Phone";
            this.txtRegister_Phone.Size = new System.Drawing.Size(226, 20);
            this.txtRegister_Phone.TabIndex = 2;
            this.txtRegister_Phone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(17, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Counter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pasword";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone No.";
            // 
            // txtRegister_Name
            // 
            this.txtRegister_Name.Location = new System.Drawing.Point(77, 28);
            this.txtRegister_Name.Name = "txtRegister_Name";
            this.txtRegister_Name.Size = new System.Drawing.Size(226, 20);
            this.txtRegister_Name.TabIndex = 1;
            this.txtRegister_Name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name";
            // 
            // grpLogin
            // 
            this.grpLogin.BackgroundImage = global::BusReservationSystem.Properties.Resources.bus_back;
            this.grpLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpLogin.Controls.Add(this.btnAbout);
            this.grpLogin.Controls.Add(this.btnLinkR);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtLog_Passsword);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtLog_Phone);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Location = new System.Drawing.Point(12, 24);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(281, 194);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "LogIn";
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::BusReservationSystem.Properties.Resources.attention_512;
            this.btnAbout.Location = new System.Drawing.Point(257, 9);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(22, 23);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbout.TabIndex = 4;
            this.btnAbout.TabStop = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLinkR
            // 
            this.btnLinkR.AutoSize = true;
            this.btnLinkR.BackColor = System.Drawing.Color.Transparent;
            this.btnLinkR.Location = new System.Drawing.Point(112, 171);
            this.btnLinkR.Name = "btnLinkR";
            this.btnLinkR.Size = new System.Drawing.Size(71, 13);
            this.btnLinkR.TabIndex = 4;
            this.btnLinkR.TabStop = true;
            this.btnLinkR.Text = "Register Now";
            this.btnLinkR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(17, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(242, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog_Passsword
            // 
            this.txtLog_Passsword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog_Passsword.Location = new System.Drawing.Point(17, 97);
            this.txtLog_Passsword.Name = "txtLog_Passsword";
            this.txtLog_Passsword.Size = new System.Drawing.Size(242, 22);
            this.txtLog_Passsword.TabIndex = 2;
            this.txtLog_Passsword.Text = "12345";
            this.txtLog_Passsword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txtLog_Phone
            // 
            this.txtLog_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog_Phone.Location = new System.Drawing.Point(17, 53);
            this.txtLog_Phone.Name = "txtLog_Phone";
            this.txtLog_Phone.Size = new System.Drawing.Size(242, 22);
            this.txtLog_Phone.TabIndex = 1;
            this.txtLog_Phone.Text = "01720000830";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone No.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 271);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Log - BTRS";
            this.Load += new System.EventHandler(this.UserLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtLog_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog_Passsword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel btnLinkR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.TextBox txtRegister_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegister_Password;
        private System.Windows.Forms.TextBox txtRegister_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRegister_Counter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRegister_Role;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}