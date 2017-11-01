
namespace src.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var tpViewModel = new TpViewModel("Grupo 12", DateTime.Now, 9);
            return View(tpViewModel);
        }

    }
}
