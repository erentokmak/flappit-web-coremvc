using carfully_web_coremvc.Helper;
using carfully_web_coremvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Mail;

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

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("flappitdemail@gmail.com");
            //
            ePosta.To.Add("flappitdemail@gmail.com");
            //ePosta.To.Add("eposta2@gmail.com");
            //ePosta.To.Add("eposta3@gmail.com");
            //
            //
            ePosta.Subject = "Name: " + model.Name + ", Website: " + model.Website;
            //
            ePosta.Body = "Name: " + model.Name + "<br/>" + "Website: " + model.Website + "<br/>" + "Email: " + model.Email + "<br/>" + "Phone: " + model.Phone + "<br/>" + "Message: " + model.Message;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("flappitdemail@gmail.com", "Bismillah1*+");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            ePosta.IsBodyHtml = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                return RedirectToAction("SuccessPage");
            }
            catch (SmtpException)
            {
                return RedirectToAction("ErrorPage");
            }
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            DbHelper dbHelper = new DbHelper();
            try
            {
                dbHelper.QueryToTableOnlyConnectionString(_configuration.GetConnectionString("DefaultConnection"), "INSERT INTO RegisteredUser (FirstName, LastName, Phone, Email) VALUES ('" + model.FirstName + "','" + model.LastName + "','" + model.Phone + "','" + model.Email + "')");

                return RedirectToAction("SuccessPage");
            }
            catch (System.Exception)
            {
                return RedirectToAction("ErrorPage");
            }
        }

        public IActionResult SuccessPage()
        {
            return View();
        }

        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult Impressum()
        {
            return View();
        }

        public IActionResult Datenschutzerklärung()
        {
            return View();
        }

        public IActionResult AGB()
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