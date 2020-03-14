namespace RoleTopMVC.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Cpf {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Telefone {get;set;}
        public uint TipoUsuario {get;set;}

        public Cliente()
        {
            this.TipoUsuario = 1;
        }

        // public Cliente(string nome, string cpf, string email, string telefone)
        // {
        //     this.Nome = nome;
        //     this.Cpf = cpf;
        //     this.Email = email;
        //     this.Telefone = telefone;
        // }

        // public Cliente(string nome, string cpf, string email, string senha, string telefone)
        // {
        //     this.Nome = nome;
        //     this.Cpf = cpf;
        //     this.Email = email;
        //     this.Senha = senha;
        //     this.Telefone = telefone;
        // }
    }
}