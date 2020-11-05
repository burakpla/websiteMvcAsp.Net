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
    public partial class master : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGUQE12;Initial Catalog=Mywebsitedatabase;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM Galeri ORDER BY CreatedDate DESC", con);
            DataTable table = new DataTable();
            dap.Fill(table);
            rptGallery.DataSource = table;
            rptGallery.DataBind();

            dap = new SqlDataAdapter("SELECT * FROM Drinks ORDER BY DrinkID DESC", con);
            table = new DataTable();
            dap.Fill(table);
            rptDrinks.DataSource = table;
            rptDrinks.DataBind();

            dap = new SqlDataAdapter("SELECT * FROM Desserts ORDER BY DessertID DESC", con);
            table = new DataTable();
            dap.Fill(table);
            rptDesserts.DataSource = table;
            rptDesserts.DataBind();

            dap = new SqlDataAdapter("SELECT * FROM MainCourse ORDER BY MainCourseID DESC", con);
            table = new DataTable();
            dap.Fill(table);
            rptMaınCourse.DataSource = table;
            rptMaınCourse.DataBind();

        }
    }
}