using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.MODEL
{
    class Sale
    {
          public int SaleId { get; set; }

        public string MedicineName { get; set; }

        public int Quantity { get; set; }

        public string Date { get; set; }

        public string Description { get; set; }
    }

}
