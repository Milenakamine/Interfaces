using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Seu carrinho pessoal contém:");
            Produto produtoa = new Produto("Iphone", 1, 45625f);
            Produto produtob = new Produto("Motorola", 2, 23656565f);
            Produto produtoc = new Produto("Samsung", 3, 32598f);
            Produto produtod = new Produto("Xiaomi",4, 659856f);

            Carrinho carrinho = new Carrinho();
            carrinho.Cadastrar(produtoa);
            carrinho.Cadastrar(produtob);
            carrinho.Cadastrar(produtoc);
            carrinho.Cadastrar(produtod);
            

            carrinho.Listar();
            carrinho.MostrarTotal();
        }
    }
}
