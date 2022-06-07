using Microsoft.AspNetCore.Identity;

namespace Pronia_start.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; internal set; }
    }
}
