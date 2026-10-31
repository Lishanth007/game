using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace game
{
    public partial class Arenas : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["GameDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Arenas", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvArenas.DataSource = dt;
                    gvArenas.DataBind();
                }
            }
        }

        protected void gvArenas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectArena")
            {
                string[] data = e.CommandArgument.ToString().Split(';');
                Session["ArenaID"] = data[0];
                Session["ArenaName"] = data[1];
                Session["Rate"] = data[2];
                Response.Redirect("BookSlot.aspx");
            }
        }
    }
}