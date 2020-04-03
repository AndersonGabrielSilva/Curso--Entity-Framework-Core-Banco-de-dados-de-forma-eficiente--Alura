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
                var produtos = contexto.Produtos.ToList();/*Gerando uma lista com meus registros no banco*/
                foreach (var p in produtos)/*Exibindo lista*/
                {
                    Console.WriteLine(p);
                }


                var p1 = produtos.First();/*Me retorne o Primeiro da Lista*/
                p1.Nome = "A Pedra Filosofal";/*Alterando valor */

                var listaEntradas = contexto.ChangeTracker.Entries();/*Retorna todas as entradas deste contexto*/
                foreach (var e in listaEntradas)/*A variavel "e" remete ao nome de Estado*/
                {
                    Console.WriteLine(e.State);
                }

                contexto.SaveChanges();

                Console.WriteLine("=================================================");

                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("=================================================");

                foreach (var e in listaEntradas)/*A variavel "e" remete ao nome de Estado*/
                {
                    Console.WriteLine(e.State);
                }

            }
        }
    }
}
