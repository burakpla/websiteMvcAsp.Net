using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        
        [WebMethod] // Ajax'ın bu metodu bulması için gerkli olan attr.
        public static string Kaydet(InfoMessage message)
        {
            try
            {
                string ConnectionString = @"Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True";
                SqlConnection baglanti = new SqlConnection(ConnectionString);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into communication(firstname,email,subject,message) values (@p2,@p3,@p4,@p5)", baglanti);

                komut.Parameters.AddWithValue("@p2", message.firstName);
                komut.Parameters.AddWithValue("@p3", message.email);
                komut.Parameters.AddWithValue("@p4", message.subject);
                komut.Parameters.AddWithValue("@p5", message.message);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return "Başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message; // C# tarafında hata oluşursa geriye hata mesajını dönderir.
            }

        }
    }
}