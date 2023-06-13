using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    class Program
    {
        static void Main(string[] args)
        {


            Random sorteador = new Random();
            int numero;
            int sorteio = sorteador.Next(1,11);
            

            Console.WriteLine("Bem-vindo a Conradito Jogos\n");
            Console.WriteLine("Adivinhe o número de 1 até 10");
            Console.WriteLine("Digite o número:");
            numero = int.Parse(Console.ReadLine());
            //Simbolo &&==> E => As duas condições devem ser satisfeitas
            //Simbolo ||==> OU =>apenas uma das duas devem ser satifeitas
            if (numero >10 || numero <1)
            {
                Console.WriteLine("Digite um valor válido");
                Main(null);
                return;
            }
            if (numero == sorteio)
            {
                Console.WriteLine("Parabéns , você acertou o número e ganhou!");
            }
            else
            {
                Console.WriteLine("Que pena , você errou! Tente novaamente...");
                Main(null);
                return;
            }
                Console.WriteLine("Parabéns,você digitou corretamente");
                Console.ReadKey();





        }
    
    }      
}              
