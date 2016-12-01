using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Compounds
    {
        //We have a composite primary key
        [Key]
        public int LTnumber { get; set; }

        [Key]
        public int compoundSequenceCode { get; set; }

        [DisplayName("Compound name")]
        public String name { get; set; }

        [DisplayName("Quantity")]
        public String quantity { get; set; }


        [DisplayName("Weight from Client")]
        public String clientWeight { get; set; }

        [DisplayName("Appearance")]
        public String appearance { get; set; }

        [DisplayName("Molecular Mass")]
        public String molecularMass { get; set; }

        //[ForeignKey("Customer")]
        
        [ForeignKey("WorkOrderId")]
        public int workorderID { get; set; }

        [ForeignKey("assayID")]
        public int assayID { get; set; }

        [DisplayName("Maximum Tolerated Dose")]
        public String maximumToleratedDose { get; set; }
    }
}