using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class InterfaceProdutoDAO
    {
        /*
         Com o uso de interface, conseguimos deixar nosso codigo mais limpo e elegante.
         1º Eu analiso se existe uma ou mais classes que ultilizam os mesmos metodos se sim, criamos
         uma interface com estes metodos criando assim um contrato.

        Com a interface em união com uma classe expecifica, torna o codigo muito mais legivel e de facil compreenção
        por exemplo:
        Os eventos de CRUD em nosso banco de dados foi abstraido pela classe ProdutoDAO Entity, de certa forma que quando o 
        desenvolvedor for inserir algum objeto no banco ele somente chama esta classe e informa o objeto que deseja adicionar.
        sem se preoculpar com o local aonde o banco de dados está, ou qual é o contexto. Ele não faz a minima ideia disto.
        pois a Classe ProdutoDAO abstraiu estas açoes.
        Dica:

        Começe a separar cada ação, evento... por classes.Como por exemplo a classe LojaContexto
        nela está somente o contexto do banco de dados. Ou seja o local do Banco, o nome, o nome das tabelas e etc.
        Na Classe ProdutoDAOEntity está todos os eventos de CRUD que serão realizadas no banco, na Tabela de Produtos,
        nesta classe está todas as açoes e metodos que o contexto (LojaContext) utiliza para realizar estas açoes.
        Ou seja, com apenas o chamar de 1 metodo é realizado todo o processo de INSERT, UPDATE, SELEC e DELETE. Sem se
        preocupar com o processo em si. 
         */

    }
}
