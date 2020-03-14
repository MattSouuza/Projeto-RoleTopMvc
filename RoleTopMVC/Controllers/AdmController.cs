using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdmController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public IActionResult Dashboard()
        {
            ViewData["NomeView"] = "Dashboard";
            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && (uint) TipoUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))
            {
                var pedidos = agendamentoRepository.ObterTodos();
                DashboardViewModel dashboardViewModel = new DashboardViewModel();

                foreach (var pedido in pedidos)
                {
                    switch (pedido.Status)
                    {
                        case (uint) StatusAgendamento.APROVADO:
                            dashboardViewModel.AgendamentoAprovados++;
                            dashboardViewModel.AgendamentoVerificados.Add(pedido);
                            // dashboardViewModel.AgendamentosCalen.Add(pedido);
                        break;

                        case (uint) StatusAgendamento.REPROVADO:
                            dashboardViewModel.AgendamentoReprovados++;
                            dashboardViewModel.AgendamentoVerificados.Add(pedido);
                        break;

                        default:
                            dashboardViewModel.AgendamentoPendentes++;
                            dashboardViewModel.Eventos.Add(pedido);
                        break;
                    }
                }
                dashboardViewModel.UsuarioEmail = ObterUsuarioEmailSession();

                return View(dashboardViewModel);
            } else {
                return View ("Erro", new RespostaViewModel("Você não tem permissão para acessar a Dashboard"));
            }
        }
    }
}