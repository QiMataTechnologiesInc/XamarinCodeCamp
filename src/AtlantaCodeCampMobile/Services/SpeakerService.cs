using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models;

namespace AtlantaCodeCampMobile.Services
{
    public class SpeakerService : BaseService
    {
        public SpeakerService()
        {
        }

        public async Task<IEnumerable<Speaker>> GetSpeakersAsync()
        {
            return Speaker.FromJson(await Client.GetStringAsync(BaseUrl + "api/speakers/"));
        }
    }
}
