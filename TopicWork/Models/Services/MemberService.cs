using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Models.ViewModels;

namespace TopicWork.Infra.Extensions
{
    public class MemberService
    {
        public IEnumerable<MemberIndexVM> GetAll()
        {
            string sql = @"SELECT * FROM Member ORDER BY mID ";

            var dbHelper = new SqlDbHelper("default");
            // 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
            return dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                ;
            // .ToList();
        }

        public void Create(MemberVM model)
        {
            //bool isExists = AccountExists(model.PhoneNumber);
            //if (isExists) throw new Exception("電話號碼已存在");

            string sql = @"INSERT INTO Member
						(Name, IdentityNumber, PhoneNumber, ContractExpired, Contract_id, Phone_id)
						VALUES
						(@Name,@IdentityNumber, @PhoneNumber, @ContractExpired, @Contract_id, @Phone_id)";
            //@"INSERT INTO Users
            //(Account,Password, Name)
            //VALUES
            //(@Account,@Password, @Name)";
            //model.Contract_id = 1;
            //model.Phone_id = 1;

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Name", 50, model.Name)
                .AddNVarchar("IdentityNumber", 50, model.IdentityNumber)
                .AddNVarchar("PhoneNumber", 50, model.PhoneNumber)
                .AddDateTime("ContractExpired", model.ContractExpired)
                .AddInt("Contract_id", model.Contract_id)
                .AddInt("Phone_id", model.Phone_id)
                .Build();


            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        private bool AccountExists(string phone)
        {
            string sql = @"SELECT Count(*) as count FROM Member WHERE PhoneNumber=@PhoneNumber";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("PhoneNumber", 10, phone)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }

        private bool AccountExists(MemberVM model)
        {
            string sql = @"SELECT Count(*) as count FROM Member WHERE PhoneNumber=@PhoneNumber AND MId!=@MId";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("PhoneNumber", 50, model.PhoneNumber)
                .AddInt("MId", model.mId)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }

        private MemberIndexVM ParseToIndexVM(DataRow row)
        {
            return new MemberIndexVM
            {
                mId = row.Field<int>("mId"),
                Name = row.Field<string>("Name"),
                IdentityNumber = row.Field<string>("IdentityNumber"),
                PhoneNumber = row.Field<string>("PhoneNumber")
            };
        }

        public MemberVM Get(int id)
        {
            string sql = "SELECT * FROM Member WHERE mId=@mId";
            var parameters = new SqlParameterBuilder()
                .AddInt("mId", id)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                throw new Exception("找不到要編輯的記錄");
                //MessageBox.Show("抱歉, 找不到要編輯的記錄");
                //this.DialogResult = DialogResult.Abort;


                //return;
            }

            // 將找到的一筆記錄由DataTable 轉換到 ProductVM
            return ToMemberVM(data.Rows[0]);
        }

        private MemberVM ToMemberVM(DataRow row)
        {
            return new MemberVM
            {
                mId = row.Field<int>("mId"),
                Name = row.Field<string>("Name"),
                IdentityNumber = row.Field<string>("IdentityNumber"),
                PhoneNumber = row.Field<string>("PhoneNumber"),
            };
        }

        internal void Update(MemberVM model)
        {
            bool isExists = AccountExists(model);
            if (isExists) throw new Exception("帳號已存在");

            string sql = @"UPDATE Member
			SET Name=@Name, IdentityNumber=@IdentityNumber, PhoneNumber=@PhoneNumber
			WHERE mId=@MId";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Name", 50, model.Name)
                .AddNVarchar("IdentityNumber", 50, model.IdentityNumber)
                .AddNVarchar("PhoneNumber", 50, model.PhoneNumber)
                .AddInt("mId", model.mId)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        internal void Delete(int id)
        {
            string sql = @"DELETE FROM Member WHERE mId=@mId";

            var parameters = new SqlParameterBuilder()
                .AddInt("mId", id)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }

        //public bool Authenticate(LoginVM model)
        //{
        //	var user = Get(model.Account);
        //	if (user == null) return false; // 找不到符合的帳號

        //	return (user.Password == model.Password);
        //}
    }
}
