using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}
