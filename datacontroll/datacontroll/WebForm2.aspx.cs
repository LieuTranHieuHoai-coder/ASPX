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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=DataControll;Integrated Security=True");
            conn.Open();
            string ten = TextBox1.Text;
            string query = "SELECT sv.mssv, sv.hoten, l.tenlop, l.hinh FROM [SinhVien] sv, Lop l WHERE sv.malop = l.malop and sv.xoa=0 and sv.hoten like'%"+@ten+"%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=DataControll;Integrated Security=True");
            conn.Open();
            string ten = DropDownList1.SelectedItem.ToString();
            string query = "SELECT sv.mssv, sv.hoten, l.tenlop, l.hinh FROM [SinhVien] sv, Lop l WHERE sv.malop = l.malop and sv.xoa=0 and sv.malop = '" + @ten + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSourceID = null;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

       
    }
}