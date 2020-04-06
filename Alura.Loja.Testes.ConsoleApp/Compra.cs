namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; set; }//Ao criar uma propriedade com o nome da Classe e com a Id na frente o entity entende que
                                          //Esta propriedade será uma FK, no qual será armasenado o ID da tabela produto.
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }
    }
}