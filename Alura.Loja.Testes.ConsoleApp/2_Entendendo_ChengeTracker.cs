using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    partial class Program
    {
        static void TestaChengeTracker()
        {
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var produtos = contexto.Produtos.ToList();
                ExibeEntries(contexto.ChangeTracker.Entries());
                
                 var novoProduto = new Produto()/*adicionando novo ´produto para poder observar a propriedade added*/ 
                {
                    Nome = "sabão em pó",
                    Categoria = "limpeza",
                    PrecoUnitario = 2.99
                };
                contexto.Produtos.Add(novoProduto);
                ExibeEntries(contexto.ChangeTracker.Entries());

                var p1 = produtos.Last();
                contexto.Produtos.Remove(p1);
                ExibeEntries(contexto.ChangeTracker.Entries());

                //contexto.SaveChanges();

                var entry = contexto.Entry(novoProduto);
                Console.WriteLine(entry.Entity.ToString() + "-" + entry.State);               
                
                 //ExibeEntries(contexto.ChangeTracker.Entries());
            }


        }

       
    }
}
