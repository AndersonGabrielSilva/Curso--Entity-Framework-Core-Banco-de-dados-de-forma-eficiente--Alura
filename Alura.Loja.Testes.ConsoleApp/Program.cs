using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Alura.Loja.Testes.ConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            GerenciadorAulas();
                      

            Console.ReadKey();
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("=================================================");
            foreach (var e in entries)/*A variavel "e" remete ao nome de Estado*/
            {
                Console.WriteLine(e.Entity.ToString() + "-" + e.State);
            }
        }


    }
}
