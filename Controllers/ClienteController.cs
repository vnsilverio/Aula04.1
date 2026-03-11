using Microsoft.AspNetCore.Mvc;

namespace Aula04._1.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
