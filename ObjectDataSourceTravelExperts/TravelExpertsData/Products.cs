using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Products
    {
        public int ProductID { get; set; } // primary key, auto increment
        public string ProdName { get; set; } // not null

        public Products Clone()
        {
            Products copy = new Products();
            copy.ProductID = ProductID;
            copy.ProdName = ProdName;
            return copy;
            // Done by Dingli
        }
    }
   
}
