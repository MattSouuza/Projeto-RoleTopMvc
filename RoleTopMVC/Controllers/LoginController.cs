//**Arrumar o Login! */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class LoginController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PlanosRepository planosRepository = new PlanosRepository();
        private AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public RespostaViewModel respostaViewModel = new RespostaViewModel();
        public IActionResult Index()        //** TODO: Mudar Index para Login*/
        {
            ViewData["NomeView"] = "Login";
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Login(IFormCollection form)
        {
            ViewData["NomeView"] = "SucessoErro";
            ViewData["TextoView"] = "Cadastro";
            try
            {
                System.Console.WriteLine("===================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("===================");
                var usuario = form["email"];
                var senha = form["senha"];
                
                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TipoUsuario.ADMINISTRADOR:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL,usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME,cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO,cliente.TipoUsuario.ToString());
                            return RedirectToAction("Dashboard","Adm");
                            
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL,usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME,cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO,cliente.TipoUsuario.ToString());
                            return RedirectToAction("PagUsuario","Login");
                        }
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModel("Email incorreto"));
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("Usuário não existe"));
            }
        }

        public IActionResult PagUsuario()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var agendamentosCliente = agendamentoRepository.ObterTodosPorCliente(emailCliente);

            ViewData["NomeView"] = "PagUsuario";
            var Planos = planosRepository.ObterTodos();
            return View(new PagUsuarioViewModel()
            {
                Planos = Planos,
                Eventos = agendamentosCliente,
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Info()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var cliente = clienteRepository.ObterPor(emailCliente);
            List<Cliente> infoCliente = new List<Cliente>();
            infoCliente.Add(cliente);

            ViewData["NomeView"] = "Info";
            return View(new InfoViewModel()
            {
                Clientes = infoCliente,
                UsuarioEmail = ObterUsuarioEmailSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
                
            return RedirectToAction("Index", "Home");
        }
    }
}