using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST_SCHEDULE")]
    public class Test_Schedule
    {
        [Key]
        public int testScheduleID { get; set; }

        public string startdate { get; set; }
        public string enddate { get; set; }

        [ForeignKey("testID")]
        public int testID { get; set; }
    }
}