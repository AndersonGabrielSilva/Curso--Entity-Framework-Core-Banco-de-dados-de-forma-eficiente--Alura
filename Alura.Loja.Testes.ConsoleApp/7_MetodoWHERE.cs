using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    partial class Program
    {
        static void MetodoWhere()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Promoção Janeiro Feliz";
                promocao.DataInicio = new DateTime(2020, 1, 1);
                promocao.DataTermino = new DateTime(2020, 1, 31);

                //Me retorne da Tabela Produto todos que contem o nome Bebidas no campo Categoria
                var produtos = contexto
                                .Produtos
                                .Where(p => p.Categoria == "Doces")
                                .ToList();
                foreach (var produto in produtos)
                {
                    promocao.IncluiProduto(produto);
                }

                contexto.Promocoes.Add(promocao);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }
    }
}
