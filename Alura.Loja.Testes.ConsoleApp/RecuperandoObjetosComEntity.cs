using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class RecuperandoObjetosComEntity
    {
        /*Conceito de CRUD
         * CRUD : São as quatro operaçoes basicas udada em um Banco de Dados
         * 
         * C = Create: Criação
         * R = Read: Consulta
         * U = Update: Atualização
         * D =  Delete: Destruição
         * 
         * Para recuperar os dados é necessario dar um comando SELECT no banco. Mais como
         * o Entity realiza este comando?
         * 
         * Bem, para realizar está função iremos seguir o mesmo padrão de Adicionar um objeto.
         * 
         * 1º Cria uma variavel que recebera uma instancia do contexto aonde o banco esta.
         * 2º Cria uma lista que recebera o repositorio que está no mando
         *  Exemplo abaixo:
         *  -Cria uma lista do tipo "Produto" e chame esta lista de produtos
         *  -Esta lista irá receber o repositorio da tabele (Objeto) "Produtos" e converta 
         *  para uma Lista. Ou seja me devolva em forma de uma lista. 
         *  
         *     
                             using (var repo = new LojaContext())
                             {
                                 IList<Produto> produtos = repo.Produtos.ToList();
                                 foreach(var item in produtos)
                                 {
                                     Console.WriteLine(item.Nome);
                                 }
                             }
         
         * -Desta forma é possivel manipular os elementos que estavam no banco pois agora ele foi
         * convertido para uma lista. E sendo assim é possivel eu exibir atraves de um foreach e 
         * Console.WriteLine();
         */

    }
}
