using System.ComponentModel.DataAnnotations;

namespace MIMOWEB_ENG_NEW.Models
{
    public class FormDetails
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        [RegularExpression(
            @"^[a-zA-Z ]{0,50}$",
            ErrorMessage = "Letters only, max 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname cannot be empty")]
        [RegularExpression(
            @"^[a-zA-Z ]{0,50}$",
            ErrorMessage = "Letters only, max 50 characters")]
        public string Surname { get; set; }

        [RegularExpression(
            @"^[a-zA-Z ]{0,50}$",
            ErrorMessage = "Letters only, max 50 characters")]
        public string Title { get; set; }

        [RegularExpression(
            @"^[a-zA-Z0-9 ]{0,50}$",
            ErrorMessage = "Letters and numbers only, max 50 characters")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Telephone is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(
            @"^([0-9\(\)\/\+ \-]*)$",
            ErrorMessage = "Only numbers and symbols allowed")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        [RegularExpression(
            @"^[a-zA-Z ]{0,50}$",
            ErrorMessage = "Letters only, max 50 characters")]
        public string Subject { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}