using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace OrganizacionEventos.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            
            var anonimous = new ClaimsIdentity();
            var oapUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("FirstName", "Manuela"),
            new Claim("LastName", "Medina"),
            new Claim(ClaimTypes.Name, "manuelamedina@yopmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
        },
        authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(oapUser)));

        }
    }
}

