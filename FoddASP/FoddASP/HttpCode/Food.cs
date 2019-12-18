using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
namespace FoddASP.HttpCode
{
    public class Food
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private Decimal _price;

        public Decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private Decimal _price_promo;

        public Decimal Price_promo
        {
            get { return _price_promo; }
            set { _price_promo = value; }
        }
        private string _thumb;

        public string Thumb
        {
            get { return _thumb; }
            set { _thumb = value; }
        }
        private string _img;

        public string Img
        {
            get { return _img; }
            set { _img = value; }
        }
        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private Decimal _percent_promo;

        public Decimal Percent_promo
        {
            get { return _percent_promo; }
            set { _percent_promo = value; }
        }
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        private int _sold;

        public int Sold
        {
            get { return _sold; }
            set { _sold = value; }
        }
        private Decimal _point;

        public Decimal Point
        {
            get { return _point; }
            set { _point = value; }
        }
        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private DateTime _modified;

        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }

        public Food()
        {
            this._id = 0;
            this._name = null;
            this._description = null;
            this._price = 0;
            this._price_promo = 0;
            this._thumb = null;
            this._img = null;
            this._unit = null;
            this._percent_promo = 0;
            this._rating = 1;
            this._sold = 0;
            this._point = 0;
            this._status = 0;
            this._type = 0;
            this._username = null;
            this._modified = DateTime.Parse("1/1/2019");
        }

        public Food(string name, string description, Decimal price, Decimal price_promo, string thumb, string img, string unit, Decimal percent_promo, int rating, int sold, Decimal point, int type, int status, string username, DateTime modified)
        {
            this._name = name;
            this._description = description;
            this._price = price;
            this._price_promo = price_promo;
            this._thumb = thumb;
            this._img = img;
            this._unit = unit;
            this._percent_promo = percent_promo;
            this._rating = rating;
            this._sold = sold;
            this._point = point;
            this._status = status;
            this._type = type;
            this._username = username;
            this._modified = modified;
        }

        public static DataTable xuat_thong_tin_food(string query)
        {
            return DataProvider.getDataTable(query);
        }

        public static bool update_food(int id, string name, string description, Decimal price, Decimal price_promo, string thumb, string img, string unit, Decimal percent_promo, int rating, int sold, Decimal point, int type, int status, string username, DateTime modified)
        {
            string query = "update food set name = @name ,description=@description ,price=@price ,price_promo=@price_promo ,thumb=@thumb,img=@img,unit=@unit,percent_promo=@percent_promo,rating=@rating,sold=@sold,point=@point,type=@type,status=@status,username=@username,modified=@modified where id = @id";
            SqlParameter[] param = 
            {
                
                new SqlParameter("@id", SqlDbType.Int){Value = id}, 
                new SqlParameter("@name", SqlDbType.NVarChar, 50){Value =  name}, 
                new SqlParameter("@description", SqlDbType.Text){Value =  description}, 
                new SqlParameter("@price", SqlDbType.Decimal){Value =  price}, 
                new SqlParameter("@price_promo", SqlDbType.Decimal){Value = price_promo}, 
                new SqlParameter("@thumb", SqlDbType.VarChar,255){Value =  thumb},
                new SqlParameter("@img", SqlDbType.VarChar,255){Value = img},
                new SqlParameter("@unit", SqlDbType.NVarChar, 10){Value = unit}, 
                new SqlParameter("@percent_promo", SqlDbType.Decimal){Value =  percent_promo}, 
                new SqlParameter("@rating", SqlDbType.Int){Value =  rating}, 
                new SqlParameter("@sold", SqlDbType.Int){Value = sold}, 
                new SqlParameter("@point", SqlDbType.Decimal){Value =  point},
                new SqlParameter("@type", SqlDbType.Int){Value = type},
                new SqlParameter("@status", SqlDbType.Int){Value =  status}, 
                new SqlParameter("@username", SqlDbType.VarChar,50){Value = username}, 
                new SqlParameter("@modified", SqlDbType.DateTime){Value = modified}, 
            };
            return DataProvider.executeNonQuery(query, param);
        }
        public bool addFood()
        {
            string sQuery = "INSERT INTO [dbo].[food] ([name] ,[description] ,[price] ,[price_promo] ,[thumb],[img],[unit],[percent_promo],[rating],[sold],[point],[type],[status],[username],[modified]) VALUES (@name ,@description ,@price ,@price_promo ,@thumb,@img,@unit,@percent_promo,@rating,@sold,@point,@type,@status,@username,@modified)";

            SqlParameter[] sqlParams =
            { 
                new SqlParameter("@name", SqlDbType.NVarChar, 50){Value = this.Name }, 
                new SqlParameter("@description", SqlDbType.Text){Value = this.Description }, 
                new SqlParameter("@price", SqlDbType.Decimal){Value = this.Price }, 
                new SqlParameter("@price_promo", SqlDbType.Decimal){Value = this.Price_promo}, 
                new SqlParameter("@thumb", SqlDbType.VarChar,255){Value = this.Thumb },
                new SqlParameter("@img", SqlDbType.VarChar,255){Value = this.Img },
                new SqlParameter("@unit", SqlDbType.NVarChar, 10){Value = this.Unit}, 
                new SqlParameter("@percent_promo", SqlDbType.Decimal){Value = this.Percent_promo }, 
                new SqlParameter("@rating", SqlDbType.Int){Value = this.Rating }, 
                new SqlParameter("@sold", SqlDbType.Int){Value = this.Sold}, 
                new SqlParameter("@point", SqlDbType.Decimal){Value = this.Point },
                new SqlParameter("@type", SqlDbType.Int){Value = this.Type },
                new SqlParameter("@status", SqlDbType.Int){Value = this.Status }, 
                new SqlParameter("@username", SqlDbType.VarChar,50){Value = this.Username }, 
                new SqlParameter("@modified", SqlDbType.DateTime){Value = this.Modified }, 
                
            };
            return DataProvider.executeNonQuery(sQuery, sqlParams);

        }
    }
}