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
    public partial class food_type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from food_type ";

            if (Request["key"] != null)
            {
                query = "select * from food_type where type_name like 'N%" + Request["key"].ToString() + "%'";
            }

            if (Request["an"] != null)
            {
                query = "select * from food_type where status = 0";
            }
            if (Request["hien"] != null)
            {
                query = "select * from food_type";
            }
            if (Request["edit"] != null)
            {
                query = "select * from food_type where type_id = " + Convert.ToInt32(Request["edit"]) + " ";
                DataTable dtEdit = new DataTable();
                dtEdit = FoodType.xuat_thong_tin_food_type(query);
                Session["type_id"] = dtEdit.Rows[0]["type_id"].ToString();
                Session["username"] = dtEdit.Rows[0]["username"].ToString();
                Session["type_pos"] = dtEdit.Rows[0]["type_pos"].ToString();
                Session["type_name"] = dtEdit.Rows[0]["type_name"].ToString();
                Session["type_img"] = dtEdit.Rows[0]["type_img"].ToString();
                Session["status"] = dtEdit.Rows[0]["status"].ToString();

                Response.Redirect("edit_food_type.aspx?edit=" + dtEdit.Rows[0]["type_name"].ToString());
            }

            DataTable dt = new DataTable();
            dt = FoodType.xuat_thong_tin_food_type(query);
            int row =dt.Rows.Count;
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

        protected void btn_them_loai_Click(object sender, EventArgs e)
        {
            Response.Redirect("them_foodtype.aspx");
        }

        protected void btn_tim_Click(object sender, EventArgs e)
        {
            Response.Redirect("food_type.aspx?key="+txt_tim.Text);
        }

        protected void btn_an_Click(object sender, EventArgs e)
        {
            Response.Redirect("food_type.aspx?an=1");
        }

        protected void btn_all_Click(object sender, EventArgs e)
        {
            Response.Redirect("food_type.aspx?hien=0");
        }

    }
}