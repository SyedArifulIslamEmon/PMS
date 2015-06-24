using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Management_System.MODEL;

namespace Pharmacy_Management_System.DAL
{
    class SellGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["pharmacyConString"].ConnectionString;
        Sale sale = new Sale();

        public void SearchAll(string salesId)
        {
            
           // string con = ConfigurationManager.ConnectionStrings["pharmacyConString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from sell where id='" + salesId + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                //Book book = new Book();
                sale.MedicineName = myReader["m_id"].ToString();
                sale.Date = myReader["s_date"].ToString();
                sale.Quantity = Convert.ToInt32(myReader["qty"].ToString());
                
            }
           // return salesId;
        }
    }
}
