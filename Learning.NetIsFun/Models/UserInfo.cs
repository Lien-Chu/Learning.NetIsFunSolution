using Microsoft.AspNetCore.Identity;

namespace Learning.NetIsFun.Models
{
    public class UserInfo : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
}
