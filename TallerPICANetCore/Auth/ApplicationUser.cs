using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPICANetCore.Auth
{
    public class ApplicationUser : IAuthorizationRequirement
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; internal set; }
    }
}
