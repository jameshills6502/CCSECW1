using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MotoMotoMotors
{ /*
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        public CustomAuthStateProvider(ILocalStorageService localstorage)
        {

        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new System.Security.Claims.ClaimsPrincipal());

            string username = await _localStorage.GetItemAsStringAsync("username");
            if(!string.IsNullOrEmpty(username)) 
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username)
                }, "test authentication type");
                
                state = new AuthenticationState(new ClaimsPrincipal (identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));

            return state;
        }
    }
    */
}
