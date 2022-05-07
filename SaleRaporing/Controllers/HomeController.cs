using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaleRaporing.Core.Service;
using SaleRaporing.Models;
using System.Collections.Generic;
using System.Diagnostics;


namespace SaleRaporing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISaleRaporingService _saleRaporingService;
        public HomeController(ISaleRaporingService saleRaporingService, ILogger<HomeController> logger)
        {
            this._saleRaporingService = saleRaporingService;
            _logger = logger;
        }

        public IActionResult Index()
        {

            var a = _saleRaporingService.GetSaleRaporingModels().Result;

            return View(a);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
