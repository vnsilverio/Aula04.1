using Microsoft.AspNetCore.Mvc;

namespace Aula04._1.Controllers
{
    public class FornecedorController : Controller
    {
        public IActionResult CadastroFornecedor()
        {
            return View();
        }
    }
}
