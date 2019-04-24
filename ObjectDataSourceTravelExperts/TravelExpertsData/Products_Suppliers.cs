using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Products_Suppliers
    {
        public int ProductSupplierID { get; set; } // primary key, auto increment
        public int ProductID { get; set; } // foreign key, null
        public int SupplierID { get; set; } // foreign key, null
    }
}
