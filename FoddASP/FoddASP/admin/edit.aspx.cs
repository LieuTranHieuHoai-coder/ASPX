using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
namespace FoddASP.admin
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]!=null && IsPostBack==false)
            {
                lb_username.Text = Session["username"].ToString();
                txtName.Text = Session["name"].ToString();
                txtPassword.Text = Session["pass"].ToString();
                txtPhone.Text = Session["phone"].ToString();
                ddl_user.SelectedValue = Session["role"].ToString();
            }


        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            string username = lb_username.Text;
            string name = txtName.Text;
            string pass = StringProc.MD5Hash(txtPassword.Text);
            string phone = txtPhone.Text;
            int role = Convert.ToInt32(ddl_user.SelectedValue);
            if (role == -1)
            {
                txtKQ.InnerText = "Role của bạn đang bọ bỏ trống";
            }

            if ( Member.update_member(username, name, phone, pass, role))
            {
                Response.Write("<script>alert('Cập nhật thành công');</script>");
            }
            else
            {
                Response.Write("<script>alert('Cập nhật thất bại');</script>");
            }

        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            Response.Redirect("member.aspx");
        }
    }
}