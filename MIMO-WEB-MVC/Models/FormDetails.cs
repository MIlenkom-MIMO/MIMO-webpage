using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Foolproof;


namespace MIMOWEB_ENG_NEW.Models
{
    public class FormDetails
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [RegularExpression(@"^[a-zA-Z ]{0,50}$", ErrorMessage = "letters only, max 50 characaters")]
        [NotEqualTo("Surname", ErrorMessage = "Name and Surname cannot be the same")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname cannot be empty")]
        [RegularExpression(@"^[a-zA-Z ]{0,50}$", ErrorMessage = "letters only, max 50 characaters")]
        [NotEqualTo("Name", ErrorMessage = "Name and Surname cannot be the same")]
        public string Surname { get; set; }
        [RegularExpression(@"^[a-zA-Z ]{0,50}$", ErrorMessage = "letters only, max 50 characaters")]
        public string Title { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9 ]{0,50}$", ErrorMessage = "letters only, max 50 characaters")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Telephone is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9\(\)\/\+ \-]*)$", ErrorMessage = "Only numbers and symbols allowed")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "subject is required")]
        [RegularExpression(@"^[a-zA-Z ]{0,50}$", ErrorMessage = "letters only, max 50 characaters")]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "message is required")]
        public string Message { get; set; }

    }

}