using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Payments
{
    [Table("PAYMENT_METHOD")]
    public class Payment_Method
    {
        [Key]
        public int paymentMethodID { get; set; }
        public string cardNumber { get; set; }
        public string expirationDate { get; set; }
        public int securityCode { get; set; }

        [ForeignKey("paymentID")]
        public int paymentID { get; set; }
    }
}