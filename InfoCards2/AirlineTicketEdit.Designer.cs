namespace Assignment
{
    partial class AirlineTicketEdit
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
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtInfoCardName = new System.Windows.Forms.TextBox();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.txtIssuingAirline = new System.Windows.Forms.TextBox();
            this.txtAirportTo = new System.Windows.Forms.TextBox();
            this.txtAirportFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tltError = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDate = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Location = new System.Drawing.Point(160, 187);
            this.txtFlightCode.MaxLength = 5;
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(202, 20);
            this.txtFlightCode.TabIndex = 8;
            this.txtFlightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtFlightCode, "The flight code consists of two parts. The two-letter airline code, followed by a" +
        " 1 to 4 digits long number. Example: XX1234");
            this.txtFlightCode.TextChanged += new System.EventHandler(this.txtFlightCode_TextChanged);
            this.txtFlightCode.Enter += new System.EventHandler(this.txtFlightCode_Enter);
            this.txtFlightCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightCode_KeyPress);
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(160, 108);
            this.txtPassengerName.MaxLength = 20;
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(202, 20);
            this.txtPassengerName.TabIndex = 4;
            this.txtPassengerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPassengerName, "The name of the passenger on the ticket.");
            this.txtPassengerName.TextChanged += new System.EventHandler(this.txtPassengerName_TextChanged);
            this.txtPassengerName.Enter += new System.EventHandler(this.txtPassengerName_Enter);
            this.txtPassengerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassengerName_KeyPress);
            // 
            // txtInfoCardName
            // 
            this.txtInfoCardName.Location = new System.Drawing.Point(160, 30);
            this.txtInfoCardName.MaxLength = 20;
            this.txtInfoCardName.Name = "txtInfoCardName";
            this.txtInfoCardName.Size = new System.Drawing.Size(202, 20);
            this.txtInfoCardName.TabIndex = 0;
            this.txtInfoCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInfoCardName, "A unique name to identify this Info Card.");
            this.txtInfoCardName.TextChanged += new System.EventHandler(this.txtInfoCardName_TextChanged);
            this.txtInfoCardName.Enter += new System.EventHandler(this.txtInfoCardName_Enter);
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(160, 56);
            this.txtTicketNumber.MaxLength = 20;
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(202, 20);
            this.txtTicketNumber.TabIndex = 1;
            this.txtTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtTicketNumber, "The unique identification number of the ticket.\r\n1 to 20 digits long!");
            this.txtTicketNumber.TextChanged += new System.EventHandler(this.txtTicketNumber_TextChanged);
            this.txtTicketNumber.Enter += new System.EventHandler(this.txtTicketNumber_Enter);
            this.txtTicketNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketNumber_KeyPress);
            // 
            // txtIssuingAirline
            // 
            this.txtIssuingAirline.Location = new System.Drawing.Point(160, 134);
            this.txtIssuingAirline.MaxLength = 20;
            this.txtIssuingAirline.Name = "txtIssuingAirline";
            this.txtIssuingAirline.Size = new System.Drawing.Size(202, 20);
            this.txtIssuingAirline.TabIndex = 5;
            this.txtIssuingAirline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtIssuingAirline, "The name of the airline issuing the ticket.");
            this.txtIssuingAirline.TextChanged += new System.EventHandler(this.txtIssuingAirline_TextChanged);
            this.txtIssuingAirline.Enter += new System.EventHandler(this.txtIssuingAirline_Enter);
            this.txtIssuingAirline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIssuingAirline_KeyPress);
            // 
            // txtAirportTo
            // 
            this.txtAirportTo.Location = new System.Drawing.Point(308, 82);
            this.txtAirportTo.MaxLength = 3;
            this.txtAirportTo.Name = "txtAirportTo";
            this.txtAirportTo.Size = new System.Drawing.Size(54, 20);
            this.txtAirportTo.TabIndex = 3;
            this.txtAirportTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAirportTo, "The 3-letter code of the airport of arrival!");
            this.txtAirportTo.TextChanged += new System.EventHandler(this.txtAirportTo_TextChanged);
            this.txtAirportTo.Enter += new System.EventHandler(this.txtAirportTo_Enter);
            this.txtAirportTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAirportTo_KeyPress);
            // 
            // txtAirportFrom
            // 
            this.txtAirportFrom.Location = new System.Drawing.Point(190, 82);
            this.txtAirportFrom.MaxLength = 3;
            this.txtAirportFrom.Name = "txtAirportFrom";
            this.txtAirportFrom.Size = new System.Drawing.Size(54, 20);
            this.txtAirportFrom.TabIndex = 2;
            this.txtAirportFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAirportFrom, "The 3-letter code of the airport of departure!");
            this.txtAirportFrom.TextChanged += new System.EventHandler(this.txtAirportFrom_TextChanged);
            this.txtAirportFrom.Enter += new System.EventHandler(this.txtAirportFrom_Enter);
            this.txtAirportFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAirportFrom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name (for the infocard):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Passenger\'s name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Issuing airline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ticket number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Flight Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date and Time of Departure:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Airport code:";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpDate.CustomFormat = "    dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(1, 1);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(116, 21);
            this.dtpDate.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpDate, "Date of departure.");
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Enter += new System.EventHandler(this.dtpDate_Enter);
            // 
            // dtpTime
            // 
            this.dtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtpTime.CustomFormat = "     HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(280, 160);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(82, 21);
            this.dtpTime.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtpTime, "Time of departure.");
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            this.dtpTime.Enter += new System.EventHandler(this.dtpTime_Enter);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(79, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(227, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tltError
            // 
            this.tltError.IsBalloon = true;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dtpDate);
            this.pnlDate.Location = new System.Drawing.Point(159, 159);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(118, 23);
            this.pnlDate.TabIndex = 20;
            // 
            // pnlTime
            // 
            this.pnlTime.Location = new System.Drawing.Point(279, 159);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(84, 23);
            this.pnlTime.TabIndex = 21;
            // 
            // AirlineTicketEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 274);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAirportTo);
            this.Controls.Add(this.txtAirportFrom);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.txtIssuingAirline);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.txtInfoCardName);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.pnlTime);
            this.Name = "AirlineTicketEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Ticket Edit";
            this.Load += new System.EventHandler(this.AirlineTicketEdit_Load);
            this.pnlDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightCode;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtInfoCardName;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.TextBox txtIssuingAirline;
        private System.Windows.Forms.TextBox txtAirportTo;
        private System.Windows.Forms.TextBox txtAirportFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip tltError;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlTime;
    }
}