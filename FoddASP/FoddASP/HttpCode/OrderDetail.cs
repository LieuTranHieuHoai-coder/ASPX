using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class OrderDetail
    {
        private int _oder_id;

        public int Oder_id
        {
            get { return _oder_id; }
            set { _oder_id = value; }
        }
        private int _food_id;

        public int Food_id
        {
            get { return _food_id; }
            set { _food_id = value; }
        }
        private int _quan;

        public int Quan
        {
            get { return _quan; }
            set { _quan = value; }
        }
        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _total;

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}