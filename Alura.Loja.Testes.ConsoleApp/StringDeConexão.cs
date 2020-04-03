using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class StringDeConexão
    {
        /*Entendendo uma String de Conexão
         * Basico:
         * 
         * Data Source = É o local onde está localizado meu banco de dados;
         
         * Database = Nome do Banco de dados;
         * ou↓
         * Initial Catalog= É o catalogo onde informo o nome do Banco de Dados
          
         * Integrated Security = Usuario sem senha. É utilizado a autenticação do Windows
         * User ID = Login do usuario
         * Password = Senha do usuario
          
         
         * Daqui para baixo é opcional ↓
          
         * Connect Timeout=30 →Tempo de tentativa de conexão, caso em 30 segundos não foi possivel realizar a conexão ele retorna um erro
         
         * Encrypt=False → Define se os dados serão ou criptografados, porem deixa a conexão mais lenta 
         
         * TrustServerCertificate=False → Referente ao certificado do servidor
         
         * ApplicationIntent=ReadWrite → Eu informo o que eu desejo fazer no banco de dados.
         *  -Read: Somente leitura / Somente consultas.
         *  -Write: Somente gravação / Somente comandos de insert e updates.
         *  -ReadWrite: Poderão ser realizadas consultas e gravaçoes em meu banco de dados.
          
         * 
         */
    }
}
