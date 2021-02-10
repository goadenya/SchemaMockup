using System;
using System.Collections.Generic;
using System.Text;

namespace testdbbConsole.Models
{
    class Message
    {
        public int MessageID { get; set; }
        public Chat Chat { get; set; } //Fk
        public User User { get; set; }//Fk
        public string ChatMessage { get; set; }
        public string MediaUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime Read { get; set; }

    }
}
