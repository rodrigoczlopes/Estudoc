using System;

namespace _8_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            bool grupo = true;
            bool acompanhado = quantidadePessoas > 1;

            if (idadeJoao >= 18 || acompanhado )
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
               
                Console.WriteLine("Não pode entrar!");
                

            }
            Console.WriteLine("Tecle enter para fechar...");
            Console.ReadLine();
        }
    }
}
