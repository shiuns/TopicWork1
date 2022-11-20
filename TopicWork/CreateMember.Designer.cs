namespace TopicWork
{
    partial class CreateMember
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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.phoneModelVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.phoneBrandVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContractpaycomboBox = new System.Windows.Forms.ComboBox();
            this.contractVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContractNamecomboBox = new System.Windows.Forms.ComboBox();
            this.contractNameVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.IdentityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phoneModelVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBrandVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractNameVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.phoneModelVMBindingSource;
            this.comboBox5.DisplayMember = "PhoneModel";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(548, 190);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 23);
            this.comboBox5.TabIndex = 29;
            this.comboBox5.ValueMember = "Pid";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // phoneModelVMBindingSource
            // 
            this.phoneModelVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.PhoneModelVM);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.phoneBrandVMBindingSource;
            this.comboBox4.DisplayMember = "PhoneBrand";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(548, 143);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 23);
            this.comboBox4.TabIndex = 28;
            this.comboBox4.ValueMember = "Pid";
            // 
            // phoneBrandVMBindingSource
            // 
            this.phoneBrandVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.PhoneBrandVM);
            // 
            // ContractpaycomboBox
            // 
            this.ContractpaycomboBox.DataSource = this.contractVMBindingSource;
            this.ContractpaycomboBox.DisplayMember = "Contract";
            this.ContractpaycomboBox.FormattingEnabled = true;
            this.ContractpaycomboBox.Location = new System.Drawing.Point(548, 94);
            this.ContractpaycomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContractpaycomboBox.Name = "ContractpaycomboBox";
            this.ContractpaycomboBox.Size = new System.Drawing.Size(160, 23);
            this.ContractpaycomboBox.TabIndex = 27;
            this.ContractpaycomboBox.ValueMember = "Cid";
            // 
            // contractVMBindingSource
            // 
            this.contractVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.ContractVM);
            // 
            // ContractNamecomboBox
            // 
            this.ContractNamecomboBox.DataSource = this.contractNameVMBindingSource;
            this.ContractNamecomboBox.DisplayMember = "ContractName";
            this.ContractNamecomboBox.FormattingEnabled = true;
            this.ContractNamecomboBox.Location = new System.Drawing.Point(548, 37);
            this.ContractNamecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContractNamecomboBox.Name = "ContractNamecomboBox";
            this.ContractNamecomboBox.Size = new System.Drawing.Size(160, 23);
            this.ContractNamecomboBox.TabIndex = 26;
            this.ContractNamecomboBox.ValueMember = "Cid";
            // 
            // contractNameVMBindingSource
            // 
            this.contractNameVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.ContractNameVM);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(576, 257);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 29);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "儲存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "合約到期日:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "電話號碼:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "身分證號碼:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "手機型號:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "手機品牌:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "月租費:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "合約名稱:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "姓名:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(133, 193);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(191, 25);
            this.DateTextBox.TabIndex = 14;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(117, 131);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(207, 25);
            this.PhoneTextBox.TabIndex = 13;
            // 
            // IdentityTextBox
            // 
            this.IdentityTextBox.Location = new System.Drawing.Point(133, 81);
            this.IdentityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdentityTextBox.Name = "IdentityTextBox";
            this.IdentityTextBox.Size = new System.Drawing.Size(191, 25);
            this.IdentityTextBox.TabIndex = 15;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(85, 31);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(239, 25);
            this.NameTextBox.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 301);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.ContractpaycomboBox);
            this.Controls.Add(this.ContractNamecomboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.IdentityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "CreateMember";
            this.Text = "CreateMember";
            ((System.ComponentModel.ISupportInitialize)(this.phoneModelVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBrandVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractNameVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox ContractpaycomboBox;
        private System.Windows.Forms.ComboBox ContractNamecomboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox IdentityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource phoneModelVMBindingSource;
        private System.Windows.Forms.BindingSource phoneBrandVMBindingSource;
        private System.Windows.Forms.BindingSource contractVMBindingSource;
        private System.Windows.Forms.BindingSource contractNameVMBindingSource;
    }
}