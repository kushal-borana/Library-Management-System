using Microsoft.AspNetCore.Mvc;

namespace LMSS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
