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
    public partial class GeneralSetting : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM GeneralSetting WHERE Id = 1", con);

            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
            {
                txtTitle.Text = table.Rows[0]["SiteTitle"].ToString();
                txtGoogleMap.Text = table.Rows[0]["GoogleMap"].ToString();
                txtAdress.Text = table.Rows[0]["Address"].ToString();
                txtEmail.Text = table.Rows[0]["Email"].ToString();
                txtPhone.Text = table.Rows[0]["Phone"].ToString();
                txtfax.Text = table.Rows[0]["Fax"].ToString();
                txtfacebook.Text = table.Rows[0]["Facebook"].ToString();
                txtInstagram.Text = table.Rows[0]["Instagram"].ToString();
                txtTwitter.Text = table.Rows[0]["Twitter"].ToString();
                txtYoutube.Text = table.Rows[0]["Youtube"].ToString();


            }
            else
                Response.Redirect("/anasayfa.aspx");

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
               
                string update = string.Format("UPDATE GeneralSetting SET SiteTitle ='{0}',GoogleMap='{1}',Phone='{2}',Fax='{3}',Email='{4}',Instagram='{5}',Twitter='{6}',Facebook='{7}',Youtube='{8}',Address = '{9}' WHERE Id = 1", txtTitle.Text, txtGoogleMap.Text,  txtPhone.Text, txtfax.Text, txtEmail.Text, txtInstagram.Text, txtTwitter.Text, txtfacebook.Text, txtYoutube.Text,txtAdress.Text);
                SqlCommand cmd = new SqlCommand(update, con);
                var d = cmd.ExecuteScalar();
                int effectedRows = cmd.ExecuteNonQuery();
                if (effectedRows > 0)
                {
                    Response.Write("Güncelleme İşlemi Başarılı");

                    Response.Redirect("/GeneralSetting.aspx");
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