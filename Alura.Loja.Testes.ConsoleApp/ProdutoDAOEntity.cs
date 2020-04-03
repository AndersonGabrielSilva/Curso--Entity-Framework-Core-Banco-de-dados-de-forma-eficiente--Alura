﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexto;
        public ProdutoDAOEntity()
        {
            contexto = new LojaContext();//Criando uma instancia LojaContext
        }
        public void Adicionar(Produto p)
        {
            contexto.Produtos.Add(p);
            contexto.SaveChanges();
        }
        public void Atualizar(Produto p)
        {
            contexto.Update(p);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
        public IList<Produto> Produtos()
        {
            //IList<Produto> produtos = contexto.Produtos.ToList();
            //contexto.SaveChanges();
            //return produtos;
            //Ou melhor
            return contexto.Produtos.ToList();
        }
        public void Remover(Produto p)
        {
            contexto.Produtos.Remove(p);
            contexto.SaveChanges();
        }
    }
}