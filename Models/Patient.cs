using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace os411615_MIS4200.Models
{
    public class Patient
    {
        private string patientfirstName;
        private string patientlastName;

        public int patientID { get; set; }
        public string patientFullName { get { return patientLastName + ", " + patientFirstName; } }

        // public System.Guid SID { get; set; }

        [Display (Name ="Patient First Name")]
        [Required(ErrorMessage ="Patient first name is required")]
        [StringLength(20)]
        public string patientFirstName { get; set; }

        [Display (Name ="Patient Last Name")]
        [Required]
        [StringLength(20)]
        public string patientLastName { get; set; }

        [Display (Name ="Patient Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Enter your most frequently used email address")]
        public string patientEmail { get; set; }

        [Display (Name ="Patient Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string patientPhone { get; set; }

        [Display (Name ="Patient Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> patientSince { get; set; }

        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)

        public ICollection<Appointment> Appointment { get; set; }
    }
}