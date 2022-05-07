namespace Assignment
{
    partial class CreditCardEdit
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
            this.txtCardholderName = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtCSC = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbExpMonth = new System.Windows.Forms.ComboBox();
            this.cmbExpYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtCardholderName
            // 
            this.txtCardholderName.Location = new System.Drawing.Point(157, 47);
            this.txtCardholderName.MaxLength = 25;
            this.txtCardholderName.Name = "txtCardholderName";
            this.txtCardholderName.Size = new System.Drawing.Size(232, 20);
            this.txtCardholderName.TabIndex = 1;
            this.txtCardholderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltip.SetToolTip(this.txtCardholderName, "The cardholder\'s name, as written on the credit card.");
            this.txtCardholderName.TextChanged += new System.EventHandler(this.txtCardholderName_TextChanged);
            this.txtCardholderName.Enter += new System.EventHandler(this.txtCardholderName_Enter);
            this.txtCardholderName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardholderName_KeyPress);
            // 
            // txtPan
            // 
            this.txtPan.Location = new System.Drawing.Point(157, 73);
            this.txtPan.MaxLength = 19;
            this.txtPan.Name = "txtPan";
            this.txtPan.Size = new System.Drawing.Size(232, 20);
            this.txtPan.TabIndex = 2;
            this.txtPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltip.SetToolTip(this.txtPan, "The number on the card, 10 -19 digits long.");
            this.txtPan.TextChanged += new System.EventHandler(this.txtPan_TextChanged);
            this.txtPan.Enter += new System.EventHandler(this.txtPan_Enter);
            this.txtPan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPan_KeyPress);
            // 
            // txtCSC
            // 
            this.txtCSC.Location = new System.Drawing.Point(210, 126);
            this.txtCSC.MaxLength = 4;
            this.txtCSC.Name = "txtCSC";
            this.txtCSC.Size = new System.Drawing.Size(116, 20);
            this.txtCSC.TabIndex = 5;
            this.txtCSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltip.SetToolTip(this.txtCSC, "A 3-digit number, located on the back of your card.\r\nSome credit cards might have" +
        " a 4-digit number, on the front side.");
            this.txtCSC.TextChanged += new System.EventHandler(this.txtCSC_TextChanged);
            this.txtCSC.Enter += new System.EventHandler(this.txtCSC_Enter);
            this.txtCSC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSC_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(74, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = " Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(260, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name (on the card):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Card number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expiration Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Card Security Code:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(157, 21);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltip.SetToolTip(this.txtName, "A unique name, to identify this Info Card.");
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // cmbExpMonth
            // 
            this.cmbExpMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpMonth.FormattingEnabled = true;
            this.cmbExpMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbExpMonth.Location = new System.Drawing.Point(157, 99);
            this.cmbExpMonth.Name = "cmbExpMonth";
            this.cmbExpMonth.Size = new System.Drawing.Size(105, 21);
            this.cmbExpMonth.TabIndex = 3;
            this.tooltip.SetToolTip(this.cmbExpMonth, "Expiry Month");
            this.cmbExpMonth.SelectedIndexChanged += new System.EventHandler(this.cmbExpMonth_SelectedIndexChanged);
            this.cmbExpMonth.Enter += new System.EventHandler(this.cmbExpMonth_Enter);
            // 
            // cmbExpYear
            // 
            this.cmbExpYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpYear.FormattingEnabled = true;
            this.cmbExpYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099"});
            this.cmbExpYear.Location = new System.Drawing.Point(284, 99);
            this.cmbExpYear.Name = "cmbExpYear";
            this.cmbExpYear.Size = new System.Drawing.Size(105, 21);
            this.cmbExpYear.TabIndex = 4;
            this.tooltip.SetToolTip(this.cmbExpYear, "Expiry Year");
            this.cmbExpYear.SelectedIndexChanged += new System.EventHandler(this.cmbExpYear_SelectedIndexChanged);
            this.cmbExpYear.Enter += new System.EventHandler(this.cmbExpYear_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name (of the Info Card):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMonth
            // 
            this.pnlMonth.Location = new System.Drawing.Point(156, 98);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(107, 23);
            this.pnlMonth.TabIndex = 26;
            // 
            // pnlYear
            // 
            this.pnlYear.Location = new System.Drawing.Point(283, 98);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(107, 23);
            this.pnlYear.TabIndex = 27;
            // 
            // CreditCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(412, 201);
            this.Controls.Add(this.cmbExpYear);
            this.Controls.Add(this.cmbExpMonth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCSC);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.txtCardholderName);
            this.Controls.Add(this.pnlMonth);
            this.Controls.Add(this.pnlYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Name = "CreditCardEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Credit Card Data";
            this.Load += new System.EventHandler(this.CreditCardEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardholderName;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtCSC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbExpMonth;
        private System.Windows.Forms.ComboBox cmbExpYear;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Panel pnlYear;
    }
}