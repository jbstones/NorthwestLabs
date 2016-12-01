using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Invoice
    {
        [Key]
        public int invoiceID { get; set; }


        //Foreign key
        [ForeignKey("workOrderID")]
        public int workOrderID { get; set; }

        [DisplayName("Amount Due")]
        public String AmountDue { get; set; }

        [DisplayName("Due date")]
        public String datepaymentdue { get; set; }

        [DisplayName("Early payment date")]
        public String earlyPaymentDate { get; set; }

        [DisplayName("Early payment discount")]
        public String earlyPaymentDiscount { get; set; }

        [DisplayName("Quantity discount")]
        public String quantityDiscount { get; set; }

        [DisplayName("Date sent")]
        public String sentDate { get; set; }


    }
}