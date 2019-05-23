using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    class Packages_Products_Suppliers_DB
    {
        public int PackagId { get; set; }
        public int ProductSupplierId { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
