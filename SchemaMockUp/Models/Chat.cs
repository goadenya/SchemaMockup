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
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int RecieverID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public virtual List<Message> Messages { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
