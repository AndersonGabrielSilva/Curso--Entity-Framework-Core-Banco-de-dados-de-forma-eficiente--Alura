using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class DeletandoObjetosComoEntity
    {
        /*DELETEANDO OBJETOS COM O ENTITY
         * 
         * Para deletar um objeto é a mesma logica de adicionar um objeto novo.
         * Reelembrando: 
         * Using: Ultilizamos quando queremos ter certeza que ao final de sua execuxão todos os recursos
         * sejam finalizados.
         
         * 1º passo é gerar uma instancia com meu contexto.
         * 2º Criar uma Lista com os objetos com a tabela informada tabela.
         * 3º Chamar o metodo .Remove() e informar o objeto que seja removido.
         * 4º Chamar o metodo SaveChanges() para salvar estes comandos em meu banco de dados.
         * No exemplo abaixo ultilizamos o Foreach para remover todos os objetos.
         
            using (var repo = new LojaContext())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                     repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
    */
    }
}
