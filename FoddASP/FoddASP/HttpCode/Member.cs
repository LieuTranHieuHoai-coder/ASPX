
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace FoddASP.HttpCode
{
    public class Member
    {
		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		private string _pass;

		public string Pass
		{
			get { return _pass; }
			set { _pass = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _phone;

		public string Phone
		{
			get { return _phone; }
			set { _phone = value; }
		}

		private int _role;

		public int Role
		{
			get { return _role; }
			set { _role = value; }
		}
        public Member()
        {
            _userName = "";
            _pass = "";
            _name = "";
            _phone = "";
            _role = 0;
        }

        public Member(string _userName, string _pass, string _name, string _phone,int _role)
		{
			this._userName = _userName;
			this._pass = _pass;
			this._name = _name;
			this._phone = _phone;
			this._role = _role;
		}
        public static DataTable xuat_thong_tin_member(string query)
        {
            return DataProvider.getDataTable(query);
        }

        public static bool update_member(string username, string name, string phone, string pass, int role)
        {
            string query = "update member set name = @name, phone = @phone, role = @role, pass = @pass where username like @username";
            SqlParameter[] param = 
            {
                new SqlParameter("@username", SqlDbType.VarChar, 50){Value =username},
                new SqlParameter("@pass", SqlDbType.VarChar, 255){Value = pass},
                new SqlParameter("@name",SqlDbType.VarChar, 200){Value = name },
                new SqlParameter("@phone",SqlDbType.VarChar, 20){Value = phone },
                new SqlParameter("@role",SqlDbType.Int){Value = role }
            };
            return DataProvider.executeNonQuery(query,param);
        }
		public bool addMember()
		{
			string sQuery = "INSERT INTO [dbo].[member] ([username] ,[pass] ,[name] ,[phone] ,[role]) VALUES (@username ,@pass ,@name ,@phone ,@role)";
			SqlParameter[] sqlParams =
			{ 
				new SqlParameter("@username", SqlDbType.VarChar, 50){Value = this.UserName }, 
				new SqlParameter("@pass", SqlDbType.VarChar, 255){Value = StringProc.MD5Hash(this.Pass) }, 
				new SqlParameter("@name", SqlDbType.VarChar, 200){Value = this.Name }, 
				new SqlParameter("@phone", SqlDbType.VarChar, 20){Value = this.Phone }, 
				new SqlParameter("@role", SqlDbType.Int){Value = this.Role }
			};
			return DataProvider.executeNonQuery(sQuery, sqlParams);
			
		}

      
        public static bool ktDangNhap(string user, string passmd5)
        {
            string query = "SELECT * FROM [dbo].[member] WHERE username = '"+user+"' and pass like '"+passmd5+"'";
            //SqlParameter[] sqlParams = new SqlParameter[0];
            //sqlParams[0] = new SqlParameter("@TenTaiKhoan",user);

            if(DataProvider.KTTK(query))
            {
                return true;
            }
            else
            {
                return false;
            }
           
         
        }
    }
}