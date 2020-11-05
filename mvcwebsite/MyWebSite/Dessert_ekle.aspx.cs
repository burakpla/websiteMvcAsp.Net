using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MyWebSite
{
    public partial class Dessert_ekle : System.Web.UI.Page
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Desserts(DessertName,DessertsPrice) VALUES(@dessertname,@dessertprice)", con);
                    cmd.Parameters.Add(new SqlParameter("@dessertname", txtiadı.Text));
                    cmd.Parameters.Add(new SqlParameter("@dessertprice", txtprice2.Text));
                    int effectedRows = cmd.ExecuteNonQuery();
                    if (effectedRows > 0)
                        Response.Redirect("/Dessert.aspx");
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
    
