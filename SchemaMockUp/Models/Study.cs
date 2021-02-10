using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Study
    {
        [Key]
        public int StudyID { get; set; }
        public Education Education { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public bool IsVerified { get; set; }
    }
}
