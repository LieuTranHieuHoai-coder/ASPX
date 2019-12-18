using FoddASP.HttpCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoddASP.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["loginname"] = txt_username.Text;
            Session["pass"] = txt_password.Text;
            string ten = Session["loginname"].ToString();
            string pass = Session["pass"].ToString();
            string passmd5 = StringProc.MD5Hash(pass);
            if (Member.ktDangNhap(ten, passmd5))
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("Đăng Nhập Thất Bại");
            }
        }
     
    }
}