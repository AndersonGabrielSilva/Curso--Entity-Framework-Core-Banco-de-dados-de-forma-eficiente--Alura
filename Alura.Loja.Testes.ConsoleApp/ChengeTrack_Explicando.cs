using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ChengeTrack_Explicando
    {
        /*CHANGE TRACK : Rastreador de Mudanças
         * Iremos aprender como o Entity gerencia os objetos que ele persiste no banco. 
         * Toda alteração que é feita na lista que o Contexto retorna é persistida no banco.
         * E como isto acontece? Como o Entity sabe quando deve dar o comando INSERT ou DELETE e etc.
         *  -Toda classe de contexto herda de uma clase do Entity com o nome de "DbContext" como já aprendemos,
         *  e está classe é a base de toda a API do Entity.
         *  -Esta clase "DbContext" possui um metodo que é responsavem por rastrear todas as mudanças que estão sendo realizadas 
         *  na instancia do contexto atual. Esta classe se chama "ChangeTracker"
         * ChangeTracker: Responsavel por rastrear todas as alteraçoes que ocorre na instancia. Dentro dela á um metodo
         * com o nome de "Entries".(Entradas)
         * 
         * ENTRIES: Entradas
         * Registra todas as entradas (Manipulaçoes) que acontece na lista.
         * O Metodo "Entries" pertence a classe "EntityEntry"
         * 
         * ENTITY ENTRY:
         * Está classe possui uma propriedade com o nome de "State"(Estado), que registra as mudanças realizadas
         * na instancia da lista. De forma que quando chamamos o metodo "SaveChenges" ele verifica se há algum
         * status nesta lista alterado e se sim realiza os comandos de CRUD.
         * 
         * STATE: Estado
         * É a propriedade que pertence a classe "EntityEntry" que armazena o estado de cada objeto.
         *  -Unchenged: Inalterada
         *  -Modified: Modificada
         *  
         *  Sintaxe: 
         *                  Retorna o rastrador de mudanças em forma de List 
         *                  var listaEntradas = contexto.ChangeTracker.Entries();
                                
                            foreach (var e in listaEntradas)A variavel "e" remete ao nome de Estado
                            {
                                Console.WriteLine(e.State); -→ Exibe as mudanças
                            }
         
         */
    }
}
