using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class UserSpecification
    {
        [Key]
        public int UserSpecificationID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Gender { get; set; }
        public string CompanyName { get; set; }
        public int OrgNumber { get; set; }
        public string ProfileImageUrl { get; set; }
        public string City { get; set; }
        public string About { get; set; }
        public string Skills { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
