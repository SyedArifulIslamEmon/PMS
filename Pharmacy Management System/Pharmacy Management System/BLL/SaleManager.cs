using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Management_System.DAL;

namespace Pharmacy_Management_System.BLL
{
    class SaleManager
    {
        SellGateway mySellGateway = new SellGateway();

        public void SearchAll(string salesId)
        {
             mySellGateway.SearchAll(salesId);
        }
    }
}
