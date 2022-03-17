using carfully_web_coremvc.Helper;
using carfully_web_coremvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace carfully_web_coremvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            DbHelper dbHelper = new DbHelper();
            var x = dbHelper.QueryToTableOnlyConnectionString(_configuration.GetConnectionString("DefaultConnection"), "select * from AspNetUsers");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            DbHelper dbHelper = new DbHelper();
            dbHelper.QueryToTableOnlyConnectionString(_configuration.GetConnectionString("DefaultConnection"), "INSERT INTO RegisteredUser (FirstName, LastName, Phone, Email) VALUES ('" + model.FirstName + "','" + model.LastName + "','" + model.Phone + "','" + model.Email + "')");

            return View();
        }

        public IActionResult SuccessPage()
        {
            return View();
        }

        public IActionResult ErrorPage()
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