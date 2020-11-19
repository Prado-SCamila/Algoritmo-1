using System;

namespace Algoritmo_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite um número inteiro de 0 a 10.");
            int num = int.Parse(Console.ReadLine());

            while(num<0 || num>10){
            Console.WriteLine("Número inválido");
            Console.WriteLine("Digite um número entre 0 e 10.");
            num = int.Parse(Console.ReadLine());
            
            }

        }
    }

}