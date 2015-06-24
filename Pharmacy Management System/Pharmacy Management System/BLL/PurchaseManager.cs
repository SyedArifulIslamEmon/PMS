using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Management_System.DAL;
using Pharmacy_Management_System.MODEL;

namespace Pharmacy_Management_System.BLL
{
    class PurchaseManager
    {
        PurchaseGateway myPurchaseGateway = new PurchaseGateway();

        public List<Purchase> ShowAll()
        {
            return myPurchaseGateway.ShowAll();
        }
    }
}
