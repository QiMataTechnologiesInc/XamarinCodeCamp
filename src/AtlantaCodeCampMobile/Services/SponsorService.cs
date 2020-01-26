using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Models.AtlantaCodeCampMobile.Models;

namespace AtlantaCodeCampMobile.Services
{
    public class SponsorService : BaseService
    {
        public async Task<IEnumerable<Sponsor>> GetSponsorsAsync(CancellationToken cancellationToken)
        {
            return Sponsor.FromJson(await Client.GetStringAsync(BaseUrl + "api/sponsors/"));
        }
    }
}