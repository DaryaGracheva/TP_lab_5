using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using лаба2.Models;

namespace лаба2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string id, DateTime data, string adress_sender, string adress_recipient, string weight, string price, string delivery_method)
        {
            string authData = $"Посылка оформлена!  " +
                $"ID: {id}  Дата заказа: {data}  Откуда: {adress_sender} Куда: {adress_recipient} Вес посылки (кг): {weight} Ценность посылки (руб.): {price}  Способ доставки: {Convert.ToString(delivery_method)} ";
            return Content(authData);
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