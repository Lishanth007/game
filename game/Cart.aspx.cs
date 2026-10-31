using System;
using System.Configuration;
using System.Data.SqlClient;

namespace game
{
    public partial class Cart : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["GameDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Cart_ArenaID"] == null)
                {
                    Response.Redirect("Arenas.aspx");
                    return;
                }

                lblArena.Text = Session["Cart_ArenaName"].ToString();
                lblDate.Text = Session["Cart_Date"].ToString();
                lblSlot.Text = Session["Cart_Slot"].ToString();
                lblTotal.Text = Session["Cart_Amount"].ToString();
            }
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                string sql = "INSERT INTO Bookings (UserID, ArenaID, BookingDate, TimeSlot, TotalAmount, PaymentMode, PaymentStatus) VALUES (1, @aid, @bdate, @slot, @amt, @pmode, 'Paid')";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@aid", Session["Cart_ArenaID"]);
                    cmd.Parameters.AddWithValue("@bdate", Session["Cart_Date"]);
                    cmd.Parameters.AddWithValue("@slot", Session["Cart_Slot"]);
                    cmd.Parameters.AddWithValue("@amt", Session["Cart_Amount"]);
                    cmd.Parameters.AddWithValue("@pmode", ddlPay.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            Session.Clear();
            Response.Redirect("MyBookings.aspx");
        }
    }
}