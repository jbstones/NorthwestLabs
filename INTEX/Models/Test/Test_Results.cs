using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INTEX.Models.Test
{
    [Table("TEST_RESULTS")]
    public class Test_Results
    {
        [Key]
        public int TestResultID { get; set; }
        public Byte quantitativeFile { get; set; }
        public Byte qualitativeFile { get; set; }

        [ForeignKey("testID")]
        public int testID { get; set; }

    }
}