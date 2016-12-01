using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("ASSAY")]
    public class Assay
    {
        [Key]
        public int assayID { get; set; }

        [ForeignKey("assayName")]
        public string assayName { get; set; }

        public string type { get; set; }
        public string description { get; set; }
        public string timeframe { get; set; }
        public decimal totalAssayCost { get; set; }
    }
}