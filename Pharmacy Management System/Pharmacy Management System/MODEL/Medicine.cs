using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.MODEL
{
    class Medicine
    {
        public string companyName { get; set; }
        public int medicineID { get; set; } 
        public string MedicineName { get; set; }

        public string companyID { get; set; }

        public int Quantity { get; set; }

        public string unit { get; set; }

        public int price { get; set; }
    }
    
}

