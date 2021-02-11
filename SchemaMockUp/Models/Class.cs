using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class Class
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ID")]
        public Course Course { get; set; }
        public virtual List<User> Users { get; set; } //fk
        public virtual List<User> Educators{ get; set; } //fK
        public int Rating { get; set; }
        public virtual bool IsVerified { get; set; } = false;
    }
}
