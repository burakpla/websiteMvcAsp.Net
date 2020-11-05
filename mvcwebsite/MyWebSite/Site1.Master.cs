using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using MyWebSite.Classes;

namespace MyWebSite
{
    
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        //SqlCommand komut = new SqlCommand();
        //SqlConnection baglanti = new SqlConnection();

        public  GeneralSettingEntity setting { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM GeneralSetting WHERE Id = 1", con);
            DataTable table = new DataTable();
            setting = new GeneralSettingEntity();
            dap.Fill(table);
            if (table.Rows.Count > 0)
            {
                setting.SiteTitle= table.Rows[0]["SiteTitle"].ToString();
                setting.GoogleMap = table.Rows[0]["GoogleMap"].ToString();
                setting.Address= table.Rows[0]["Address"].ToString();
                setting.Email= table.Rows[0]["Email"].ToString();
                setting.Phone = table.Rows[0]["Phone"].ToString();
                setting.Fax= table.Rows[0]["Fax"].ToString();
                setting.Facebook= table.Rows[0]["Facebook"].ToString();
                setting.Instagram = table.Rows[0]["Instagram"].ToString();
                setting.Twitter= table.Rows[0]["Twitter"].ToString();
                setting.Youtube = table.Rows[0]["Youtube"].ToString();
            }


        }

    }

    public class InfoMessage
    {
        public string firstName { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}