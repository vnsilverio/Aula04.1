using Microsoft.AspNetCore.Mvc;

namespace Aula04._1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult CadastroProduto()
        {
            return View();
        }
    }
}
