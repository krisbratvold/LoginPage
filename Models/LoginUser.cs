using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPage.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = "is required")]
        [EmailAddress]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "is required")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}