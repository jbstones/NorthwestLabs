using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("ASSAY_DESCRIPTION")]
    public class Assay_description
    {
        [Key]
        public String assayName { get; set; }
        public String assayDescription { get; set; }

        [ForeignKey("catalogID")]
        public int catalogID { get; set; }

    }
}