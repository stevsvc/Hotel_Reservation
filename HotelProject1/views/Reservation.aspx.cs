using HotelProject1.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelProject1.views
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Check_Information(object sender, EventArgs e)
        {
            Guid GUID;
            GUID = Guid.NewGuid();
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = @"Data Source=186.101.103.197; Initial Catalog=Reservaciones;User ID=rodal;Password=Mishell2017;";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert_Information", connection);
            cmd.Parameters.Add(new SqlParameter("Reservation_ID", GUID));
            cmd.Parameters.Add(new SqlParameter("Room_Type", TextBox1.Text));
            cmd.Parameters.Add(new SqlParameter("Availability", TextBox2.Text));

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        protected void Reserve_Room(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlDataReader reader;

            connection.ConnectionString = @"Data Source=186.101.103.197; Initial Catalog=Reservaciones;User ID=rodal;Password=Mishell2017; MultipleActiveResultSets = true;";

            SqlCommand cmd = new SqlCommand("Handle_Dates", connection);
            cmd.Parameters.Add(new SqlParameter("Check_In_Customer", Convert.ToDateTime(Check_In.Text)));
            cmd.Parameters.Add(new SqlParameter("Check_Out_Customer", Convert.ToDateTime(Check_Out.Text)));
            cmd.Parameters.Add(new SqlParameter("Type", Type_Room.Text));

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader.HasRows)
                {
                    Reservation CheckData = new Reservation();
                    CheckData.Check_In_Data = Convert.ToDateTime(reader.GetValue(0));
                    CheckData.Check_Out_Data = Convert.ToDateTime(reader.GetValue(1));
                    CheckData.Type_Data = reader.GetValue(2).ToString();
                }
                else
                {
                    SqlCommand InsertData = new SqlCommand("Insert_Information", connection);
                    InsertData.Parameters.Add(new SqlParameter("Check_In_Date", Convert.ToDateTime(Check_In.Text)));
                    InsertData.Parameters.Add(new SqlParameter("Check_Out_Date", Convert.ToDateTime(Check_Out.Text)));
                    InsertData.Parameters.Add(new SqlParameter("Type", Type_Room.Text));
                    InsertData.CommandType = System.Data.CommandType.StoredProcedure;
                    InsertData.ExecuteReader();
                }

                connection.Close();
            }
        }

        protected void Check_In_Date_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Check_Out_Date_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}