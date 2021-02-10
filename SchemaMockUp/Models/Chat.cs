using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class Chat
    {
        [Key]
        public int ChatID { get; set; }
        public int UserAID { get; set; }
        public int UserBID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
