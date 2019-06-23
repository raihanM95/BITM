namespace LabTest_2
{
    partial class SearchCustomerAndAccountInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkSearchLabel = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(234, 88);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(228, 26);
            this.searchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(510, 84);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 35);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.openingDateDataGridViewTextBoxColumn,
            this.Balance});
            this.displayDataGridView.DataSource = this.customerBindingSource;
            this.displayDataGridView.Location = new System.Drawing.Point(39, 175);
            this.displayDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(656, 231);
            this.displayDataGridView.TabIndex = 3;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // checkSearchLabel
            // 
            this.checkSearchLabel.AutoSize = true;
            this.checkSearchLabel.Location = new System.Drawing.Point(106, 122);
            this.checkSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkSearchLabel.Name = "checkSearchLabel";
            this.checkSearchLabel.Size = new System.Drawing.Size(0, 20);
            this.checkSearchLabel.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "Account Number";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // openingDateDataGridViewTextBoxColumn
            // 
            this.openingDateDataGridViewTextBoxColumn.DataPropertyName = "OpeningDate";
            this.openingDateDataGridViewTextBoxColumn.HeaderText = "Opening Date";
            this.openingDateDataGridViewTextBoxColumn.Name = "openingDateDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(LabTest_2.Models.Customer);
            // 
            // SearchCustomerAndAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 448);
            this.Controls.Add(this.checkSearchLabel);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SearchCustomerAndAccountInfo";
            this.Text = "Search Customer & Account Info";
            this.Load += new System.EventHandler(this.SearchCustomerAndAccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Label checkSearchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}