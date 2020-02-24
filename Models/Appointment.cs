using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace os411615_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }

        [Display(Name = "Appointment Date/Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> appointmentDate { get; set; }
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

    }
}