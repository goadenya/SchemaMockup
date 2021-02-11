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
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Education Education { get; set; }
        [ForeignKey("ID")]
        public UserSpecification UserSpecification { get; set; }
        public int Rating { get; set; }
        public bool IsVerified { get; set; } = false;
    }
}
