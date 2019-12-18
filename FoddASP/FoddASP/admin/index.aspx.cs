using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoddASP.admin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginname"] != null)
            {
                string ten = Session["loginname"].ToString();
                Response.Write("<script>alert('Xin chao " + ten + " !!!')</script>");
                
            }
        }
    }
}