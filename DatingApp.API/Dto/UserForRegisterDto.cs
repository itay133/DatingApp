using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dto
{
    public class UserForRegisterDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        [StringLength(8 , MinimumLength = 4 , ErrorMessage = "Password should be between 4 to 8")]
        public string password { get; set; }
    }
}