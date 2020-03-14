using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
        private const string PATH = "Database/Agendamento.csv";

        public AgendamentoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Evento agendamento)
        {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            agendamento.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] {FazerRegistroCSV(agendamento)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        public List<Evento> ObterTodosPorCliente(string emailCliente)
        {
            var agendamentos = ObterTodos();
            List<Evento> agendamentosCliente = new List<Evento>();

            foreach (var evento in agendamentos)
            {
                if(evento.Cliente.Email.Equals(emailCliente))
                {
                    agendamentosCliente.Add(evento);
                }
            }
            return agendamentosCliente;
        }

        public List<Evento> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Evento> agendamentos = new List<Evento>();
            foreach (var linha in linhas)
            {
                Evento agendamento = new Evento();
                agendamento.Planos = new Planos();
                agendamento.Cliente = new Cliente();

                agendamento.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                agendamento.Status = uint.Parse(ExtrairValorDoCampo("status", linha));
                agendamento.Cliente.Nome = ExtrairValorDoCampo("nome", linha);
                agendamento.Cliente.Cpf = ExtrairValorDoCampo("cpf", linha);
                agendamento.Cliente.Email = ExtrairValorDoCampo("email", linha);
                agendamento.Cliente.Telefone = ExtrairValorDoCampo("telefone", linha);
                agendamento.NomeEvento = ExtrairValorDoCampo("evento_nome", linha);
                agendamento.TipoEvento = ExtrairValorDoCampo("evento_tipo", linha);
                agendamento.StatusEvento = ExtrairValorDoCampo("evento_status", linha);
                agendamento.Planos.Nome = ExtrairValorDoCampo("planos", linha);
                agendamento.Planos.Preco = double.Parse(ExtrairValorDoCampo("preco_plano", linha));
                agendamento.NumeroPessoas = ExtrairValorDoCampo("numero_pessoas", linha);
                agendamento.DataEvento = DateTime.Parse(ExtrairValorDoCampo("data_evento", linha));
                agendamento.HoraInicio = ExtrairValorDoCampo("hora_inicio", linha);
                agendamento.HoraTermino = ExtrairValorDoCampo("hora_termino", linha);
                agendamento.Descricao = ExtrairValorDoCampo("descricao", linha);
                agendamento.NomePropietario = ExtrairValorDoCampo("nome_proprietario", linha);
                agendamento.NumeroCartao = ExtrairValorDoCampo("numero_cartao", linha);
                agendamento.Cvv = ExtrairValorDoCampo("cvv", linha);
                agendamento.DataValidade = DateTime.Parse(ExtrairValorDoCampo("data_validade", linha));
                agendamento.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));

                agendamentos.Add(agendamento);
            }
            return agendamentos;
        }

        public Evento ObterPor(ulong id)
        {
            var agendamentosTotais = ObterTodos();
            
            foreach (var agendamento in agendamentosTotais)
            {
                if(id.Equals(agendamento.Id))
                {
                    return agendamento;
                }
            }
            return null;
        }

        public bool Atualizar(Evento agendamento)
        {
            var agendamentosTotais = File.ReadAllLines(PATH);
            var agendamentosCSV = FazerRegistroCSV(agendamento);
            var linhaAgendamento = -1;
            var resultado = false;

            for(int i = 0; i < agendamentosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", agendamentosTotais[i]));
                if(agendamento.Id.Equals(idConvertido))
                {
                    linhaAgendamento = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                agendamentosTotais[linhaAgendamento] = agendamentosCSV;
                File.WriteAllLines(PATH,agendamentosTotais);
            }
            return resultado;
        }

        public string FazerRegistroCSV(Evento agendamento)
        {
            Evento a = agendamento;
            Cliente c = agendamento.Cliente;
            Planos p = agendamento.Planos;

            return $"id={a.Id};status={a.Status};nome={c.Nome};cpf={c.Cpf};email={c.Email};telefone={c.Telefone};evento_nome={a.NomeEvento};evento_tipo={a.TipoEvento};evento_status={a.StatusEvento};planos={p.Nome};preco_plano={p.Preco};numero_pessoas={a.NumeroPessoas};data_evento={a.DataEvento};hora_inicio={a.HoraInicio};hora_termino={a.HoraTermino};descricao={a.Descricao};nome_proprietario={a.NomePropietario};numero_cartao={a.NumeroCartao};cvv={a.Cvv};data_validade={a.DataValidade};preco_total={a.PrecoTotal}";
        }
    }
}