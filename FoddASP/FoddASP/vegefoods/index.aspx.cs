using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
using System.Data;
using System.Data.SqlClient;
namespace FoddASP.vegefoods
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from food";
            DataTable dt = new DataTable();
            dt = Food.xuat_thong_tin_food(query);
            if (IsPostBack == false)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "add_to_cart")
            {
                HiddenField hr_id = (HiddenField)e.Item.FindControl("hr_id");
                HiddenField hr_img = (HiddenField)e.Item.FindControl("hr_img");
                HiddenField hr_name = (HiddenField)e.Item.FindControl("hr_name");
                HiddenField hr_price = (HiddenField)e.Item.FindControl("hr_price");
                HiddenField hr_quan = (HiddenField)e.Item.FindControl("hr_quan");
                HiddenField hr_total = (HiddenField)e.Item.FindControl("hr_total");
                DataTable dt = new DataTable();
                if (Session["cart"]==null)
                {
                    dt.Columns.Add("id");
                    dt.Columns.Add("name");
                    dt.Columns.Add("img");
                    dt.Columns.Add("price");
                    dt.Columns.Add("quan");
                    dt.Columns.Add("total");
                }
                else
                {
                    dt = (DataTable)Session["cart"];
                }

                DataRow dr = dt.NewRow();
                dr["id"] = hr_id.Value;
                dr["img"] = hr_img.Value;
                dr["name"] = hr_name.Value;
                dr["price"] = hr_price.Value;
                dr["quan"] = 1;
                dr["total"] = hr_total.Value;
                dt.Rows.Add(dr);
                Session["cart"] = dt;
            }
        }
    }
}