using System.ComponentModel.DataAnnotations;

namespace Register.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please select your gender.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select your country.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter your date of birth.")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "You must accept the terms and conditions.")]
        [Display(Name = "Accept Terms and Conditions")]
        public bool AcceptTermsAndConditions { get; set; }
    }
}
