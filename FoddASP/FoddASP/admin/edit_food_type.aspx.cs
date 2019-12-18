using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using FoddASP.HttpCode;
namespace FoddASP.admin
{
    public partial class edit_food_type : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false && Request["edit"]!=null)
            {
                txtName.Text = Session["type_name"].ToString();
                txtUserName.Text = Session["username"].ToString();
                ddl_type_post.SelectedValue = Session["type_pos"].ToString();
                ddl_type_status.SelectedValue = Session["status"].ToString();
               
            }
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string unit = Path.GetExtension(FileUpload1.FileName);
            string type_img = "";
            if (unit == ".jpg" || unit == ".png" || unit == ".jfif")
            {
                string path = Server.MapPath("img\\");
                type_img = FileUpload1.FileName;
                FileUpload1.SaveAs(path + type_img);
            }
            else
            {
                txtKQ.InnerText = "Hình ảnh chưa được chọn!";
                return;
            }
            int id = Convert.ToInt32(Session["type_id"]);
            string type_name = txtName.Text;
            DateTime modified = DateTime.Now;
            string username = txtUserName.Text;
            int status = Convert.ToInt32(ddl_type_status.SelectedValue);
            int type_post = Convert.ToInt32(ddl_type_post.SelectedValue);

            if (status == -1 || type_post == -1)
            {
                txtKQ.InnerText = "Status hoặc Type Post chưa được chọn!";
                return;
            }

            if (txtName.Text.Equals("") || txtUserName.Text.Equals(""))
            {
                txtKQ.InnerText = "Type Name hoặc User Name của bạn đang bị bỏ trống!";
                return;
            }


            if (FoodType.update_food_type(id,type_name, type_post, type_img, status, username, modified))
            {
                txtKQ.InnerText = "Chỉnh Sửa Thành Công!";
            }
            else
            {
                txtKQ.InnerText = "Chỉnh Sửa Thất Bại!";
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            Response.Redirect("food_type.aspx");
        }
    }
}