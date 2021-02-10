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
        public Class Class { get; set; }
        public int UserID { get; set; } //Fk
        [ForeignKey("Appointment")]
        public int AppointmentID { get; set;} //Fk
        public Appointment Appointment { get; set; }
        public string  Reminder { get; set; }

    }
}
