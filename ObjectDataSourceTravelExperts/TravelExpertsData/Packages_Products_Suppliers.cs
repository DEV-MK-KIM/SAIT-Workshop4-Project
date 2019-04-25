using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Packages_Products_Suppliers
    {
        // Packages_Products_Suppliers does NOT have its own distinct ID
        public int PackageID { get; set; } // PK, FK
        public int ProductSupplierID { get; set; } // PK, FK
    }
}
