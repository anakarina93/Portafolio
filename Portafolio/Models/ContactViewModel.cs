using System.ComponentModel.DataAnnotations;

namespace Portafolio.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your message")]

        public string Message { get; set; }
    }
}
