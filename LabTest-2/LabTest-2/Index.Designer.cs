namespace LabTest_2
{
    partial class Index
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
            this.SaveCustomerAccountInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TransactionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SearchCustomerAccountInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SaveCustomerAccountInfoLinkLabel
            // 
            this.SaveCustomerAccountInfoLinkLabel.AutoSize = true;
            this.SaveCustomerAccountInfoLinkLabel.Location = new System.Drawing.Point(375, 212);
            this.SaveCustomerAccountInfoLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaveCustomerAccountInfoLinkLabel.Name = "SaveCustomerAccountInfoLinkLabel";
            this.SaveCustomerAccountInfoLinkLabel.Size = new System.Drawing.Size(244, 20);
            this.SaveCustomerAccountInfoLinkLabel.TabIndex = 0;
            this.SaveCustomerAccountInfoLinkLabel.TabStop = true;
            this.SaveCustomerAccountInfoLinkLabel.Text = "Save Customer and Account Info";
            this.SaveCustomerAccountInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveCustomerAccountInfoLinkLabel_LinkClicked);
            // 
            // TransactionLinkLabel
            // 
            this.TransactionLinkLabel.AutoSize = true;
            this.TransactionLinkLabel.Location = new System.Drawing.Point(453, 268);
            this.TransactionLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransactionLinkLabel.Name = "TransactionLinkLabel";
            this.TransactionLinkLabel.Size = new System.Drawing.Size(92, 20);
            this.TransactionLinkLabel.TabIndex = 1;
            this.TransactionLinkLabel.TabStop = true;
            this.TransactionLinkLabel.Text = "Transaction";
            this.TransactionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TransactionLinkLabel_LinkClicked);
            // 
            // SearchCustomerAccountInfoLinkLabel
            // 
            this.SearchCustomerAccountInfoLinkLabel.AutoSize = true;
            this.SearchCustomerAccountInfoLinkLabel.Location = new System.Drawing.Point(375, 325);
            this.SearchCustomerAccountInfoLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchCustomerAccountInfoLinkLabel.Name = "SearchCustomerAccountInfoLinkLabel";
            this.SearchCustomerAccountInfoLinkLabel.Size = new System.Drawing.Size(259, 20);
            this.SearchCustomerAccountInfoLinkLabel.TabIndex = 2;
            this.SearchCustomerAccountInfoLinkLabel.TabStop = true;
            this.SearchCustomerAccountInfoLinkLabel.Text = "Search Customer and Account Info";
            this.SearchCustomerAccountInfoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchCustomerAccountInfoLinkLabel_LinkClicked);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 575);
            this.Controls.Add(this.SearchCustomerAccountInfoLinkLabel);
            this.Controls.Add(this.TransactionLinkLabel);
            this.Controls.Add(this.SaveCustomerAccountInfoLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.Text = "Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SaveCustomerAccountInfoLinkLabel;
        private System.Windows.Forms.LinkLabel TransactionLinkLabel;
        private System.Windows.Forms.LinkLabel SearchCustomerAccountInfoLinkLabel;
    }
}

