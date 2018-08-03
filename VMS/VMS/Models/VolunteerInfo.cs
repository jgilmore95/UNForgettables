using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMS.Models
{
    public class VolunteerInfo
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Confirm password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Addressone { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Addresstwo { get; set; }
        [Required(ErrorMessage = "Please enter state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter Zipcode")]
        public string Zipcode { get; set; }
        //---------------------------------------------------------------new lines
        [Required(ErrorMessage = "Please enter preffered work")]
        public string PW { get; set; }
        [Required(ErrorMessage = "Please enter your skills interest")]
        public string SI { get; set; }
        [Required(ErrorMessage = "Please enter your avilibility ID")]
        public string AID { get; set; }
        [Required(ErrorMessage = "Please enter your Educatrion ID")]
        public string EID { get; set; }
        [Required(ErrorMessage = "Please list your current licenses")]
        public string CL { get; set; }
        [Required(ErrorMessage = "Please enter the emergency contacts first name")]
        public string ECFN { get; set; }
        [Required(ErrorMessage = "Please enter emergency contacts last name")]
        public string ECLN { get; set; }
        [Required(ErrorMessage = "Please enter the emergency contacts home phone number")]
        public string ECHP { get; set; }
        [Required(ErrorMessage = "Please enter emergency contacts work phone number")]
        public string ECWP { get; set; }
        [Required(ErrorMessage = "Please enter emergency contact cell phone number")]
        public string ECCP { get; set; }
        [Required(ErrorMessage = "Please enter emergency contacts email address")]
        public string ECE { get; set; }
        [Required(ErrorMessage = "Please enter the emergency contacts street address")]
        public string ECA { get; set; }
        [Required(ErrorMessage = "Please enter the emergency contacts city")]
        public string ECC { get; set; }
        [Required(ErrorMessage = "Please enter emergency contacts state ID")]
        public string ECSI { get; set; }
        [Required(ErrorMessage = "Pleae enter the emergency contacts zipcode")]
        public string ECZ { get; set; }
        [Required(ErrorMessage = "Please enter your drivers license Identification number")]
        public string DLN { get; set; }
        [Required(ErrorMessage = "Please enter your social security number")]
        public string SSN { get; set; }
        [Required(ErrorMessage = "Please enter your volunteer status ID")]
        public string VSID{ get; set; }
    }
}
