namespace TopicWork
{
	partial class Members
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.mIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractExpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.identityNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.contractExpiredDataGridViewTextBoxColumn,
            this.contractNameDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.phoneBrandDataGridViewTextBoxColumn,
            this.phoneModelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberIndexVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(296, 46);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(45, 48);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(207, 25);
            this.searchTextBox.TabIndex = 2;
            // 
            // mIdDataGridViewTextBoxColumn
            // 
            this.mIdDataGridViewTextBoxColumn.DataPropertyName = "mId";
            this.mIdDataGridViewTextBoxColumn.HeaderText = "mId";
            this.mIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIdDataGridViewTextBoxColumn.Name = "mIdDataGridViewTextBoxColumn";
            this.mIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // identityNumberDataGridViewTextBoxColumn
            // 
            this.identityNumberDataGridViewTextBoxColumn.DataPropertyName = "IdentityNumber";
            this.identityNumberDataGridViewTextBoxColumn.HeaderText = "IdentityNumber";
            this.identityNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identityNumberDataGridViewTextBoxColumn.Name = "identityNumberDataGridViewTextBoxColumn";
            this.identityNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.identityNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractExpiredDataGridViewTextBoxColumn
            // 
            this.contractExpiredDataGridViewTextBoxColumn.DataPropertyName = "ContractExpired";
            this.contractExpiredDataGridViewTextBoxColumn.HeaderText = "ContractExpired";
            this.contractExpiredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractExpiredDataGridViewTextBoxColumn.Name = "contractExpiredDataGridViewTextBoxColumn";
            this.contractExpiredDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractExpiredDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractNameDataGridViewTextBoxColumn
            // 
            this.contractNameDataGridViewTextBoxColumn.DataPropertyName = "ContractName";
            this.contractNameDataGridViewTextBoxColumn.HeaderText = "ContractName";
            this.contractNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractNameDataGridViewTextBoxColumn.Name = "contractNameDataGridViewTextBoxColumn";
            this.contractNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Contract";
            this.contractDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneBrandDataGridViewTextBoxColumn
            // 
            this.phoneBrandDataGridViewTextBoxColumn.DataPropertyName = "PhoneBrand";
            this.phoneBrandDataGridViewTextBoxColumn.HeaderText = "PhoneBrand";
            this.phoneBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneBrandDataGridViewTextBoxColumn.Name = "phoneBrandDataGridViewTextBoxColumn";
            this.phoneBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneBrandDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneModelDataGridViewTextBoxColumn
            // 
            this.phoneModelDataGridViewTextBoxColumn.DataPropertyName = "PhoneModel";
            this.phoneModelDataGridViewTextBoxColumn.HeaderText = "PhoneModel";
            this.phoneModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneModelDataGridViewTextBoxColumn.Name = "phoneModelDataGridViewTextBoxColumn";
            this.phoneModelDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneModelDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIndexVMBindingSource
            // 
            this.memberIndexVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.MemberIndexVM);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 544);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Members";
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identityNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractExpiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberIndexVMBindingSource;
    }
}