using System.Collections.Generic;
using System.Threading.Tasks;
using CoinBoard.Models;

namespace CoinBoard.Services
{
    public class TickerRepository : ITickerRepository
    {
        public TickerViewModel Get(string Id)
        {
            return null;
        }

        public async Task<IEnumerable<TickerViewModel>> GetListTicker()
        {
            var results = await APIProvider.APIProvider.Get<IEnumerable<TickerViewModel>>();
            return results;
        }
    }
}