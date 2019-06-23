namespace LabTest_2
{
    partial class Transaction
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
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(212, 63);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(223, 26);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(212, 105);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(223, 26);
            this.amountTextBox.TabIndex = 1;
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(184, 163);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(112, 35);
            this.DepositButton.TabIndex = 2;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(322, 163);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(112, 35);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 257);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button withdrawButton;
    }
}