﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite
{
    public partial class Drinks : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Drinks ORDER BY DrinkID DESC", con);
            DataTable table = new DataTable();
            dap.Fill(table);
            rptDrinks.DataSource = table;
            rptDrinks.DataBind();
        }
        [WebMethod]
        public static string DrinkSil(int id)
        {
            if (con.State == ConnectionState.Closed) // bağlantı kapalıysa açıyor.
                con.Open();
            SqlCommand cmd = new SqlCommand("DELETE  FROM Drinks WHERE DrinkID=@id", con);
            cmd.Parameters.Add(new SqlParameter("@id", id));
            int effectedRow = cmd.ExecuteNonQuery(); // geriye etkilenen satır sayısı dönüyor ExecuteNonQuery onu değişkene atadık.
            if (con.State == ConnectionState.Open) // bağlantı açıksa kapatıyor.
                con.Close();

            if (effectedRow > 0)
            {
                return "Başarılı";
            }
            else
                return "Hata";
        }
       
    }

   
}
