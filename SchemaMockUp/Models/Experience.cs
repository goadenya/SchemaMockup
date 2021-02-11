using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Experience
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public UserSpecification UserSpecification { get; set; }
        public string Name { get; set; }
        public string ExperienceLevel { get; set; }
        public bool IsVerified { get; set; } = false;
        public bool VerifiedByOrganizerID { get; set; } = false;
    }
}
