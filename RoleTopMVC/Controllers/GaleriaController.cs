using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Galeria";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}