using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Infra;
using TopicWork.Infra.Extensions;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
    public partial class EditMember : Form
    {
        private int id;
        public EditMember(int id)
        {
            InitializeComponent();

            this.Load += EditUsers_Load;
            this.id = id;
        }



        private void EditUsers_Load(object sender, EventArgs e)
        {
            BindData(id);
        }

        private void BindData(int id)
        {
            MemberVM model = new MemberService().Get(id);

            // 再將 viewModel值繫結到各控制項
            NameTextBox.Text = model.Name;
            IdentityTextBox.Text = model.IdentityNumber;
            PhoneTextBox.Text = model.PhoneNumber;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            string name = NameTextBox.Text;
            string identity = IdentityTextBox.Text;
            string phone = PhoneTextBox.Text;

            // 將它們繫結到ViewModel
            MemberVM model = new MemberVM
            {
                mId = this.id,
                Name = name,
                IdentityNumber = identity,
                PhoneNumber = phone,
            };

            // 針對ViewModel進行欄位驗證
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Name", NameTextBox},
                {"IdentityNumber", IdentityTextBox},
                {"PhoneNumber", PhoneTextBox},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;

            // update record
            try
            {
                new MemberService().Update(model);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox
                .Show("您真的要刪除嗎?",
                        "刪除記錄",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            new MemberService().Delete(this.id);

            this.DialogResult = DialogResult.OK;
        }

    }
}


