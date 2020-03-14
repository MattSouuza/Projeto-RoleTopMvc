using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<Evento> AgendamentoVerificados {get;set;}
        public List<Evento> AgendamentosCalen {get;set;}
        public uint AgendamentoAprovados {get;set;}
        public uint AgendamentoReprovados {get;set;}
        public uint AgendamentoPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Eventos = new List<Evento>();
            this.AgendamentoVerificados = new List<Evento>();
            this.AgendamentosCalen = new List<Evento>();
        }
    }
}