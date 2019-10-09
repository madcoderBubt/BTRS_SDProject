namespace BusReservationSystem
{
    partial class CancelTicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ckbEnable = new System.Windows.Forms.CheckBox();
            this.grpPassengerInfo = new System.Windows.Forms.GroupBox();
            this.txtSeatLen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.grpPassengerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus No.";
            // 
            // txtBusNo
            // 
            this.txtBusNo.Location = new System.Drawing.Point(12, 46);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.Size = new System.Drawing.Size(100, 20);
            this.txtBusNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Counter";
            // 
            // txtCounter
            // 
            this.txtCounter.Enabled = false;
            this.txtCounter.Location = new System.Drawing.Point(121, 46);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(100, 20);
            this.txtCounter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ticket No.";
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Location = new System.Drawing.Point(230, 46);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(100, 20);
            this.txtTicketNo.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(177, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ckbEnable
            // 
            this.ckbEnable.AutoSize = true;
            this.ckbEnable.Location = new System.Drawing.Point(12, 258);
            this.ckbEnable.Name = "ckbEnable";
            this.ckbEnable.Size = new System.Drawing.Size(80, 17);
            this.ckbEnable.TabIndex = 14;
            this.ckbEnable.Text = "Enable Edit";
            this.ckbEnable.UseVisualStyleBackColor = true;
            this.ckbEnable.CheckStateChanged += new System.EventHandler(this.CkbEnable_CheckStateChanged);
            // 
            // grpPassengerInfo
            // 
            this.grpPassengerInfo.Controls.Add(this.txtSeatLen);
            this.grpPassengerInfo.Controls.Add(this.label8);
            this.grpPassengerInfo.Controls.Add(this.txtPrice);
            this.grpPassengerInfo.Controls.Add(this.label9);
            this.grpPassengerInfo.Controls.Add(this.txtTo);
            this.grpPassengerInfo.Controls.Add(this.label7);
            this.grpPassengerInfo.Controls.Add(this.txtFrom);
            this.grpPassengerInfo.Controls.Add(this.label6);
            this.grpPassengerInfo.Controls.Add(this.txtPhoneNo);
            this.grpPassengerInfo.Controls.Add(this.label5);
            this.grpPassengerInfo.Controls.Add(this.txtFullName);
            this.grpPassengerInfo.Controls.Add(this.label4);
            this.grpPassengerInfo.Location = new System.Drawing.Point(12, 72);
            this.grpPassengerInfo.Name = "grpPassengerInfo";
            this.grpPassengerInfo.Size = new System.Drawing.Size(320, 142);
            this.grpPassengerInfo.TabIndex = 6;
            this.grpPassengerInfo.TabStop = false;
            this.grpPassengerInfo.Text = "Pessanger Info";
            // 
            // txtSeatLen
            // 
            this.txtSeatLen.Enabled = false;
            this.txtSeatLen.Location = new System.Drawing.Point(69, 100);
            this.txtSeatLen.Name = "txtSeatLen";
            this.txtSeatLen.Size = new System.Drawing.Size(100, 20);
            this.txtSeatLen.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seat Length";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(213, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Price";
            // 
            // txtTo
            // 
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(213, 74);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(69, 74);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "From";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Enabled = false;
            this.txtPhoneNo.Location = new System.Drawing.Point(107, 48);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(206, 20);
            this.txtPhoneNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone No.";
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(107, 22);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(206, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Name";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(96, 220);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 32);
            this.btnGetData.TabIndex = 10;
            this.btnGetData.Text = "Get";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // CancelTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.grpPassengerInfo);
            this.Controls.Add(this.ckbEnable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTicketNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusNo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(360, 320);
            this.MinimumSize = new System.Drawing.Size(360, 320);
            this.Name = "CancelTicketForm";
            this.Text = "CancelTicketForm";
            this.Load += new System.EventHandler(this.CancelTicketForm_Load);
            this.grpPassengerInfo.ResumeLayout(false);
            this.grpPassengerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketNo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox ckbEnable;
        private System.Windows.Forms.GroupBox grpPassengerInfo;
        private System.Windows.Forms.TextBox txtSeatLen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetData;
    }
}