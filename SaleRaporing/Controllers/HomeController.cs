using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using SaleRaporing.Core.Service;
using SaleRaporing.DataAccess;
using SaleRaporing.DataAccess.Model;
using SaleRaporing.Models;
using System;
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



        [HttpGet]
        public IActionResult Index()
        { 
            using(MongoRepository<rpacollection> mongoRepository = new MongoRepository<rpacollection>()){
                ViewModel model = new ViewModel();
                model.SaleRaporing = _saleRaporingService.GetSaleRaporingModels().Result;
                model.RpaCollection = mongoRepository.GetAll();
                return View(model);
            }
        }





      
        public IActionResult ExcelDownload(DateTime createDate )
        {
            const string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=utf-8";
            
            using (MongoRepository<rpacollection> mongoRepository = new MongoRepository<rpacollection>())
            {
                var bHour= BsonDateTime.Create(createDate.AddHours(3));
                var file = mongoRepository.Get(x=>x.CreateDate.Equals(bHour));
                 return File(file.FileContent, contentType, file.FileName);
            }
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
