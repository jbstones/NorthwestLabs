using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST_MATERIALS")]
    public class Test_Materials
    {
        [Key]
        public int materialID { get; set; }
        public string testName { get; set; }
        public string quantity { get; set; }
    }
}