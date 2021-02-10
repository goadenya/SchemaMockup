using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Message
    {
        public int MessageID { get; set; }
        [ForeignKey("Chat")]
        public int ChatID { get;  set;  }
        public Chat Chat { get; set; } //Fk
        
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }//Fk
        [Column("Message")]
        public string ChatMessage { get; set; }
        public string MediaUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime Read { get; set; } //Bool?

    }
}
