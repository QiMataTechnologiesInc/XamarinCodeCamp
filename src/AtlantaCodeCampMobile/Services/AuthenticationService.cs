using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models.AccountViewModels;

namespace AtlantaCodeCampMobile.Services
{
    public class AuthenticationService : BaseService
    {
        public AuthenticationService()
        {
        }

        public bool IsAuthenticated { get; }

        public async Task<bool> Login(LoginViewModel loginViewModel)
        {
            var response = await Client.PostAsync(BaseUrl + "/login",
                new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>(nameof(LoginViewModel.Email), loginViewModel.Email),
                    new KeyValuePair<string, string>(nameof(LoginViewModel.Password), loginViewModel.Password)
                }));

            response.EnsureSuccessStatusCode();

            return true;
        }
    }
}
