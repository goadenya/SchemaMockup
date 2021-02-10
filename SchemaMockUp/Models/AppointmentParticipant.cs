using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchemaMockUp.Models
{
    class AppointmentParticipant
    {
        [Key]
        public int AppointmentParicipantID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; } //Fk
        public User User { get; set; }
        [ForeignKey("Appointment")]
        public int AppointmentID { get; set;} //Fk
        public Appointment Appointment { get; set; }
        public string  Reminder { get; set; }

    }
}
