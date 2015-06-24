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
    class PurchaseGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["pharmacyConString"].ConnectionString;

        public List<Purchase> ShowAll()
        {
            List<Purchase> purchases = new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT p.id id,m.m_name name,p.qty qty,p.p_date date1,p.price price FROM purchase p, medicine m";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Purchase purchase = new Purchase();

                purchase.PurchaseId = Convert.ToInt32(myReader["id"].ToString());
                purchase.PurchaseDate = myReader["date1"].ToString();
                purchase.MedicineName = myReader["name"].ToString();
                purchase.Quantity = Convert.ToInt32(myReader["qty"].ToString());
                purchase.price = Convert.ToInt32(myReader["price"].ToString());
               
                purchases.Add(purchase);
            }
            return purchases;
        }
    }
}
