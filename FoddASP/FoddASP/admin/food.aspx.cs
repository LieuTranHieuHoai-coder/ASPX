using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FoddASP.HttpCode;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace FoddASP.admin
{
    public partial class food : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false && Request["edit"] != null)
            {
               txtName.Text = Session["name"].ToString() ;
               txt_mota.Text = Session["description"].ToString();
               txt_price.Text = Session["price"].ToString();
               txt_price_promo.Text = Session["price_promo"].ToString();
               txt_unit.Text = Session["unit"].ToString();
               txt_percent_promo.Text = Session["percent_promo"].ToString();
               txt_rating.Text = Session["rating"].ToString(); 
               txt_sold.Text = Session["sold"].ToString();
               txt_point.Text = Session["point"].ToString(); 
               ddl_type.SelectedValue = Session["type"].ToString();
               ddl_status.SelectedValue = Session["status"].ToString(); 
            }

            
        }

        protected void btn_lst_food_Click(object sender, EventArgs e)
        {
            Response.Redirect("lst_food.aspx");
        }

        protected void btn_add_food_Click(object sender, EventArgs e)
        {
            string unit1 = Path.GetExtension(FileUpload1.FileName);
            string thumb = FileUpload1.FileName;
            string unit2 = Path.GetExtension(FileUpload2.FileName);
            string img = FileUpload2.FileName;
            if ((unit1 == ".jpg" || unit1 == ".png" || unit1 == ".jfif") && (unit2 == ".jpg" || unit2 == ".png" || unit2 == ".jfif"))
            {
                string path = Server.MapPath("img\\");
                FileUpload1.SaveAs(path + thumb);
                FileUpload2.SaveAs(path + img);
            }
            else
            {
                txtKQ.InnerText = "Hình ảnh chưa được chọn";
                return;
            }
            string name = txtName.Text;
            string description = txt_mota.Text;
            Decimal price = Convert.ToDecimal(txt_price.Text);
            Decimal price_promo = Convert.ToDecimal(txt_price_promo.Text);
            string unit =  txt_unit.Text;
            Decimal percent_promo = Convert.ToDecimal(txt_percent_promo.Text);
            int rating =  Convert.ToInt32(txt_rating.Text);
            int sold = Convert.ToInt32(txt_sold.Text);
            Decimal point = Convert.ToDecimal(txt_point.Text);
            int type = Convert.ToInt32(ddl_type.SelectedValue); 
            int status =  Convert.ToInt32(ddl_status.SelectedValue); 
            string username =  Session["loginname"].ToString();
            DateTime modified = DateTime.Now;
            if (status == -1 || type == -1)
            {
                txtKQ.InnerText = "Status hoặc Type chưa được chọn!";
                return;
            }
            Food food = new Food(name, description, price, price_promo, thumb, img, unit, percent_promo, rating, sold, point, type, status, username, modified);
            if (food.addFood())
            {
                Response.Write("<script>alert('Thêm thành công!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Thêm thất bại!');</script>");
            }
        }

        protected void btn_add_update_Click(object sender, EventArgs e)
        {
            string unit1 = Path.GetExtension(FileUpload1.FileName);
            string thumb = FileUpload1.FileName;
            string unit2 = Path.GetExtension(FileUpload2.FileName);
            string img = FileUpload2.FileName;
            if ((unit1 == ".jpg" || unit1 == ".png" || unit1 == ".jfif") && (unit2 == ".jpg" || unit2 == ".png" || unit2 == ".jfif"))
            {
                string path = Server.MapPath("img\\");
                FileUpload1.SaveAs(path + thumb);
                FileUpload2.SaveAs(path + img);
            }
            else
            {
                txtKQ.InnerText = "Hình ảnh chưa được chọn";
                return;
            }


            int id = Convert.ToInt32(Session["id"]);
            string name = txtName.Text;
            string description = txt_mota.Text;
            Decimal price = Convert.ToDecimal(txt_price.Text);
            Decimal price_promo = Convert.ToDecimal(txt_price_promo.Text);
            string unit = txt_unit.Text;
            Decimal percent_promo = Convert.ToDecimal(txt_percent_promo.Text);
            int rating = Convert.ToInt32(txt_rating.Text);
            int sold = Convert.ToInt32(txt_sold.Text);
            Decimal point = Convert.ToDecimal(txt_point.Text);
            int type = Convert.ToInt32(ddl_type.SelectedValue);
            int status = Convert.ToInt32(ddl_status.SelectedValue);
            string username = Session["loginname"].ToString();
            DateTime modified = DateTime.Now;
            if (status == -1 || type == -1)
            {
                txtKQ.InnerText = "Status hoặc Type chưa được chọn!";
                return;
            }
            if (Food.update_food(id,name, description, price, price_promo, thumb, img, unit, percent_promo, rating, sold, point, type, status, username, modified))
            {
                Response.Write("<script>alert('Cập nhật thành công!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Cập Nhật Thất Bại!');</script>");
            }
        }
    }
}