using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Payments
{
    public class Payment
    {
        [Key]
        public int paymentID { get; set; }


        //Foreign key
        [ForeignKey("invoiceID")]
        public int invoiceID { get; set; }

        [DisplayName("Amount paid")]
        public String AmountDue { get; set; }

        [DisplayName("Due date")]
        public String datepaymentdue { get; set; }


        [DisplayName("Early payment date")]
        public String earlyPaymentDate { get; set; }
    }
}