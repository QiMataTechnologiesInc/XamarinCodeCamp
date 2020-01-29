using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AtlantaCodeCampMobile.Services
{
    public abstract class CachedService<T> : BaseService
    {
        private IEnumerable<T> _cache;

        protected abstract Task<bool> CheckForUpdateAsync(CancellationToken cancellationToken);

        protected abstract Task<IEnumerable<T>> GetFromServerAsync(CancellationToken cancellationToken);

        public async Task<IEnumerable<T>> GetItemAsync(CancellationToken cancellationToken)
        {
            if (await CheckForUpdateAsync(cancellationToken))
            {
                _cache = await GetFromServerAsync(cancellationToken);
            }

            return _cache;
        }
    }
}