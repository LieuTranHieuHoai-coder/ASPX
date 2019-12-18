using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
namespace FoddASP.admin
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUserName.Text;
            //string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string pass = txtPassword.Text;

            int role = Convert.ToInt32(ddl_user.SelectedValue);
            if (role == -1)
            {
                txtKQ.InnerText = "Bạn Chưa chọn Role";
                return;
            }
            //string status = ddl_status.SelectedValue;
            Member member = new Member(username, pass, name, phone, role);
            if (member.addMember())
            {
                txtKQ.InnerText = "Thành Công";
                Response.Redirect("login.aspx");
            }
            else
            {
                txtKQ.InnerText = "Tài Khoản đã tồn tại";
            }
        }
    }
}