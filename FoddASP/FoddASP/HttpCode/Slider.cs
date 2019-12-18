using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class Slider
    {
        private int _slide_id;

        public int Slide_id
        {
            get { return _slide_id; }
            set { _slide_id = value; }
        }
        private int _id_object;

        public int Id_object
        {
            get { return _id_object; }
            set { _id_object = value; }
        }
        private string _img;

        public string Img
        {
            get { return _img; }
            set { _img = value; }
        }
        private string _caption;

        public string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }
        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private int _rank;

        public int Rank
        {
            get { return _rank; }
            set { _rank = value; }
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
    }
}