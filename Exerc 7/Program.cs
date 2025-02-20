using System.Drawing;
using System.Text;

namespace Exerc_7
{
    internal class Program
    {
            /*Faça um algoritmo que o usuário escreva o nome e o preço de seis
            produtos e assim que terminar de escrever o ultimo produto, mostre o
            nome e o valor do produto mais barato */
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos voce quer cadastrar?");
            int nmrCadastro = Convert.ToInt16(Console.ReadLine());
            string produtomenor;
            double menorPreco;
            for (int i = 0; i < nmrCadastro; i++)
            {
                Console.WriteLine("produto a ser cadastrado");
                string name_produto = Console.ReadLine()!;

                Console.WriteLine("Valor do produto cadastrado");
                double preco_produto = Convert.ToDouble(Console.ReadLine());

                produtomenor += name_produto;
                menorPreco += preco_produto;
                
            }
        }
    }
}
3