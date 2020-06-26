namespace Interfaces
{
    public interface ICarrinho
    {
         //tudo oq for feito nessa interface obriga a classe que vai herdar impletar todos os metodos e estruturas daq


         void Listar();

         void Cadastrar(Produto produto);

         void Alterar ( int _codigo, Produto produto);

         void Deletar(Produto produto);


    }
}