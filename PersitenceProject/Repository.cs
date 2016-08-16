using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceProject
{
    /*Persistência dos objetos informados nos formulários, será feito uso de coleções. 
     *Desta maneira, os dados existirão apenas enquanto a aplicação estiver em execução.
     *Mais a frente iremos substituir pelo acesso ao banco de dados*/
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();

        private IList<Produto> produtos = new List<Produto>();

        private IList<NotaEntrada> notasEntrada = new List<NotaEntrada>();

        /*****Método que adiciona fornecedores em um lista.*/
        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }

        //Método que remove fornecedores em uma lista.
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        //Método que lista todos os fornecedores.
        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }

        //Método que atualiza os dados de fornecedor.
        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }


        /*****Método que adiciona produtos em uma lista.*/
        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }

        //Método que remove Produto em uma lista.
        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }

        //Método que lista todos os fornecedores.
        public IList<Produto> GetAllProdutos()
        {
            return this.produtos;
        }

        //Método que atualiza os dados de fornecedor.
        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }


        /*****Método que adiciona NotasEntrada em uma lista.*/
        public NotaEntrada InsertNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Add(notaEntrada);
            return notaEntrada;
        }

        //Método que remove Produto em uma lista.
        public void RemoveNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada.Remove(notaEntrada);
        }

        //Método que lista todos os fornecedores.
        public IList<NotaEntrada> GetAllNotaEntrada()
        {
            return this.notasEntrada;
        }

        //Método que atualiza os dados de fornecedor.
        public NotaEntrada UpdateNotaEntrada(NotaEntrada notaEntrada)
        {
            this.notasEntrada[this.notasEntrada.IndexOf(notaEntrada)] = notaEntrada;
            return notaEntrada;
        }

    }
}
