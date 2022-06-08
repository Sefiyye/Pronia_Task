using System.ComponentModel.DataAnnotations;

namespace Pronia_start.ViewModels
{
    public class RegisterVM
    {
        [Required,StringLength(maximumLength:15)]
        public string Firstname { get; set; }
        public object FirstName { get; internal set; }
        [Required,StringLength(maximumLength:20)]
        public string Lastname { get; set; }
        public object LastName { get; internal set; }
        [Required, StringLength(maximumLength: 15)]
        public string Username { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public bool Conditions { get; set; }
    }
}
