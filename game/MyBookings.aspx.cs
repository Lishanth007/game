using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace game
{
    public partial class MyBookings : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["GameDBConn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string sql = @"SELECT b.BookingID, a.ArenaName, b.BookingDate, b.TimeSlot, b.TotalAmount, b.PaymentMode, b.PaymentStatus 
                                   FROM Bookings b 
                                   JOIN Arenas a ON b.ArenaID = a.ArenaID 
                                   WHERE b.UserID = 1 
                                   ORDER BY b.BookingID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvBookings.DataSource = dt;
                    gvBookings.DataBind();
                }
            }
        }
    }
}