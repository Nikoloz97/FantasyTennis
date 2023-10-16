using Microsoft.AspNetCore.Mvc;

namespace FantasyTennis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    };
}