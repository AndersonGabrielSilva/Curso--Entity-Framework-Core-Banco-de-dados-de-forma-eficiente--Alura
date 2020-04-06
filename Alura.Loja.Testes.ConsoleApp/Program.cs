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
            //GravarUsandoEntity();            
            //RelacionamentoUmParaMuitos1N();
            var p1 = new Produto() { Nome = "Ovo de Pascoa Lacta", Categoria = "Doces", PrecoUnitario = 13.5, Unidade = "Gramas" };
            var p2 = new Produto() { Nome = "Barra de Chocolate", Categoria = "Doces", PrecoUnitario = 6.54, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Sabão em Pó", Categoria = "Limpeza", PrecoUnitario = 5.45, Unidade = "Quilos" } ;
            
            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Pascoa Feliz";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoPascoa.IncluiProduto(p1);
            promocaoPascoa.IncluiProduto(p2);
            promocaoPascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                //ontexto.Promocao.Add(promocaoPascoa);
                var promocao = contexto.Promocao.Find(1);//Informo a promoção que eu desejo recuperar

                contexto.Remove(promocao);
                ExibeEntries(contexto.ChangeTracker.Entries());

                
                contexto.SaveChanges();
            }
            

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
