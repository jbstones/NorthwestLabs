using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("Materials")]
    public class Materials
    {
        [Key]
        public int materialID { get; set; }

        public string name { get; set; }
        public decimal cost { get; set; }
        public string type { get; set; }
    }
}