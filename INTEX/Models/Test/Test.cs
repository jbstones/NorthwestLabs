using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST")]
    public class Test
    {
        [Key]
        public int testID { get; set; }

        [ForeignKey("assayID")]
        public int assayID { get; set; }
        public string required { get; set; }
        public int testTubeNumber { get; set; }

        [ForeignKey("testName")]
        public string testName { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string date { get; set; }

         [ForeignKey("employeeID")]
        public int employeeID { get; set; }
        public string totalTestCost { get; set; }
    }
}