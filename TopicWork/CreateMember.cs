using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TopicWork.Infra;
using TopicWork.Models.ViewModels;
using TopicWork.Infra.Extensions;

namespace TopicWork
{
    public partial class CreateMember : Form
    {
        public CreateMember()
        {
            InitializeComponent();
            InitForm();
            InitForm1();
            InitForm2();
            InitForm3();
        }
        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            ContractpaycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM Contract ";
            var dbHelper = new SqlDbHelper("default");

            List<ContractVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToContractVM(row))
                .Prepend(new ContractVM { Cid = 0, Contract = 0 })
                .ToList();

            this.ContractpaycomboBox.DataSource = categories;
        }
        private ContractVM ToContractVM(DataRow row)
        {
            return new ContractVM
            {
                Cid = row.Field<int>("Cid"),
                Contract = row.Field<int>("Contract")
            };
        }

        private void InitForm1()
        {
            // 設定 categoryIdComboBox property
            ContractNamecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM Contract ";
            var dbHelper = new SqlDbHelper("default");

            List<ContractNameVM> categories1 = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToContractVM1(row))
                .Prepend(new ContractNameVM { Cid = 0, ContractName = String.Empty })
                .ToList();

            this.ContractNamecomboBox.DataSource = categories1;
        }
        private ContractNameVM ToContractVM1(DataRow row)
        {
            return new ContractNameVM
            {
                Cid = row.Field<int>("Cid"),
                ContractName = row.Field<string>("ContractName"),
            };
        }

        private void InitForm2()
        {
            // 設定 categoryIdComboBox property
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM Phone ";
            var dbHelper = new SqlDbHelper("default");

            List<PhoneBrandVM> categories2 = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToContractVM2(row))
                .Prepend(new PhoneBrandVM { Pid = 0, PhoneBrand = String.Empty })
                .ToList();

            this.comboBox4.DataSource = categories2;

        }
        private PhoneBrandVM ToContractVM2(DataRow row)
        {
            return new PhoneBrandVM
            {
                Pid = row.Field<int>("Pid"),
                PhoneBrand = row.Field<string>("PhoneBrand")
            };
        }

        private void InitForm3()
        {
            // 設定 categoryIdComboBox property
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM Phone ";
            var dbHelper = new SqlDbHelper("default");

            List<PhoneModelVM> categories3 = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToContractVM3(row))
                .Prepend(new PhoneModelVM { Pid = 0, PhoneModel = String.Empty })
                .ToList();

            this.comboBox5.DataSource = categories3;

        }
        private PhoneModelVM ToContractVM3(DataRow row)
        {
            return new PhoneModelVM
            {
                Pid = row.Field<int>("Pid"),
                PhoneModel = row.Field<string>("PhoneModel")
            };
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string identity = IdentityTextBox.Text;
            string phone = PhoneTextBox.Text;
            DateTime date = Convert.ToDateTime(DateTextBox.Text);
            int contractName = ((ContractNameVM)this.ContractNamecomboBox.SelectedItem).Cid;
            int contract = ((ContractVM)this.ContractpaycomboBox.SelectedItem).Cid;
            int phoneBrand = ((PhoneBrandVM)this.comboBox4.SelectedItem).Pid;
            int phoneModelVM = ((PhoneModelVM)this.comboBox5.SelectedItem).Pid;


            // 將它們繫結到ViewModel
            MemberVM model = new MemberVM
            {
                Name = name,
                IdentityNumber = identity,
                PhoneNumber = phone,
                ContractExpired = date,
                ContractName = contractName.ToString(),
                Contract = contract,
                PhoneBrand = phoneBrand.ToString(),
                PhoneModel = phoneModelVM.ToString(),
                Contract_id = contractName,
                Phone_id = phoneBrand
            };

            // 針對ViewModel進行欄位驗證
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Name", NameTextBox},
                {"IdentityNumber", IdentityTextBox},
                {"PhoneNumber", PhoneTextBox},
                {"ContractExpired", DateTextBox},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;


            // 如果通過驗證,就新增記錄
            try
            {
                new MemberService().Create(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("新增失敗, 原因: " + ex.Message);
            }


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
