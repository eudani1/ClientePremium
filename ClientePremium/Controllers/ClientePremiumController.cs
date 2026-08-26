using Microsoft.AspNetCore.Mvc;
using ClientePremium.Models;

namespace ClientePremium.Controllers
{
    public class ClientePremiumController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(ClientePremiumViewModel cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            return View("Sucesso", cliente);
        }
    }
}