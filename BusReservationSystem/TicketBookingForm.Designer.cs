namespace BusReservationSystem
{
    partial class TicketBookingForm
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
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeatLen = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAvailSeat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Enabled = false;
            this.txtTicketNo.Location = new System.Drawing.Point(13, 71);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(100, 20);
            this.txtTicketNo.TabIndex = 0;
            this.txtTicketNo.TabStop = false;
            this.txtTicketNo.Text = "ticket no";
            // 
            // txtBusNo
            // 
            this.txtBusNo.Enabled = false;
            this.txtBusNo.Location = new System.Drawing.Point(119, 71);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.Size = new System.Drawing.Size(99, 20);
            this.txtBusNo.TabIndex = 0;
            this.txtBusNo.TabStop = false;
            this.txtBusNo.Text = "bus no";
            // 
            // cmbDestination
            // 
            this.cmbDestination.AllowDrop = true;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.ItemHeight = 13;
            this.cmbDestination.Location = new System.Drawing.Point(119, 184);
            this.cmbDestination.MaxDropDownItems = 4;
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(213, 21);
            this.cmbDestination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(119, 106);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(213, 20);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "Mad coder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(119, 132);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(213, 20);
            this.txtPhoneNo.TabIndex = 3;
            this.txtPhoneNo.Text = "+8801632740075";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Seat";
            // 
            // txtSeatLen
            // 
            this.txtSeatLen.Location = new System.Drawing.Point(119, 158);
            this.txtSeatLen.Name = "txtSeatLen";
            this.txtSeatLen.Size = new System.Drawing.Size(99, 20);
            this.txtSeatLen.TabIndex = 3;
            this.txtSeatLen.Text = "0";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(224, 71);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(108, 20);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.TabStop = false;
            this.txtFrom.Text = "from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Destination";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 223);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnBookNow
            // 
            this.btnBookNow.Location = new System.Drawing.Point(119, 223);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(213, 28);
            this.btnBookNow.TabIndex = 5;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.BtnBookNow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Image = global::BusReservationSystem.Properties.Resources.MC_logo;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblAvailSeat
            // 
            this.lblAvailSeat.AutoSize = true;
            this.lblAvailSeat.Location = new System.Drawing.Point(222, 161);
            this.lblAvailSeat.Name = "lblAvailSeat";
            this.lblAvailSeat.Size = new System.Drawing.Size(0, 13);
            this.lblAvailSeat.TabIndex = 7;
            // 
            // TicketBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(349, 264);
            this.Controls.Add(this.lblAvailSeat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtSeatLen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.txtBusNo);
            this.Controls.Add(this.txtTicketNo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 303);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 303);
            this.Name = "TicketBookingForm";
            this.Text = "TicketBookingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicketBookingForm_FormClosing);
            this.Load += new System.EventHandler(this.TicketBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketNo;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeatLen;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBookNow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAvailSeat;
    }
}