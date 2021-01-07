using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PVT.Domain.Models;
using System.Threading.Tasks;

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
