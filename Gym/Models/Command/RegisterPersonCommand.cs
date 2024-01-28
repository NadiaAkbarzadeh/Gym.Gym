using System.ComponentModel.DataAnnotations;

namespace Gym.Models.Command
{
    public class RegisterPersonCommand
    {
        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage =  "First Name couldn't be more than 50 character!")]
        [Required (ErrorMessage = "First Name couldn't empty")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [MaxLength(80)]
        [Required]
        public string LastName { get; set; }


        [Display(Name = "Birthdate")]
        [Required]
        public DateTime BirthDate { get; set; }


        [Display(Name = "National Code")]
        [MaxLength(10)]
        [Required]
        public string NationalCode { get; set; }


        [MaxLength(500)]
        [Required]
        public string Address { get; set; }


        [MaxLength(13)]
        [Required]
        public string Mobile { get; set; }


        [Display(Name = "Phone Number")]
        [MaxLength(13)]
        [Required]
        public string? PhoneNumber { get; set; }


        [Range(50,250)]
        [Required]
        public int Height { get; set; }


        [Range(50, 150)]
        [Required]
        public int Weight { get; set; }
    }
}
