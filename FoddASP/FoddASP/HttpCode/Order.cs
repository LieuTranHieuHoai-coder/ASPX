using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class Order
    {
        private int _oder_id;

        public int Oder_id
        {
            get { return _oder_id; }
            set { _oder_id = value; }
        }
        private string _cus_name;

        public string Cus_name
        {
            get { return _cus_name; }
            set { _cus_name = value; }
        }
        private string _cus_phone;

        public string Cus_phone
        {
            get { return _cus_phone; }
            set { _cus_phone = value; }
        }
        private string _cus_add;

        public string Cus_add
        {
            get { return _cus_add; }
            set { _cus_add = value; }
        }
        private int _quan;

        public int Quan
        {
            get { return _quan; }
            set { _quan = value; }
        }
        private int _sum;

        public int Sum
        {
            get { return _sum; }
            set { _sum = value; }
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
        private DateTime _create;

        public DateTime Create
        {
            get { return _create; }
            set { _create = value; }
        }
        private string _cus_username;

        public string Cus_username
        {
            get { return _cus_username; }
            set { _cus_username = value; }
        }
    }
}