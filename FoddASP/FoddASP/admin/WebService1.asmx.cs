using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;
using FoddASP.HttpCode;
namespace FoddASP.admin
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public void GetData()
        {
            string query = "select username,pass,name,phone,role from member where status=1";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=Rau;Integrated Security=True");
            conn.Open();
            List<Member> memberlist = new List<Member>();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Member member = new Member();
                member.UserName = rd["username"].ToString();
                member.Pass = rd["pass"].ToString();
                member.Name = rd["name"].ToString();
                member.Phone = rd["phone"].ToString();
                member.Role = Convert.ToInt32(rd["role"]);
              
                memberlist.Add(member);
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(memberlist));
            rd.Close();
            conn.Close();
        }
        [WebMethod]
        public void SearchData(string data)
        {
            string query = "select username,pass,name,phone,role from member where username like'%"+data+"%'";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-B1PJQ57\HIEUHOAI;Initial Catalog=Rau;Integrated Security=True");
            conn.Open();
            List<Member> memberlist = new List<Member>();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Member member = new Member();
                member.UserName = rd["username"].ToString();
                member.Pass = rd["pass"].ToString();
                member.Name = rd["name"].ToString();
                member.Phone = rd["phone"].ToString();
                member.Role = Convert.ToInt32(rd["role"]);

                memberlist.Add(member);
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(memberlist));
            rd.Close();
            conn.Close();
        }
    }
}
