using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string DOBifStudent { get; set; }
        public bool EmailVerified { get; set; } = false;
        public List<UserRole> UserRoles { get; set; }
    }
}
