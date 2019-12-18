using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoddASP.HttpCode
{
    public class RelativeFood
    {
        private int _food1_id;

        public int Food1_id
        {
            get { return _food1_id; }
            set { _food1_id = value; }
        }
        private int _food2_id;

        public int Food2_id
        {
            get { return _food2_id; }
            set { _food2_id = value; }
        }
        private string _des;

        public string Des
        {
            get { return _des; }
            set { _des = value; }
        }
    }
}