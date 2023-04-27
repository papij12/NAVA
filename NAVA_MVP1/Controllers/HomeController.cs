using static DataLibrary.BusinessLogic.UserProcessor;
using Microsoft.AspNetCore.Mvc;
using NAVA_MVP1.Models;
using System.Diagnostics;


namespace NAVA_MVP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Register(UsersModel usersModel)
        //{
        //    if(ModelState.IsValid)
        //    {
        //      int recordsCreated =  CreateUser(usersModel.UserID,
        //            usersModel.UserEmail,
        //            usersModel.UserName);

        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}