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
    class MedicineGateWay
    {
        string connectionString = ConfigurationManager.ConnectionStrings["pharmacyConString"].ConnectionString;

        public List<Medicine> ShowAll()
        {
            List<Medicine> medicines = new List<Medicine>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT m.m_id m_id,m.m_name m_name,c.company_name company_name,m.qty qty,m.unit unit,m.price price FROM medicine m, company c where m.company_id = c.company_id";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Medicine medicine = new Medicine();

                medicine.medicineID = Convert.ToInt32(myReader["m_id"].ToString());
                medicine.MedicineName = myReader["m_name"].ToString();
                medicine.companyName = myReader["company_name"].ToString();
                medicine.Quantity = Convert.ToInt32(myReader["qty"].ToString());
                medicine.unit = myReader["unit"].ToString();
                medicine.price = Convert.ToInt32(myReader["price"].ToString());
               
                medicines.Add(medicine);
            }
            return medicines;
        }

        public void Save(Medicine medicine)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO medicine VALUES('" + medicine.MedicineName + "','" + medicine.Quantity + "','" + medicine.unit + "','" + medicine.companyID + "','" + medicine.price + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
