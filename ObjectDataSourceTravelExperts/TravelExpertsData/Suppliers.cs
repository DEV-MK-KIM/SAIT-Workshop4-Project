using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Suppliers
    {
        public int SupplierID { get; set; } // primary key, non-auto increment
        public string SupName { get; set; } // null

        /// <summary>
        /// Clone the object of Suppliers
        /// </summary>
        /// <returns>copy of supplier object </returns>
        public Suppliers Clone()
        {
            Suppliers copy = new Suppliers();
            copy.SupplierID = SupplierID;
            copy.SupName = SupName;
           

            return copy;

        }
    }
}
