using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models;
using Newtonsoft.Json;

namespace AtlantaCodeCampMobile.Services
{
    public class SessionService : CachedService<TalkDTO>
    {
        protected override Task<bool> CheckForUpdateAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected override async Task<IEnumerable<TalkDTO>> GetFromServerAsync(CancellationToken cancellationToken)
        {
            ThrowIfNoInternet();
            
            var response = await Client.GetAsync(BaseUrl + "api/talks/", cancellationToken);

            response.EnsureSuccessStatusCode();

            return TalkDTO.FromJson(await response.Content.ReadAsStringAsync());
        }
    }
}
