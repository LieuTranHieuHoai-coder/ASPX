using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
using System.Data;
using System.Data.SqlClient;
namespace FoddASP.admin
{
    public partial class lst_food : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from food";

            if (Request["key"] != null)
            {
                query = "select * from food where name like '%" + Request["key"].ToString() + "%'";
            }
            if (Request["edit"] != null)
            {
                query = "select * from food where id = " + Convert.ToInt32(Request["edit"]) + " ";
                DataTable dtEdit = new DataTable();
                dtEdit = Food.xuat_thong_tin_food(query);
                Session["id"] = dtEdit.Rows[0]["id"].ToString();
                Session["name"] = dtEdit.Rows[0]["name"].ToString();
                Session["description"] = dtEdit.Rows[0]["description"].ToString();
                Session["price"] = dtEdit.Rows[0]["price"].ToString();
                Session["price_promo"] = dtEdit.Rows[0]["price_promo"].ToString();
                Session["thumb"] = dtEdit.Rows[0]["thumb"].ToString();
                Session["img"] = dtEdit.Rows[0]["img"].ToString();
                Session["unit"] = dtEdit.Rows[0]["unit"].ToString();
                Session["percent_promo"] = dtEdit.Rows[0]["percent_promo"].ToString();
                Session["rating"] = dtEdit.Rows[0]["rating"].ToString();
                Session["sold"] = dtEdit.Rows[0]["sold"].ToString();
                Session["point"] = dtEdit.Rows[0]["point"].ToString();
                Session["type"] = dtEdit.Rows[0]["type"].ToString();
                Session["status"] = dtEdit.Rows[0]["status"].ToString();
                Session["username"] = dtEdit.Rows[0]["username"].ToString();

                Response.Redirect("food.aspx?edit=" + dtEdit.Rows[0]["id"].ToString());
            }

            DataTable dt = new DataTable();
            dt = Food.xuat_thong_tin_food(query);
            int row = dt.Rows.Count;
            int so_item_1_trang = 3;
            int so_trang = (row / so_item_1_trang) + (row % so_item_1_trang == 0 ? 0 : 1);
            int page = Request["page"] == null ? 1 : Convert.ToInt32(Request["page"].ToString());
            int from = (page - 1) * 3;
            int to = page * 3 - 1;
            for (int i = row - 1; i >= 0; i--)
            {
                if (i < from || i > to)
                {
                    dt.Rows.RemoveAt(i);
                }
            }
            if (IsPostBack == false)
            {
                rpt_member.DataSource = dt;
                rpt_member.DataBind();
            }


            DataTable dtPage = new DataTable();
            dtPage.Columns.Add("index");
            dtPage.Columns.Add("active");
            for (int i = 1; i <= so_trang; i++)
            {
                DataRow dr = dtPage.NewRow();
                dr["index"] = i;

                dtPage.Rows.Add(dr);
            }
            Repeater2.DataSource = dtPage;
            Repeater2.DataBind();
        }

        protected void btn_tim_Click(object sender, EventArgs e)
        {
            Response.Redirect("member.aspx?key=" + txt_tim.Text);
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            Response.Redirect("food.aspx");
        }
    }
}