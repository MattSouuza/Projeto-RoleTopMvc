using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CalendarioController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Calendario";
            var agendamento = agendamentoRepository.ObterTodos();
            
            return View(new DashboardViewModel()
            {
                AgendamentoVerificados = agendamento,
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}