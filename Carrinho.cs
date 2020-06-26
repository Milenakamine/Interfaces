using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Carrinho : ICarrinho
    {

        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();

        public void Alterar( int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;

        }

        public void Cadastrar(Produto produto)
        {
           carrinho.Add(produto);

        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
            foreach(Produto p in carrinho){
            System.Console.WriteLine($"{p.Nome} - R${p.Preco}.");
            }
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"O valor total da sua compra é R${ValorTotal}. ");
            }else{
                Console.WriteLine($"Faça compras!! Seu carrinho esta vazio.");
            }
    }
    }
}