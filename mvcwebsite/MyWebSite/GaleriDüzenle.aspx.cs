using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class GaleriDüzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"].ToString(); //?id=101010 falan diyoruz ya hani id ordan geliyor ?ahmet yazarsan buraya ahmet yazman gerek
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Galeri WHERE PhotoID = @id", con);
                dap.SelectCommand.Parameters.Add(new SqlParameter("@id", id));
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0)
                {
                    imgGaleri.ImageUrl = table.Rows[0]["Photo"].ToString();
                    txtTitle.Text = table.Rows[0]["Title"].ToString();
                    txtPrice.Text = table.Rows[0]["Price"].ToString();
                    
                }
                else
                    Response.Redirect("/GaleriDüzenle.aspx");
            }
            else
                Response.Redirect("/Galeri.aspx");
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
                    if (File.Exists(Server.MapPath("/uploads/" + filename)))
                        File.Delete(Server.MapPath("/uploads/" + filename));
                    FileUpload1.SaveAs(Server.MapPath("/uploads/" + filename));
                    SqlCommand cmd = new SqlCommand("UPDATE Galeri SET Title=@title,Photo=@photo,Price=@price WHERE PhotoID = @id", con);
                    cmd.Parameters.Add(new SqlParameter("@title", txtTitle.Text));
                    cmd.Parameters.Add(new SqlParameter("@price", txtPrice.Text));
                    cmd.Parameters.Add(new SqlParameter("@id", Request.QueryString["id"].ToString()));
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