using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchemaMockUp.Models
{
    class User
    {
        [Key]
        public int UserID { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOBifStudent { get; set; }
        public bool EmailVerified { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Chat> Chats { get; set; }
        public List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
