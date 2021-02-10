using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace testdbbConsole.Models
{
    class AppointmentParticipant
    {
        [Key]
        public int AppointmentParicipantID { get; set; }
        public User User { get; set; } //Fk
        public Appointment Appointment { get; set;} //Fk
        public string  Reminder { get; set; }

    }
}
