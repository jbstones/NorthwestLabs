using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST_MATERIALS_USED")]
    public class Test_Materials_Used
    {
        [Key]
        public int materialID { get; set; }
        
        [Key]
        public int testID { get; set; }
        public int quantity { get; set; }

    }
}