using System.ComponentModel.DataAnnotations;

namespace MIMOWEB_ENG_NEW.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [RegularExpression(
            @"^[a-zA-Z ]*$",
            ErrorMessage = "Use letters only please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname cannot be empty")]
        [RegularExpression(
            @"^[a-zA-Z ]*$",
            ErrorMessage = "Use letters only please")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Telephone is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(
            @"^([0-9\(\)\/\+ \-]*)$",
            ErrorMessage = "Only numbers and symbols allowed")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "subject is required")]
        [RegularExpression(
            @"^[a-zA-Z ]*$",
            ErrorMessage = "Use letters only please")]
        [DataType(DataType.MultilineText)]
        public string Cover { get; set; }
    }
}