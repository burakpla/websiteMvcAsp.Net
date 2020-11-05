using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class galeri_ekle : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUpload1.FileName);
                    string t = Server.MapPath("/uploads/" + filename);
                    FileUpload1.SaveAs(Server.MapPath("/uploads/" + filename));
                    SqlCommand cmd = new SqlCommand("INSERT INTO Galeri(Title,Photo,Price) VALUES(@title,@photo,@price)", con);
                    cmd.Parameters.Add(new SqlParameter("@title", txtTitle.Text));
                    cmd.Parameters.Add(new SqlParameter("@price", txtPrice.Text));
                    cmd.Parameters.Add(new SqlParameter("@photo", "/uploads/" + filename));
                    int effectedRows = cmd.ExecuteNonQuery();
                    if (effectedRows > 0)
                        Response.Redirect("/Galeri.aspx");
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