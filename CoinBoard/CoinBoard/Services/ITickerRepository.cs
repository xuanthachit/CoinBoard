using CoinBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinBoard.Services
{
    public interface ITickerRepository
    {
        Task<IEnumerable<TickerViewModel>> GetListTicker();

        TickerViewModel Get(string Id);
    }
}
