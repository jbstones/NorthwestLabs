using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    [Table("WORK_ORDER")]
    public class Work_Order
    {
        [Key]
        public int workOrderID { get; set; }

        [DisplayName("Order date")]
        public String date { get; set; }

        [DisplayName("Quoted price")]
        public String quotedPrice { get; set; }


        [DisplayName("Order Status")]
        public String status { get; set; }

        [DisplayName("Comments")]
        public String comments { get; set; }

        //Foreign Keys
        [ForeignKey("scheduleID")]
        public int scheduleID { get; set; }

        [ForeignKey("customerID")]
        public int customerID { get; set; }
    }
}