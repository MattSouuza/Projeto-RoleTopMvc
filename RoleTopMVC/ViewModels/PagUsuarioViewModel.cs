using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class PagUsuarioViewModel : BaseViewModel
    {
        public List<Evento> Eventos {get;set;}
        public List<Planos> Planos {get;set;}
    }
}