using System;
using System.Configuration;
using System.Data.SqlClient;

namespace game
{
    public partial class BookSlot : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["GameDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                using (SqlConnection con = new SqlConnection(conn))
                {
                    SqlCommand cmd = new SqlCommand("SELECT ArenaID, ArenaName FROM Arenas", con);
                    con.Open();
                    ddlArenas.DataSource = cmd.ExecuteReader();
                    ddlArenas.DataTextField = "ArenaName";
                    ddlArenas.DataValueField = "ArenaID";
                    ddlArenas.DataBind();
                }

                if (Session["ArenaID"] != null)
                {
                    ddlArenas.SelectedValue = Session["ArenaID"].ToString();
                }

                GetPrice();
            }
        }

        protected void ddlArenas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrice();
        }

        void GetPrice()
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("SELECT HourlyRate FROM Arenas WHERE ArenaID = @id", con);
                cmd.Parameters.AddWithValue("@id", ddlArenas.SelectedValue);
                con.Open();
                object val = cmd.ExecuteScalar();
                if (val != null) lblRate.Text = val.ToString();
            }
        }

        protected void btnGoToCart_Click(object sender, EventArgs e)
        {
            Session["Cart_ArenaID"] = ddlArenas.SelectedValue;
            Session["Cart_ArenaName"] = ddlArenas.SelectedItem.Text;
            Session["Cart_Date"] = txtDate.Text;
            Session["Cart_Slot"] = ddlSlots.SelectedValue;
            Session["Cart_Amount"] = lblRate.Text;

            Response.Redirect("Cart.aspx");
        }
    }
}