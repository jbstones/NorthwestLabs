using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST_DESCRIPTION")]
    public class Test_Description
    {
        [Key]
        public string testName { get; set; }
        public string testDescription { get; set; }
        public decimal basedPrice { get; set; }
        public string numberofDaystoComplete { get; set; }
        public string materialsRequired { get; set; }

    }
}