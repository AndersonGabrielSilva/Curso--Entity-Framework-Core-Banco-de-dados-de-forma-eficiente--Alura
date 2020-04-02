using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class AlterandoObjetod_Update
    {
        /*Alterando objetos com Entity
         * 
         * Para realizar uma atualização em meu banco de dados é utilizado o metodo UPDATE
         * é por ele onde é possivel atualizar um objeto em meu banco de dados
         * Exemplo: 
            1º Passo é criar a instancia onde está o contexto do Banco de Dados.
            2º infomar o metodo de busca do objeto (Registro/Tupla) será Atualizado.
                -First = Retorna o primeiro registro.
                -FirstOrDefault = Caso retorna varios registros, retorna somente o primeiro.
                -Find = Retorna somente um registro / Seu parametro será a chave primaria da tabela
                        Ex: Em um cadastro de pessoa, caso o cpf for a PK como parametro eu informo a PK.
                -Where = Retorna 1 ou mais registros de acordo com o parametro.
        
                ALGUNS EXEMPLOS:
                **Relembrando: [=>] é uma Expressão Lambda --→ Explicação ao final do arquivo
                
                var funcionarios = contexto.Fincionarios.FirstOrDefault(funcionario => funcionario.codigo == 1) → retorna 1 registro
                var funcionarios = contexto.Fincionarios.Find(1) → retorna 1 registro
                var funcionarios = contexto.Fincionarios.where(funcionario => funcionario.codigo == 1) → retorna 1 registro ou + registros
                
            3º Por meio do metodo Update passar por parametro o objeto atualizado.
            4º Salvo as alteraçoes no Banco de Dados
                                
                                 private static void AtualizarProduto()
                                 {
                                  //Atualizar o produto
                                  //Escolher apenas 1 produto.
                     1º------------→ using (var repo = new LojaContext())
                                     {
                     2º---------------→ Produto primeiro = repo.Produtos.First();
                       2.1------------→ primeiro.Nome = ("Anderson editou - ");
                     3º---------------→ repo.Produtos.Update(primeiro);
                     4º---------------→ repo.SaveChanges();
                                     }
                                  }

        EXPRESSÃO LAMBDA: 
         Uma expressão Lambda é uma função anônima que você pode usar para criar Delegates ou tipos
         de árvores de Expressão. São particularmente muito úteis para escrever consultas LINQ.
         O símbolo “=>” é o operador Lambda, também conhecido como vai para (goes to), e toda expressão 
         precisa dele. Ao criar uma você, devem-se colocar os parâmetros a esquerda do operador
         (caso haja parâmetros) e do outro lado do bloco coloca-se a expressão ou instrução do. 
         Esse tipo de expressão pode ser atribuído a Delegates.

        LINQ = Language Integrated Query (Consulta Integrada ao Idioma)
        Uma consulta é uma expressão que recupera dados de uma fonte de dados.
        O principal intuito da sua criação foi ter uma linguagem declarativa disponível 
        para o .NET e de certa forma substituir o SQL.
         */

    }
}
