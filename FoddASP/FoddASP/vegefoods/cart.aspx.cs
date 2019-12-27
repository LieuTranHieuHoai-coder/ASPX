using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using FoddASP.HttpCode;
namespace FoddASP.vegefoods
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"]!=null)
            {
                DataTable dt = new DataTable();
                dt = (DataTable)Session["cart"];
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        { 
           
        }
    }
}