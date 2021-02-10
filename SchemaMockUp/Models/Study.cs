using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Study
    {
        [Key]
        public int StudyID { get; set; }
        [ForeignKey("Education")]
        public int EducationID { get; set; }
        public Education Education { get; set; }
        [ForeignKey("UserSpecification")]
        public int UserSpecificationID { get; set; }
        public UserSpecification UserSpecification { get; set; }
        public int Rating { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}
