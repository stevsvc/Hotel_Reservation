using HotelProject1.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;


namespace HotelProject1.views
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //    object Check_In;
        //    object Check_Out;
        //    object Room_Type;
        //    object names;
        //    object surnames;
        //    object email;
        //    object phone;
            
        //    Check_In = Request.Form.Get("check_In_Date");
        //    Check_Out = Request.Form.Get("check_Out_Date");
        //    Room_Type = Request.Form.Get("room_Type");
        //    names = Request.Form.Get("names");
        //    surnames = Request.Form.Get("surnames");
        //    email = Request.Form.Get("email");
        //    phone = Request.Form.Get("phone");
        //    SqlConnection connection = new SqlConnection();
        //    SqlDataReader reader;

        //    connection.ConnectionString = @"Data Source=186.101.103.197; Initial Catalog=Reservaciones;User ID=rodal;Password=Mishell2017; MultipleActiveResultSets = true;";

        //    SqlCommand cmd = new SqlCommand("Handle_Dates", connection);
        //    cmd.Parameters.Add(new SqlParameter("Check_In_Customer", Convert.ToDateTime(Check_In)));
        //    cmd.Parameters.Add(new SqlParameter("Check_Out_Customer", Convert.ToDateTime(Check_Out)));
        //    cmd.Parameters.Add(new SqlParameter("Type", Room_Type));

        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    connection.Open();
        //    reader = cmd.ExecuteReader();
        //    if (!reader.Read())
        //    {
        //        if (reader.HasRows)
        //        {
        //            Reservation CheckData = new Reservation();
        //            CheckData.Check_In_Data = Convert.ToDateTime(reader.GetValue(0));
        //            CheckData.Check_Out_Data = Convert.ToDateTime(reader.GetValue(1));
        //            CheckData.Type_Data = reader.GetValue(2).ToString();
        //        }
        //        else
        //        {
        //            SqlCommand InsertData = new SqlCommand("Insert_Information", connection);
        //            InsertData.Parameters.Add(new SqlParameter("Check_In_Date", Convert.ToDateTime(Check_In)));
        //            InsertData.Parameters.Add(new SqlParameter("Check_Out_Date", Convert.ToDateTime(Check_Out)));
        //            InsertData.Parameters.Add(new SqlParameter("Type", Room_Type));
        //            InsertData.CommandType = System.Data.CommandType.StoredProcedure;
        //            InsertData.ExecuteReader();
        //        }

        //        connection.Close();
        //    }
        }
    }
}