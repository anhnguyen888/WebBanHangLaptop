using Microsoft.AspNetCore.Identity;

namespace WebBanHangLaptop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
