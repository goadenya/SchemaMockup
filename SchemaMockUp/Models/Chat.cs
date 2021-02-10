using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Chat
    {
        [Key]
        public int ChatID { get; set; }
        //[ForeignKey("User")]
        //public int UserAID { get; set; }
        //public User UserA { get; set; }
        //[ForeignKey("User")]
        //public int UserBID { get; set; }
        //public User UserB { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        List<Message> Messages { get; set; }
        public List<User> Users { get; set; }
    }
}
