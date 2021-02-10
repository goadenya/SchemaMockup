using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class UserSpecification
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string CompanyName { get; set; }
        public int OrgNumber { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Experience { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public string Skills { get; set; }
    }
}
