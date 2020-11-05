using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class MaınCourseDüzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack) return;
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"].ToString(); //?id=101010 falan diyoruz ya hani id ordan geliyor ?ahmet yazarsan buraya ahmet yazman gerek
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM MainCourse WHERE MainCourseID = @id", con);
                dap.SelectCommand.Parameters.Add(new SqlParameter("@id", id));
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0)
                {
                    txtyemekname.Text = table.Rows[0]["MainCourseName"].ToString();
                    txtfiyat.Text = table.Rows[0]["MainCoursePrice"].ToString();

                }
                else
                    Response.Redirect("/MaınCourse.aspx");
            }
            else
                Response.Redirect("/MaınCourse.aspx");
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string id = Request.QueryString["id"].ToString();

                string update = string.Format("UPDATE MainCourse SET MainCourseName ='{0}',MainCoursePrice='{1}' WHERE MainCourseID = '{2}'", txtyemekname.Text, txtfiyat.Text, id);
                SqlCommand cmd = new SqlCommand(update, con);
                var d = cmd.ExecuteScalar();
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    Response.Write("Güncelleme İşlemi Başarılı");

                    Response.Redirect("/MaınCourse.aspx");
                }
                else
                {
                    Response.Write("Güncelleme İşlemi Başarısız");
                }
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}