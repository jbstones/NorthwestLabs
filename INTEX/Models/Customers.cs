using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Customers
    {
        [Key]
        public int customerID { get; set; }

        [DisplayName("Company name")]
        public String companyname { get; set; }


        [DisplayName("State")]
        public String state { get; set; }

        [DisplayName("City")]
        public String city { get; set; }

        [DisplayName("Street Address")]
        public String address { get; set; }

        [DisplayName("Zip Code")]
        public String zip { get; set; }
        
        [DisplayName("Phone number")]
        public String phone { get; set; }

        [DisplayName("Email")]
        public String email { get; set; }
    }
}