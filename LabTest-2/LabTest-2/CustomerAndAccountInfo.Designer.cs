namespace LabTest_2
{
    partial class CustomerAndAccountInfo
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
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openingDateTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.checkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(206, 50);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(270, 26);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(206, 90);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Number";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(206, 130);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(270, 26);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Opening Date";
            // 
            // openingDateTextBox
            // 
            this.openingDateTextBox.Location = new System.Drawing.Point(206, 170);
            this.openingDateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openingDateTextBox.Name = "openingDateTextBox";
            this.openingDateTextBox.Size = new System.Drawing.Size(270, 26);
            this.openingDateTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(364, 255);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(225, 212);
            this.checkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(0, 20);
            this.checkLabel.TabIndex = 3;
            // 
            // CustomerAndAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.openingDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CustomerAndAccountInfo";
            this.Text = "Customer & Account Info Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox openingDateTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label checkLabel;
    }
}