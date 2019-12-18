using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class Customer
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
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
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private int _num_order;

        public int Num_order
        {
            get { return _num_order; }
            set { _num_order = value; }
        }
        private int _num_successful_order;

        public int Num_successful_order
        {
            get { return _num_successful_order; }
            set { _num_successful_order = value; }
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
        private DateTime _created;

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public Customer()
        {
            _username = "";
            _password = "";
            _name = "";
            _phone = "";
            _email = "";
            _address = "";
            _num_order = 1;
            _num_successful_order = 1;
            _sum = 0;
            _status = 0;
            _created = DateTime.Parse("1/1/2019");
        }

        public Customer(string username, string password,string name, string phone, string email, string address, int num_order, int num_successful_oder, int sum,int status, DateTime create)
        {
            _username = username;
            _password = password;
            _name = name;
            _phone = phone;
            _email = email;
            _address = address;
            _num_order = num_order;
            _num_successful_order = num_successful_oder;
            _sum = sum;
            _status = status;
            _created = create;
        }
    }
}