using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    partial class Program
    {
       
        static void RelacionamentoUmParaUm11()
        {
            var fulano = new Cliente();
            fulano.Nome = "Anderson Gabriel";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 1010,
                Logadouro = "Rua Sebastiao ponton",
                Complemento = "Casa",
                Bairro = "Dutra",
                Cidade = "Ribeirao preto"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }


        }

    }
}
