using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models;
using Newtonsoft.Json;

namespace AtlantaCodeCampMobile.Services
{
    public class SessionService : BaseService
    {

        public async Task<IEnumerable<TalkDTO>> GetTalkDTOs()
        {
            var response = await Client.GetAsync(BaseUrl + "api/talks/");

            response.EnsureSuccessStatusCode();

            return TalkDTO.FromJson(await response.Content.ReadAsStringAsync());
        }
    }
}
