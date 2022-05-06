namespace Assignment
{
    partial class AirlineTicketDisplay
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
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtIssuingAirline = new System.Windows.Forms.TextBox();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.txtFromAirport = new System.Windows.Forms.TextBox();
            this.txtToAirport = new System.Windows.Forms.TextBox();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.txtFlightDateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.BackColor = System.Drawing.SystemColors.Info;
            this.txtPassengerName.Location = new System.Drawing.Point(151, 12);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.ReadOnly = true;
            this.txtPassengerName.Size = new System.Drawing.Size(202, 20);
            this.txtPassengerName.TabIndex = 0;
            this.txtPassengerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIssuingAirline
            // 
            this.txtIssuingAirline.BackColor = System.Drawing.SystemColors.Info;
            this.txtIssuingAirline.Location = new System.Drawing.Point(151, 116);
            this.txtIssuingAirline.Name = "txtIssuingAirline";
            this.txtIssuingAirline.ReadOnly = true;
            this.txtIssuingAirline.Size = new System.Drawing.Size(202, 20);
            this.txtIssuingAirline.TabIndex = 1;
            this.txtIssuingAirline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtTicketNumber.Location = new System.Drawing.Point(151, 38);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.ReadOnly = true;
            this.txtTicketNumber.Size = new System.Drawing.Size(202, 20);
            this.txtTicketNumber.TabIndex = 2;
            this.txtTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFromAirport
            // 
            this.txtFromAirport.BackColor = System.Drawing.SystemColors.Info;
            this.txtFromAirport.Location = new System.Drawing.Point(299, 64);
            this.txtFromAirport.Name = "txtFromAirport";
            this.txtFromAirport.ReadOnly = true;
            this.txtFromAirport.Size = new System.Drawing.Size(54, 20);
            this.txtFromAirport.TabIndex = 3;
            this.txtFromAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToAirport
            // 
            this.txtToAirport.BackColor = System.Drawing.SystemColors.Info;
            this.txtToAirport.Location = new System.Drawing.Point(187, 64);
            this.txtToAirport.Name = "txtToAirport";
            this.txtToAirport.ReadOnly = true;
            this.txtToAirport.Size = new System.Drawing.Size(54, 20);
            this.txtToAirport.TabIndex = 4;
            this.txtToAirport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtFlightCode.Location = new System.Drawing.Point(151, 142);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.ReadOnly = true;
            this.txtFlightCode.Size = new System.Drawing.Size(202, 20);
            this.txtFlightCode.TabIndex = 5;
            this.txtFlightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlightDateTime
            // 
            this.txtFlightDateTime.BackColor = System.Drawing.SystemColors.Info;
            this.txtFlightDateTime.Location = new System.Drawing.Point(151, 90);
            this.txtFlightDateTime.Name = "txtFlightDateTime";
            this.txtFlightDateTime.ReadOnly = true;
            this.txtFlightDateTime.Size = new System.Drawing.Size(202, 20);
            this.txtFlightDateTime.TabIndex = 6;
            this.txtFlightDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passenger\'s name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ticket number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Airport code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date and time of departure:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Issuing airline:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flight code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "To:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(148, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AirlineTicketDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 214);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFlightDateTime);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.txtToAirport);
            this.Controls.Add(this.txtFromAirport);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.txtIssuingAirline);
            this.Controls.Add(this.txtPassengerName);
            this.Name = "AirlineTicketDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Ticket";
            this.Load += new System.EventHandler(this.AirlineTicketDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtIssuingAirline;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.TextBox txtFromAirport;
        private System.Windows.Forms.TextBox txtToAirport;
        private System.Windows.Forms.TextBox txtFlightCode;
        private System.Windows.Forms.TextBox txtFlightDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
    }
}