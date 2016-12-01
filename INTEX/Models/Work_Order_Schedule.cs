using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("WORK_ORDER_SCHEDULE")]
    public class Work_Order_Schedule
    {
        
        [Key]
        public int scheduleID { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }
}