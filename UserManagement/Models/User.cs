using Microsoft.AspNetCore.Identity;

namespace UserManagement.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
