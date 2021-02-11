using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class Role
    {
        [Key]
        public int ID { get; set; }
        public string NameOfRole { get; set; }
        public string NormalizedName { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
    }
}
