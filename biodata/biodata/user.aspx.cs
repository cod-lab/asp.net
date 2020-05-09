using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;

namespace biodata
{
    public partial class user : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\user_info.mdf;Integrated Security=True");

        static int i;                       // for btnEnter & btnUpdate

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
                con.Open();
            con.Open();

            /* for(int y = 1; y <= 13; y++)
            {
                string x = "delete from details where id =" + y;
                sqlcmd(ref x);
            }
            string x = "delete from details where id > 15";
            sqlcmd(ref x); */

            display();
        }

        public SqlCommand sqlcmd(ref string x)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = x;
            cmd.ExecuteNonQuery();

            return cmd;

            /* nmtxt.Text = "";
            notxt.Text = "";
            etxt.Text = "";
            pgddl.Text = "";
            pgclgtxt.Text = "";
            pgyrtxt.Text = "";
            pgpertxt.Text = "";
            gddl.Text = "";
            gclgtxt.Text = "";
            gyrtxt.Text = "";
            gpertxt.Text = "";
            stxt.Text = "";
            syrtxt.Text = "";
            cotxt.Text = "";
            sstxt.Text = "";
            pstxt.Text = "";
            pdtxt.Text = "";

            display(); */
        }

        public void display()
        {
            string x = "select * from details";
            SqlCommand cmd = sqlcmd(ref x);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        public void txtEnable(bool b)
        {
            notxt.Enabled = b;
            pgddl.Enabled = b;
            pgclgtxt.Enabled = b;
            pgyrtxt.Enabled = b;
            pgpertxt.Enabled = b;
            gddl.Enabled = b;
            gclgtxt.Enabled = b;
            gyrtxt.Enabled = b;
            gpertxt.Enabled = b;
            stxt.Enabled = b;
            syrtxt.Enabled = b;
            spertxt.Enabled = b;
            cotxt.Enabled = b;
            sstxt.Enabled = b;
            pstxt.Enabled = b;
            pdtxt.Enabled = b;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                headtxt.ForeColor = System.Drawing.Color.White;
                headtxt.Text = ".";
                btnEdit.Text = "ENTER";
                btnCancel.Visible = true;
                msgtxt.Visible = true;
                btnSave.Enabled = false;

                txtEnable(false);
            }
            else                                        // btnEnter
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from details where name = '" + nmtxt.Text + "' AND email = '" + etxt.Text + "'";
                var y = cmd.ExecuteReader();

                if (y.HasRows)
                {
                    y.Read();

                    i = y.GetInt32(0);

                    nmtxt.Text = y.GetString(1);
                    notxt.Text = Convert.ToString(y.GetValue(2));               // GetValue: gives(returns) native format of selected data from db table
                    etxt.Text = y.GetString(3);

                    pgddl.Text = y.GetString(4);
                    pgclgtxt.Text = y.GetString(5);
                    pgyrtxt.Text = Convert.ToString(y.GetSqlValue(6));          // GetSqlValue: gives(returns) sql server type(format) of selected data from db table
                    pgpertxt.Text = Convert.ToString(y.GetSqlValue(7));

                    gddl.Text = y.GetString(8);
                    gclgtxt.Text = y.GetString(9);
                    gyrtxt.Text = Convert.ToString(y.GetSqlValue(10));
                    gpertxt.Text = Convert.ToString(y.GetSqlValue(11));

                    stxt.Text = y.GetString(12);
                    syrtxt.Text = Convert.ToString(y.GetSqlValue(13));
                    spertxt.Text = Convert.ToString(y.GetSqlValue(14));

                    cotxt.Text = y.GetString(15);
                    sstxt.Text = y.GetString(16);
                    pstxt.Text = y.GetString(17);
                    pdtxt.Text = y.GetString(18);

                    btnEdit.Enabled = false;
                    msgtxt.Visible = false;
                    btnSave.Text = "Update";
                    btnSave.Enabled = true;

                    txtEnable(true);
                }
                else
                {
                    string z = "window.onload = function(){ alert('NO RECORD FOUND\\n  PLEASE TRY AGAIN'); }";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", z, true);
                    //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('NO RECORD FOUND\\n  PLEASE TRY AGAIN')", true);
                    //Response.Write("<script>alert('NO RECORD FOUND\\n  PLEASE TRY AGAIN')</script>");
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user");

            //string z = "window.onload = function(){ alert('cancel'); window.location = 'user'; }";
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", z, true);

            /* Response.Write("<script>alert('cancel')</script>"); */
            /* < script type = "text/javascript" >
                function Showalert() {
                    alert('Cancel');
                }
            </ script > */
            /* Type cstype = this.GetType();

            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = Page.ClientScript;

            // Check to see if the startup script is already registered.
            if (!cs.IsStartupScriptRegistered(cstype, "PopupScript"))
            {
                String cstext = "alert('cancel');";
                cs.RegisterStartupScript(cstype, "PopupScript", cstext, true);
            } */
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('cancel')", true);

            /* con.Close();
            Page_Load(sender, e); */
            /* ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "alert('cancel')", true); */
            /* Page.Response.Redirect(Page.Request.Url.ToString(), true); */
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                string x = "insert into details values('" + nmtxt.Text + "','" + Convert.ToInt64(notxt.Text) + "','" + etxt.Text + "','" + pgddl.Text + "','" + pgclgtxt.Text + "','" + Convert.ToInt64(pgyrtxt.Text) + "','" + Convert.ToDecimal(pgpertxt.Text) + "','" + gddl.Text + "','" + gclgtxt.Text + "','" + Convert.ToInt64(gyrtxt.Text) + "','" + Convert.ToDecimal(gpertxt.Text) + "','" + stxt.Text + "','" + Convert.ToInt64(syrtxt.Text) + "','" + Convert.ToDecimal(spertxt.Text) + "','" + cotxt.Text + "','" + sstxt.Text + "','" + pstxt.Text + "','" + pdtxt.Text + "')";
                sqlcmd(ref x);

                string z = "window.onload = function(){ alert('Data inserted successfully'); window.location = 'user'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", z, true);

                //Response.Write("<script>alert('Data inserted successfully')</script>");
                //Response.Redirect("~/user");
                /* Page.Response.Redirect(Page.Request.Url.ToString(), true); */

                /* nmtxt.Text = "";
                notxt.Text = "";
                etxt.Text = "";
                /* pgddl.Text = "";
                pgclgtxt.Text = "";
                pgyrtxt.Text = "";
                pgpertxt.Text = "";
                gddl.Text = "";
                gclgtxt.Text = "";
                gyrtxt.Text = "";
                gpertxt.Text = "";
                stxt.Text = "";
                syrtxt.Text = "";
                spertxt.Text = "";
                cotxt.Text = "";
                sstxt.Text = "";
                pstxt.Text = "";
                pdtxt.Text = "";

                display(); */
            }
            else                                        // btnUpdate
            {
                //string p = nmtxt.Text;
                //string q = etxt.Text;
                //string x = "update details set name='" + nmtxt.Text + "', no='" + Convert.ToInt64(notxt.Text) + "', email='" + etxt.Text + "', pg='" + pgddl.Text + "', pg_clg='" + pgclgtxt.Text + "', pg_yr='" + Convert.ToInt64(pgyrtxt.Text) + "', pg_per='" + Convert.ToDecimal(pgpertxt.Text) + "', g='" + gddl.Text + "', g_clg='" + gclgtxt.Text + "', g_yr='" + Convert.ToInt64(gyrtxt.Text) + "', g_per='" + Convert.ToDecimal(gpertxt.Text) + "', scl='" + stxt.Text + "', scl_yr='" + Convert.ToInt64(syrtxt.Text) + "', scl_per='" + Convert.ToDecimal(spertxt.Text) + "', co='" + cotxt.Text + "', ss='" + sstxt.Text + "', ps='" + pstxt.Text + "', pd='" + pdtxt.Text + "' where name='" + nmtxt.Text + "' AND email='" + etxt.Text + "'";
                //string x = "update details set name='" + nmtxt.Text + "', no='" + Convert.ToInt64(notxt.Text) + "', email='" + etxt.Text + "', pg='" + pgddl.Text + "', pg_clg='" + pgclgtxt.Text + "', pg_yr='" + Convert.ToInt64(pgyrtxt.Text) + "', pg_per='" + Convert.ToDecimal(pgpertxt.Text) + "', g='" + gddl.Text + "', g_clg='" + gclgtxt.Text + "', g_yr='" + Convert.ToInt64(gyrtxt.Text) + "', g_per='" + Convert.ToDecimal(gpertxt.Text) + "', scl='" + stxt.Text + "', scl_yr='" + Convert.ToInt64(syrtxt.Text) + "', scl_per='" + Convert.ToDecimal(spertxt.Text) + "', co='" + cotxt.Text + "', ss='" + sstxt.Text + "', ps='" + pstxt.Text + "', pd='" + pdtxt.Text + "' where name='" + p + "' AND email='" + q + "'";
                //string x = "update details set name='" + nmtxt.Text + "', no='" + Convert.ToInt64(notxt.Text) + "', email='" + etxt.Text + "', pg='" + pgddl.Text + "', pg_clg='" + pgclgtxt.Text + "', pg_yr='" + Convert.ToInt64(pgyrtxt.Text) + "', pg_per='" + Convert.ToDecimal(pgpertxt.Text) + "', g='" + gddl.Text + "', g_clg='" + gclgtxt.Text + "', g_yr='" + Convert.ToInt64(gyrtxt.Text) + "', g_per='" + Convert.ToDecimal(gpertxt.Text) + "', scl='" + stxt.Text + "', scl_yr='" + Convert.ToInt64(syrtxt.Text) + "', scl_per='" + Convert.ToDecimal(spertxt.Text) + "', co='" + cotxt.Text + "', ss='" + sstxt.Text + "', ps='" + pstxt.Text + "', pd='" + pdtxt.Text + "' where id=1";
                string x = "update details set name='" + nmtxt.Text + "', no='" + Convert.ToInt64(notxt.Text) + "', email='" + etxt.Text + "', pg='" + pgddl.Text + "', pg_clg='" + pgclgtxt.Text + "', pg_yr='" + Convert.ToInt64(pgyrtxt.Text) + "', pg_per='" + Convert.ToDecimal(pgpertxt.Text) + "', g='" + gddl.Text + "', g_clg='" + gclgtxt.Text + "', g_yr='" + Convert.ToInt64(gyrtxt.Text) + "', g_per='" + Convert.ToDecimal(gpertxt.Text) + "', scl='" + stxt.Text + "', scl_yr='" + Convert.ToInt64(syrtxt.Text) + "', scl_per='" + Convert.ToDecimal(spertxt.Text) + "', co='" + cotxt.Text + "', ss='" + sstxt.Text + "', ps='" + pstxt.Text + "', pd='" + pdtxt.Text + "' where id='" + i + "'";
                sqlcmd(ref x);

                string z = "window.onload = function(){ alert('Data updated successfully'); window.location = 'user'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", z, true);

                // Response.Write("<script>alert('Data updated successfully')</script>");

                /* btnCancel_Click(sender, e); */

                // Response.Redirect("~/user");
                /* Page.Response.Redirect(Page.Request.Url.ToString(), true); */

                /* headtxt.ForeColor = System.Drawing.Color.Black;
                btnCancel.Visible = false;
                btnEdit.Text = "Edit";
                btnEdit.Enabled = true;
                btnSave.Text = "Save";

                nmtxt.Text = "";
                notxt.Text = "";
                etxt.Text = "";
                /* pgddl.Text = ""; 
                pgclgtxt.Text = "";
                pgyrtxt.Text = "";
                pgpertxt.Text = "";
                /* gddl.Text = "";
                gclgtxt.Text = "";
                gyrtxt.Text = "";
                gpertxt.Text = "";
                stxt.Text = "";
                syrtxt.Text = "";
                spertxt.Text = "";
                cotxt.Text = "";
                sstxt.Text = "";
                pstxt.Text = "";
                pdtxt.Text = "";

                display(); */
            }

            /* string x = "insert into details values('" + nmtxt.Text + "','" + Convert.ToInt64(notxt.Text) + "','" + etxt.Text + "','" + pgddl.Text + "','" + pgclgtxt.Text + "','" + Convert.ToInt64(pgyrtxt.Text) + "','" + Convert.ToInt64(pgpertxt.Text) + "','" + gddl.Text + "','" + gclgtxt.Text + "','" + Convert.ToInt64(gyrtxt.Text) + "','" + Convert.ToInt64(gpertxt.Text) + "','" + stxt.Text + "','" + Convert.ToInt64(syrtxt.Text) + "','" + Convert.ToInt64(spertxt.Text) + "','" + cotxt.Text + "','" + sstxt.Text + "','" + pstxt.Text + "','" + pdtxt.Text + "')";
            sqlcmd(ref x);
            Response.Write("<script>alert('Data inserted successfully')</script>"); */

            /* ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true); */

            /* msgtxt.Visible = true;
            int time = 0; */
            /* do {
                    int count ++;
            } while (count < 200); */

            /* while (time < 90000000) time++;
            if (time == 90000000) msgtxt.Visible = false; */

            /* if (time == 0)
            {
                msgtxt.Visible = true;
                while (time < 90000000) time++;
            }
            if (time == 90000000)
            {
                msgtxt.Visible = false;
                time = 0;
            } */
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/resume");
        }
    }
}
