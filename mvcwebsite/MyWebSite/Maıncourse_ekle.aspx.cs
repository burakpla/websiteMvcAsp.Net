using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class Maıncourse_ekle : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO MainCourse(MainCourseName,MainCoursePrice) VALUES(@maincoursename,@maincourseprice)", con);
                    cmd.Parameters.Add(new SqlParameter("@maincoursename", txtiadı.Text));
                    cmd.Parameters.Add(new SqlParameter("@maincourseprice", txtprice2.Text));
                    int effectedRows = cmd.ExecuteNonQuery();
                    if (effectedRows > 0)
                        Response.Redirect("/MaınCourse.aspx");
                    else
                        Response.Write("HATA OLUŞTU.");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}