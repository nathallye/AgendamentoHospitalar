using Microsoft.AspNetCore.Mvc;

namespace AgendamentoHospitalar.Controllers
{
    public class AgendamentoConfiguracaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
