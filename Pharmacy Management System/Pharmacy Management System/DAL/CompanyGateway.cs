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
    class CompanyGateway
    {
        string connectionString = ConfigurationManager.ConnectionStrings["pharmacyConString"].ConnectionString;
        Company company = new Company();
        public List<Company> ShowAll()
        {
            List<Company> companieslList = new List<Company>();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM company";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                Company company = new Company();
                company.CompanyId = Convert.ToInt32(myReader["company_id"].ToString());
                company.Name = myReader["company_name"].ToString();
                company.Address = myReader["address"].ToString();
                companieslList.Add(company);
            }
            return companieslList;
        }

        public int Save(Company company)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO company VALUES('" + company.Name + "','" + company.Address + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();

            int rowAffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return rowAffected;
        }

        public Company GetStudentById(int companyId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM company WHERE company_id = '" + companyId + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Company company = null;


            while (reader.Read())
            {

                if (company == null)
                {
                    company = new Company();
                }
                company.CompanyId = int.Parse(reader["company_id"].ToString());
                company.Name = reader["company_name"].ToString();
                company.Address = reader["address"].ToString();
                
            }

            reader.Close();
            connection.Close();

            return company;
        }

        public void Update(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE company SET company_name = '" + company.Name + "', address= '" + company.Address + "' WHERE company_id =" + company.CompanyId;
          
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            
        }

        public void Delete(Company company)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Delete from company WHERE company_id =" + company.CompanyId;
            
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public List<Company> GetAllCompany()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM company";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Company> companies = new List<Company>();

            while (reader.Read())
            {

                company.CompanyId = int.Parse(reader["company_id"].ToString());
                company.Name = reader["company_name"].ToString();


                companies.Add(company);
            }
            reader.Close();
            connection.Close();

            return companies;
        }
    }
}
