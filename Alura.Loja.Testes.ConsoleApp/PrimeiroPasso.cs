using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class PrimeiroPasso
    {
        /*PRIMEIRO PASSO:
            -O primeiro passo é a criação de uma classe que irá representar e permitir que todas
            as classes devem ser persistidas não apenas uma classe.
            obs:Antes do Entity era necessario escrever uma classe para cada objeto que devera persistir.
            -Bem, e esta classe no Entity, ela possui um contexto da Aplicação. Ela ira representar o
            contexto daquele modelo de negocio. Por exemplo: 
            Neste meu modelo de negocio a aplicação será para uma loja ou sera o nome desta classe irá
            Representar este negocio. 
            Exemplo:
                            public class Loja...
                            {
                            }

            Por convenção estas classes de contexto devem levar a palavra "Context" noao final.
                          
                            public class LojaContext
                            {                          
                            }
        
            A classe precisa realizar 3 coisas, para ser possivel o uso do Entity

            1º Permitir que ela ultilize dentro dela a API do Entity
                -Para fazer isto é necessario herdar de uma classe chamada "DbContext" que existe no
                namespace "Microsoft.EntityFramework.Core".
                          
                            public class LojaContext : DbContext
                            {                          
                            }
            
            2º Qual a classe ou quais classes que serão persistidas pelo Entity?
            -O que seria persistir em um banco?
                -É somente uma maneira bonita de diser que os dados se perderão no momento do desligamento da maquina
            -Para informar a classe que desejamos persistir é necessario criar uma propriedade do tipo DbSet<>.
            Exemplo:                           
                            
                            public class LojaContext : DbContext
                            {
                                public DbSet<Produto> Produtos { get; set; }
                            }
            -Eu desejo persistir no banco de dados a classe do tipo "Produto".
            -O nome da propriedade deve ser o mesmo da tabela lá em meu banco de dados neste exemplo
                o nome está "Produtos" pois lá no banco de dados existe uma tabela com este nome.
            -O que o Entity faz é pegar a classe e armazenar ela diretamento no banco de dados.

            3º Qual sera o Banco de Dados e onde ele esta localizado?
            -Esta ação é realizada em um evento da classe "Context" no evento de "Configuração".
            -Para execultar está ação iremos "sobreescrever" um metodo da classe "DbContext".
                
                Metodo que iremos Sobreescrever → OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                -Este Metodo recebe como argumento um DbContextOptionsBuilder no qual dentro dele
                há um metodo UseSqlServer(), que iremos informar o local do Banco de Dados.

                            public class LojaContext : DbContext
                            {
                                 public DbSet<Produto> Produtos { get; set; }

                                 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    Metodo do                    {
    DbContextOptionsBuilder--------→ optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
    para adicionar               }
    o banco                 }

        Metodo UseSqlServer: É nele que é informado o local onde esta o SQL Server Banco de dados 

         */

    }
}
