using System.IO;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;

namespace RoleTopMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[] {FazerRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public Cliente ObterPor(string email)
        {
            var linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                if(ExtrairValorDoCampo("email", item).Equals(email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    c.Nome = ExtrairValorDoCampo("nome", item);
                    c.Cpf = ExtrairValorDoCampo("cpf", item);
                    c.Email = ExtrairValorDoCampo("email", item);
                    c.Senha = ExtrairValorDoCampo("senha", item);
                    c.Telefone = ExtrairValorDoCampo("telefone", item);
                    //c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", item));
                    //c.DataNascismento = DateTime.Parse(ExtrairValorDoCampo("data_nascismento", item));
                    //c.Endereco = ExtrairValorDoCampo("endereco", item);

                    return c;
                }
            }
            return null;
        }   

        public string FazerRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};cpf={cliente.Cpf};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone}";
        }
    }
}