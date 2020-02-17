using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace SQLInjection
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLInjectionDatabaseConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Response.Write("select * from sqltest where ID=" + TextBox1.Text);
                SqlCommand cmd = new SqlCommand("select * from sqltest where ID= @StudentID",connection);
                cmd.Parameters.AddWithValue("@StudentID", TextBox1.Text);
                connection.Open();
                GridView2.DataSource = cmd.ExecuteReader();
                GridView2.DataBind();                
            }
        }
    }
}