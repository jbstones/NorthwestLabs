using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Compounds
{
    [Table("COMPOUND_RECEIPT")]
    public class Compound_Receipt
    {
        [Key]
        public int receiptID { get; set; }

        [ForeignKey("LTnumber")]
        public int LTnumber { get; set; }

        [ForeignKey("CompoundSeqCode")]
        public int CompoundSequenceCode { get; set; }

        public string receivedDate { get; set; }

        [ForeignKey("Received by")]
        public int employeeReceivedBy { get; set; }

        public string datedue { get; set; }
        public string actualWeight { get; set; }

    }
}