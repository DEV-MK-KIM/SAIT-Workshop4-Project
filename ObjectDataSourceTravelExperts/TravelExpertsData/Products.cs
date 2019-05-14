using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Products
    {
        // Done by Dingli
        public int ProductID { get; set; } // primary key, auto increment
        public string ProdName { get; set; } // not null

        public Products Clone()
        {
            Products copy = new Products();
            copy.ProductID = this.ProductID;
            copy.ProdName = this.ProdName;
            return copy;
        }
    }
   
}
