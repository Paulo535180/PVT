using Microsoft.AspNetCore.Mvc;

namespace PVT.UI.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        
    }
}
