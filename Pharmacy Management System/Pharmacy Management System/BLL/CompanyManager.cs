using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Management_System.DAL;
using Pharmacy_Management_System.MODEL;

namespace Pharmacy_Management_System.BLL
{
    class CompanyManager
    {
        CompanyGateway myCompanyGateway = new CompanyGateway();
        Company company = new Company();

        public List<Company> ShowAll()
        {
            return myCompanyGateway.ShowAll();
        }

        public bool Save(Company company)
        {
            return myCompanyGateway.Save(company) > 0;
           
        }

        public Company GetStudentById(int companyId)
        {
            Company company = myCompanyGateway.GetStudentById(companyId);

            return company;
            
        }

        public void Update(Company company)
        {
            myCompanyGateway.Update(company);
            //MessageBox.Show("Update Success");
        }

        public void Delete(Company company)
        {
            myCompanyGateway.Delete(company);
        }

        public List<Company> GetAllCompany()
        {
            return myCompanyGateway.GetAllCompany();
        }
    }
}
