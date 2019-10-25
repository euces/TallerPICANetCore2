using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPICANetCore.Auth
{
    public class DapperUsersTable
    {        
        public DapperUsersTable()
        {            
        }

        #region createuser
        public async Task<IdentityResult> CreateAsync(ApplicationUser user)
        {
            if (user.UserName.Equals("eulices") )
            {
                return IdentityResult.Success;
            }
            return IdentityResult.Failed(new IdentityError { Description = $"Could not insert user {user.Email}." });
        }
        #endregion

        public async Task<IdentityResult> DeleteAsync(ApplicationUser user)
        {            

            if (user.UserName.Equals("eulices"))
            {
                return IdentityResult.Success;
            }
            return IdentityResult.Failed(new IdentityError { Description = $"Could not delete user {user.Email}." });
        }


        public async Task<ApplicationUser> FindByIdAsync(Guid userId)
        {
            return new ApplicationUser() { UserName = "eulices" };
        }


        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            return new ApplicationUser() { UserName = "eulices" };
        }
    }
}