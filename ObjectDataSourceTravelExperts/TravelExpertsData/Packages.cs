using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public class Packages
    {
        public int PackageID { get; set; } // Primary Key, auto increment
        public string PkgName { get; set; } // not null
        public DateTime? PkgStartDate { get; set; } // null
        public DateTime? PkgEndDate { get; set; } // null
        public string PkgDesc { get; set; } // not null
        public decimal PkgBasePrice { get; set; } // not null
        public decimal? PkgAgencyCommission { get; set; } // null


   
    public Packages Clone()
    {
        Packages copy = new Packages();
        copy.PackageID = this.PackageID;
        copy.PkgName = this.PkgName;
        copy.PkgStartDate = this.PkgStartDate;
        copy.PkgEndDate = this.PkgEndDate;
        copy.PkgDesc = this.PkgDesc;
        copy.PkgBasePrice = this.PkgBasePrice;
        copy.PkgAgencyCommission = this.PkgAgencyCommission;

            return copy;
    }
    }
}
