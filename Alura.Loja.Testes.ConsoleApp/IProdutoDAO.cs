using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        /*Está Interface possui as 4 açoes do CRUD*/
        void Adicionar(Produto p);//Create → INSERT
        void Atualizar(Produto p);//UPDATE
        void Remover(Produto p);//DELETE
        IList<Produto> Produtos();//Read → SELECT

    }
}
