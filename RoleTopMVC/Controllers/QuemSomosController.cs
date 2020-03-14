using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class QuemSomosController : AbstractController
    {
        public IActionResult quemSomos()
        {
            ViewData["NomeView"] = "QuemSomos";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });        
        }
    }
}