using Microsoft.AspNetCore.Mvc;

namespace FantasyTennis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
