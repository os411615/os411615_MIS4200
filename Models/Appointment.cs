using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace os411615_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public DateTime appointmentDate { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}