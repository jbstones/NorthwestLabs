using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INTEX.Models
{
    public class Employees
    {
        [Key]
        public int employeeID { get; set; }

        [DisplayName("First name")]
        public String firstName { get; set; }

        [DisplayName("Last name")]
        public String lastName { get; set; }


        [DisplayName("Address")]
        public String address { get; set; }

        [DisplayName("Email")]
        public String email { get; set; }   
                     
        [DisplayName("Phone number")]
        public String phone { get; set; }

        [DisplayName("Wage")]
        public String Wage { get; set; }

        [DisplayName("Title")]
        public String title { get; set; }

       
    }
}