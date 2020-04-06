using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class RenalionamentoMuitosParaMuitos
    {
        /*RELACIONAMENTO N:N
         * Iremos aprender como fazer um relacionamento para uma "coleção de instancias"(Que nada mais é que Muitos Registros)
         * Como Por exemplo o relacionamento entre duas tabelas:
         * Promoção e Produto
         * Onde de um lado uma 
         *      - promoção pode conter varios produtos (Acesso a uma coleção de produtos) e um
         *      - produto pode estar em varias promoçoes (Acesso a uma coleção de promoçoes).
         * Para representar um relacionamento de Muitos para muitos é nescessario criar uma tabela que representara
         * este relacionamento no qual nela irá conter uma referencia para produtos e para promoção. Ou seja uma Tabela de Join
         * Como no exemplo abaixo ↓
         *                                      public class PromocaoProduto
                                                {                                                    
                                                    public int ProdutoId { get; set; }<-----Esta propriedade é criada para formar o Entity criar um campo NOT NULL
                                                    public int PromocaoId { get; set; }<-----Esta propriedade é criada para formar o Entity criar um campo NOT NULL
       Referencia atraves do Id para produtos------>public Produto Produto { get; set; }
       Referencia atraves do Id para Promoção------>public Promocao Promocao { get; set; }
                                                }
         * A Tabela a cima contem como chave primaria 2 campos, ou seja ela possui uma chave primaria composta.
         * Para informar isto para o entity, será necessario sobreescrever um metodo lá na Classe contexto, 
         * no qual iremos informar que esta tabela de "PromocaoProduto" possui uma chave composta.
         * Exemplo:
         * O nome do Metodo a ser sobreescrito é "OnModelCreating", ele recebe um objeto do tipo "ModelBuilder"
         * no qual contem um metodo com o nome de Entity<>(Entidade) que por meio dele informamos o nome da entidade
         * neste caso PromoçãoProduto.
         * Depois iremos chamar o Metodo "HastKey" que por meio dele iremos informar quais serao nosss chaves primarias
         * Observe o modelo abaixo:
         * 
         *                                        protected override void OnModelCreating(ModelBuilder modelBuilder)
                                                  {
                                                      modelBuilder
       Informa a tabela que irá ter a PK composta---> .Entity<PromocaoProduto>()
       Informa quais campos irão compor a PK--------> .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
                                                      base.OnModelCreating(modelBuilder);
                                                  }
         * Este metodo será execultado  toda vez que a instancia do contexto for instanciada.
         * 
         * Depois da tabela de JOIN ter sido criada iremos informar os produtos para que estarao na promoção
         * Mais antes disto é necessario criar uma propriedade que represente o produto na classe promoção e
         * tambem uma propriedade que representa promoção na tabela de produto.
         * Para isto, iremos criar uma lista de Produtos na Classe de Promoção que irá receber os produtos,
         * porem ao inves de criar diretamente a lista de produtos, iremos criar uma lista de PromoçãoProduto
         * para realizar o Join. 
         * Observe o Exemplo abaixo: 
         * 
         * 
         *                                     public class Promocao 
                                               {
                                                   public int Id { get; set; }
                                                   public string Descricao { get; internal set; }
                                                   public DateTime DataInicio { get; internal set; }
                                                   public DateTime DataTermino { get; internal set; }
           Exemplo 1-----------------------------> public IList<PromocaoProduto> Produto { get; internal set; }

                                                   public Promocao()
                                                   {
           Inicio ela no construtor------------------> Produto = new List<PromocaoProduto>();
                                                   }
                                                   
                                                   internal void IncluiProduto(Produto produto)
                                                   {
           Metodo para incluir o produto na Lista---->this.Produto.Add(new PromocaoProduto() { Produto = produto }) ;
                                                   }
                                               }


         
         */

    }
}
