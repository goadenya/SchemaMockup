using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class UserRole
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public User User { get; set; }
        [ForeignKey("ID")]
        public Role Role { get; set; }
    }
}
