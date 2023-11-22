    using Microsoft.AspNetCore.Identity;
    using Market.Shared.Entities;
    using global::Market.Shared.Entities;

namespace OrganizacionEventos.API.Helpers

{
    public interface IUserHelper
        {
            Task<User> GetUserAsync(string email);

            Task<IdentityResult> AddUserAsync(User user, string password);

            Task CheckRoleAsync(string roleName);

            Task AddUserToRoleAsync(User user, string roleName);

            Task<bool> IsUserInRoleAsync(User user, string roleName);
        }
    }

