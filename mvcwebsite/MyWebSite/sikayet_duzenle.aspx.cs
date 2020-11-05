using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class sikayet_duzenle : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"].ToString(); //?id=101010 falan diyoruz ya hani id ordan geliyor ?ahmet yazarsan buraya ahmet yazman gerek
                SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM communication WHERE ContactID = @id", con);
                dap.SelectCommand.Parameters.Add(new SqlParameter("@id", id));
                DataTable table = new DataTable();
                dap.Fill(table);
                if (table.Rows.Count > 0)
                {
                    txtFullName.Text = table.Rows[0]["firstName"].ToString();
                    txtSubject.Text = table.Rows[0]["subject"].ToString();
                    txtEmail.Text = table.Rows[0]["email"].ToString();
                    txtMessage.Text = table.Rows[0]["message"].ToString();
                }
                else
                    Response.Redirect("/dileksikayet.aspx");
            }
            else
                Response.Redirect("/dileksikayet.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                string id = Request.QueryString["id"].ToString();

                string update = string.Format("UPDATE communication SET firstName ='{0}',subject='{3}',email='{1}',message = '{2}' WHERE ContactID = '{4}'", txtFullName.Text, txtEmail.Text, txtMessage.Text, txtSubject.Text, id);
                SqlCommand cmd = new SqlCommand(update, con);
                var d = cmd.ExecuteScalar();
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    Response.Write("Güncelleme İşlemi Başarılı");

                    Response.Redirect("/dileksikayet.aspx");
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