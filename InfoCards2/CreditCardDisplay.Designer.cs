namespace Assignment
{
    partial class CreditCardDisplay
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
            this.txtCardholderName = new System.Windows.Forms.TextBox();
            this.txtPan = new System.Windows.Forms.TextBox();
            this.txtCsc = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCardholderName
            // 
            this.txtCardholderName.BackColor = System.Drawing.SystemColors.Info;
            this.txtCardholderName.Location = new System.Drawing.Point(12, 35);
            this.txtCardholderName.Name = "txtCardholderName";
            this.txtCardholderName.ReadOnly = true;
            this.txtCardholderName.Size = new System.Drawing.Size(232, 20);
            this.txtCardholderName.TabIndex = 9;
            this.txtCardholderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPan
            // 
            this.txtPan.BackColor = System.Drawing.SystemColors.Info;
            this.txtPan.Location = new System.Drawing.Point(12, 61);
            this.txtPan.Name = "txtPan";
            this.txtPan.ReadOnly = true;
            this.txtPan.Size = new System.Drawing.Size(232, 20);
            this.txtPan.TabIndex = 10;
            this.txtPan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCsc
            // 
            this.txtCsc.BackColor = System.Drawing.SystemColors.Info;
            this.txtCsc.Location = new System.Drawing.Point(102, 87);
            this.txtCsc.Name = "txtCsc";
            this.txtCsc.ReadOnly = true;
            this.txtCsc.Size = new System.Drawing.Size(142, 20);
            this.txtCsc.TabIndex = 11;
            this.txtCsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExpDate
            // 
            this.txtExpDate.BackColor = System.Drawing.SystemColors.Info;
            this.txtExpDate.Location = new System.Drawing.Point(12, 87);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(84, 20);
            this.txtExpDate.TabIndex = 12;
            this.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(232, 23);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditCardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 120);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtCsc);
            this.Controls.Add(this.txtPan);
            this.Controls.Add(this.txtCardholderName);
            this.Name = "CreditCardDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card";
            this.Load += new System.EventHandler(this.CreditCardDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCardholderName;
        private System.Windows.Forms.TextBox txtPan;
        private System.Windows.Forms.TextBox txtCsc;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblName;
    }
}