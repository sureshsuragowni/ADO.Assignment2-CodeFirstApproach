using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BusInfoCodeFirst.Models
{
    public class BusInfoContext: DbContext
    {
        public BusInfoContext():base("name=conn")
        {

        }
        public DbSet<BusInfo> BusInfo { get; set; }
    }
}