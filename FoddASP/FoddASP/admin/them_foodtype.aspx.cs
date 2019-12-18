using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
using System.IO;
namespace FoddASP.admin
{
    public partial class them_foodtype : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            string unit = Path.GetExtension(FileUpload1.FileName);
            string type_img = FileUpload1.FileName;
            if (unit == ".jpg" || unit == ".png" || unit ==".jfif")
            {
                string path = Server.MapPath("img\\");
                
                FileUpload1.SaveAs(path + type_img);
                
            }

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



            FoodType food = new FoodType(type_img, type_name, status, modified, type_post, username);
            if (food.addFoodType())
            {
                Response.Write("<script>alert('Thêm thành công');</script>");
            }
            else
            {
                Response.Write("<script>alert('Thêm thất bại');</script>");
            }
        }

        protected void btn_clear_Click(object sender, EventArgs e)
        {
            Response.Redirect("food_type.aspx");
        }
    }
}