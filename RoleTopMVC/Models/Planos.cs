namespace RoleTopMVC.Models
{
    public class Planos
    {
        public string Nome {get;set;}
        public double Preco {get;set;}

        public Planos()
        {

        }
        
        public Planos (string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}