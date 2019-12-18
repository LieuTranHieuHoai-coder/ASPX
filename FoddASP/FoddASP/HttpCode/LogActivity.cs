using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class LogActivity
    {
        private int _lod_id;

        public int Lod_id
        {
            get { return _lod_id; }
            set { _lod_id = value; }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private DateTime _time_log;

        public DateTime Time_log
        {
            get { return _time_log; }
            set { _time_log = value; }
        }
        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}