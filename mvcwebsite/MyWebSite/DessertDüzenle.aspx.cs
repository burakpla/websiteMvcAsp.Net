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
    public partial class DessertDüzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"].ToString(); //?id=101010 falan diyoruz ya hani id ordan geliyor ?ahmet yazarsan buraya ahmet yazman gerek
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Desserts WHERE DessertID = @id", con);
                dap.SelectCommand.Parameters.Add(new SqlParameter("@id", id));
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0)
                {
                    txttatlıname.Text = table.Rows[0]["DessertName"].ToString();
                    txtfiyat.Text = table.Rows[0]["DessertsPrice"].ToString();

                }
                else
                    Response.Redirect("/Dessert.aspx");
            }
            else
                Response.Redirect("/Dessert.aspx");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string id = Request.QueryString["id"].ToString();

                string update = string.Format("UPDATE Desserts SET DessertName ='{0}',DessertsPrice='{1}' WHERE DessertID = '{2}'", txttatlıname.Text, txtfiyat.Text, id);
                SqlCommand cmd = new SqlCommand(update, con);
                var d = cmd.ExecuteScalar();
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    Response.Write("Güncelleme İşlemi Başarılı");

                    Response.Redirect("/Dessert.aspx");
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