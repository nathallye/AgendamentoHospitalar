using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    public class HospitaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
