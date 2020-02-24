using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace os411615_MIS4200.Models
{
    public class Doctor
    {
        public int doctorID { get; set; }
        public string doctorFullName { get { return doctorLastName + ", " + doctorFirstName; } }

        // public System.Guid SID { get; set; }

        [Display(Name = "Doctor First Name")]
        [Required(ErrorMessage = "Doctor first name is required")]
        [StringLength(20)]
        public string doctorFirstName { get; set; }

        [Display(Name = "Doctor Last Name")]
        [Required]
        [StringLength(20)]
        public string doctorLastName { get; set; }

        [Display(Name = "Doctor Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string doctorEmail { get; set; }

        [Display(Name = "Doctor Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
          ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string doctorPhone { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}