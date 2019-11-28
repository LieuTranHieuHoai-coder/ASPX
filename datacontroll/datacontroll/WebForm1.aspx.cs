using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace datacontroll
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "x")
            {
                SqlDataSource1.DeleteParameters["MSSV"].DefaultValue = DataList1.DataKeys[e.Item.ItemIndex].ToString();
                SqlDataSource1.Delete();
            }
            if(e.CommandName == "s")
            {
                DataList1.EditItemIndex = e.Item.ItemIndex;
                DataList1.DataBind();
            }
            if(e.CommandName =="h")
            {
                DataList1.EditItemIndex = -1;
                DataList1.DataBind();
            }
            if (e.CommandName == "c")
            {
                TextBox t = new TextBox();
                t = (TextBox)e.Item.FindControl("TextBox1");
                SqlDataSource1.UpdateParameters["hoten"].DefaultValue = t.Text;
                SqlDataSource1.UpdateParameters["MSSV"].DefaultValue = DataList1.DataKeys[e.Item.ItemIndex].ToString();
                SqlDataSource1.Update();
                DataList1.EditItemIndex = -1;
                DataList1.DataBind();
            }
            if (e.CommandName =="t")
            {
                TextBox t = new TextBox();
                t = (TextBox)e.Item.FindControl("TextBox2");
                SqlDataSource1.InsertParameters["MSSV"].DefaultValue = t.Text;
                SqlDataSource1.Insert();
                DataList1.DataBind();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=DataControll;Integrated Security=True");
            conn.Open();
            string ten = TextBox3.Text;
            string query = "SELECT * FROM [SinhVien] WHERE hoten like'%" + @ten + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataList1.DataSourceID = null;
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        //protected void Button5_Click(object sender, EventArgs e)
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=DataControll;Integrated Security=True");
        //    conn.Open();
        //    string ten = TextBox2.Text;
        //    string query = "SELECT * FROM [SinhVien] WHERE hoten like'%"+@ten+"%'";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    DataList1.DataSourceID = null;
        //    DataList1.DataSource = dt;
        //    DataList1.DataBind();
        //}

        
    }
}