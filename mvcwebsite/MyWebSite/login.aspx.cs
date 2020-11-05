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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {

            string ConnectionString = @"Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(ConnectionString);

            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users WHERE adminName=@adminname AND adminPassword= @password", baglanti);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@password", txtsifre.Text));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@adminname", txtkullaniciadi.Text));
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                Session["adminName"] = table.Rows[0]["adminName"].ToString();
                Response.Redirect("master2.aspx");
            }
            else
            {
                Response.Write("False adminname or adminpassord");
            }
            baglanti.Close();



        }
    }
}