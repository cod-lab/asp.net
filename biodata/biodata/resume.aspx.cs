﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace biodata
{
    public partial class resume : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\user_info.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Open();
            con.Open();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            /* SqlDataAdapter da = new SqlDataAdapter("select * from details where name = '" + nmtxt.Text + "' AND email = '" + etxt.Text + "'", con);
            System.Data.DataSet y = new System.Data.DataSet();
            da.Fill(y); */

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from details where name = '" + nmtxt.Text + "' AND email = '" + etxt.Text + "'";
            var y = cmd.ExecuteReader();

            if (y.HasRows)
            {
                y.Read();

                nmlbl.Text = y.GetString(1);
                nolbl.Text = Convert.ToString(y.GetValue(2));               /* GetValue: gives(returns) native format of selected data from db table */
                elbl.Text = y.GetString(3);

                colbl.Text = y.GetString(15);

                pglbl.Text = y.GetString(4);
                pgclglbl.Text = y.GetString(5);
                pgyrlbl.Text = Convert.ToString(y.GetSqlValue(6));          /* GetSqlValue: gives(returns) sql server type(format) of selected data from db table */
                pgperlbl.Text = Convert.ToString(y.GetSqlValue(7));

                glbl.Text = y.GetString(8);
                gclglbl.Text = y.GetString(9);
                gyrlbl.Text = Convert.ToString(y.GetSqlValue(10));
                gperlbl.Text = Convert.ToString(y.GetSqlValue(11));

                clslbl.Text = "12th";
                slbl.Text = y.GetString(12);
                syrlbl.Text = Convert.ToString(y.GetSqlValue(13));
                sperlbl.Text = Convert.ToString(y.GetSqlValue(14));

                sslbl.Text = y.GetString(16);
                pdlbl.Text = y.GetString(18);
                pslbl.Text = y.GetString(17);
                /* pslbl.Text = y.GetString(18).Replace(" ","\n"); */

                /* string[] pslbltxt = y.GetString(18).Split(','); */
                /* pslbl.Text = Convert.ToString(pslbltxt);*/
                /* pslbl.Text = Convert.(pslbltxt); */

                /* Response.Write("<script>alert(Console.Write(Convert.ToString(pslbltxt));)</script>"); */
                /* ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert(Console.Write(Convert.ToString(pslbltxt)))", true); */
            }
            else
            {
                //Response.Write("<script>alert('NO RECORD FOUND')</script>");
                //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('NO RECORD FOUND\\n  PLEASE TRY AGAIN')", true);
                string z = "window.onload = function(){ alert('NO RECORD FOUND\\n  PLEASE TRY AGAIN'); }";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", z, true);
            }

            /* DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();             */
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user");
        }
    }
}