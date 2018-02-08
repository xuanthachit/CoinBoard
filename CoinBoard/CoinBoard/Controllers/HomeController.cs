using CoinBoard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoinBoard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITickerRepository tickerRepository;

        public HomeController(ITickerRepository tickerRepository)
        {
            this.tickerRepository = tickerRepository;
        }

        public ActionResult Index()
        {
            var results = this.tickerRepository.GetListTicker();
            return View(results);
        }
    }
}