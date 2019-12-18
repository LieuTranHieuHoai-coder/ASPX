using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace FoddASP.HttpCode
{
    public class FoodType
    {
		private int _type_id;
		private string _type_name;
		private int _type_post;
		private string _type_img;
		private int _status;
		private string _username;
		private DateTime _modified;

		public DateTime Modified
		{
			get { return _modified; }
			set { _modified = value; }
		}


		public string UserName
		{
			get { return _username; }
			set { _username = value; }
		}


		public int Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public string TypeImg
		{
			get { return _type_img; }
			set { _type_img = value; }
		}

		public int TypeID
		{
			get { return _type_id; }
			set { _type_id = value; }
		}

		

		public string TypeName
		{
			get { return _type_name; }
			set { _type_name = value; }
		}

		

		public int TypePost
		{
			get { return _type_post; }
			set { _type_post = value; }
		}
        public FoodType()
        {
            this._type_id = 0;
            this._type_img=null;
            this._type_name = "";
            this._status = 1;
            this._modified=DateTime.Parse("1/1/2019");
            this._type_post = 0;
            this._username = null;

        }
        public FoodType(string type_img,string type_name, int status,DateTime modified,int type_post,string username)
		{
            this._type_img=type_img;
            this._type_name =type_name;
            this._status = status;
            this._modified=modified;
            this._type_post = type_post;
            this._username = username;
		}
        public static DataTable xuat_thong_tin_food_type(string query)
        {
            return DataProvider.getDataTable(query);
        }

        public static bool update_food_type(int id, string type_name, int type_pos, string type_img, int status, string username, DateTime modified)
        {
            string query = "update food_type set type_name = @type_name, type_pos = @type_pos, type_img = @type_img, status = @status ,username = @username, modified = @modified  where type_id = @type_id";
            SqlParameter[] param = 
            {
                new SqlParameter("@type_id", SqlDbType.Int){Value = id }, 
                new SqlParameter("@type_name", SqlDbType.NVarChar, 50){Value = type_name }, 
				new SqlParameter("@type_pos", SqlDbType.Int){Value =  type_pos}, 
				new SqlParameter("@type_img", SqlDbType.VarChar, 255){Value =  type_img}, 
				new SqlParameter("@status", SqlDbType.Int){Value = status}, 
				new SqlParameter("@username", SqlDbType.VarChar,50){Value =  username},
                new SqlParameter("@modified", SqlDbType.DateTime){Value = modified}
            };
            return DataProvider.executeNonQuery(query, param);
        }
        public bool addFoodType()
		{
			string sQuery = "INSERT INTO [dbo].[food_type] ([type_name] ,[type_pos] ,[type_img] ,[status] ,[username],[modified]) VALUES (@type_name ,@type_poss ,@type_img ,@status ,@username,@modified)";

			SqlParameter[] sqlParams =
			{ 
				new SqlParameter("@type_name", SqlDbType.NVarChar, 50){Value = this.TypeName }, 
				new SqlParameter("@type_poss", SqlDbType.Int){Value = this.TypePost }, 
				new SqlParameter("@type_img", SqlDbType.VarChar, 255){Value = this.TypeImg }, 
				new SqlParameter("@status", SqlDbType.Int){Value = this.Status}, 
				new SqlParameter("@username", SqlDbType.VarChar,50){Value = this.UserName },
                new SqlParameter("@modified", SqlDbType.DateTime){Value = this.Modified }
			};
			return DataProvider.executeNonQuery(sQuery, sqlParams);
			
		}
	}
}