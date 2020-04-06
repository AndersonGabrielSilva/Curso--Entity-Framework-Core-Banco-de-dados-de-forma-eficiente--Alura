using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    partial class Program
    {
        /*Ao executar o codigo abaixo será criado no Banco de Dados o registo da compra e o registro do produto
         pois o entity ele entende que ao adicionar um regristro da classe compra é necessario armazenar um registro da classe 
         produtos tambem, ele entende isto por conta da maneira que modelamos a classe Compra.
         Para o Entity realizar o relacionamento da classe Compra, sera necessario criar uma propriedade
         referenciando ela lá no contexto.*/
        public static void RelacionamentoUmParaMuitos1N()
        {
            var paoFrances = new Produto();
            paoFrances.Nome = "Pão Francês";
            paoFrances.PrecoUnitario = 0.40;
            paoFrances.Unidade = "Unidade";
            paoFrances.Categoria = "Padaria";


            var compra = new Compra();
            compra.Quantidade = 6;
            compra.Produto = paoFrances;
            compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }


    }
}
