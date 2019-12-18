using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using FoddASP.HttpCode;
using System.Data;
using System.Data.SqlClient;
namespace FoddASP.admin
{
    public partial class member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string query = "select * from member";
            if (Request["key"] != null)
            {
                query = "select * from member where username like '%" + Request["key"].ToString() + "%'";
            }

            //edit
            if (Request["edit"] != null)
            {
                query = "select * from member where username like '%" + Request["edit"].ToString() + "%'";
                DataTable dtEdit = new DataTable();
                dtEdit = Member.xuat_thong_tin_member(query);
                Session["username"] = dtEdit.Rows[0]["username"].ToString();
                Session["pass"] = dtEdit.Rows[0]["pass"].ToString();
                Session["name"] = dtEdit.Rows[0]["name"].ToString();
                Session["phone"] = dtEdit.Rows[0]["phone"].ToString();
                Session["role"] = dtEdit.Rows[0]["role"].ToString();
                Response.Redirect("edit.aspx?edit=" + dtEdit.Rows[0]["username"].ToString());
            }

            DataTable dt = new DataTable();
            dt = Member.xuat_thong_tin_member(query);
            int row = Member.xuat_thong_tin_member(query).Rows.Count;
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("member.aspx?key=" + txt_tim.Text);
        }
    }
}