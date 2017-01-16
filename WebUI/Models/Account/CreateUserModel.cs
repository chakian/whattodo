using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.Account
{
    public class CreateUserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        [Required(ErrorMessage ="Olmaz")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}