using System.ComponentModel.DataAnnotations;

namespace SkillVertex_Learning_Portal.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Your Full Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [Display(Name = "Your Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Subject cannot be left empty")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please express your concern")]
        [Display(Name = "Your Message")]
        public string Message { get; set; }
    }
}
