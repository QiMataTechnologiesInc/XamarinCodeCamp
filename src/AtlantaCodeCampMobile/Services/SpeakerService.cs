using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models;

namespace AtlantaCodeCampMobile.Services
{
    public class SpeakerService : BaseService
    {
        public async Task<IEnumerable<Speaker>> GetSpeakersAsync()
        {
            ThrowIfNoInternet();
            return Speaker.FromJson(await Client.GetStringAsync(BaseUrl + "api/speakers/"));
        }
    }
}
