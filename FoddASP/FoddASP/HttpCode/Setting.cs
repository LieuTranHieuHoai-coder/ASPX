using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class Setting
    {
        private int _id_setting;

        public int Id_setting
        {
            get { return _id_setting; }
            set { _id_setting = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _des;

        public string Des
        {
            get { return _des; }
            set { _des = value; }
        }
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private DateTime _modified;

        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }
    }
}