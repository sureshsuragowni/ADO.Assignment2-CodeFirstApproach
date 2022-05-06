using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusInfoCodeFirst.Models
{
    public class BusInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusId { get; set; }
        public String BoardingPoint { get; set; }
        public DateTime TravelDate { get; set; }
        public double Amount { get; set; }
        public int Rating { get; set; }
     

    }
}