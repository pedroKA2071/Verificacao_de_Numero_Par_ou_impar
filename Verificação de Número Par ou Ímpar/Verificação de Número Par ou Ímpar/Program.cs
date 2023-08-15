using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_Número_Par_ou_Ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float  num ;

            Console.WriteLine("Selecione o numero que deseja para a verificação: ");

            num = float.Parse(Console.ReadLine());

            
          

            if ( num % 2 == 0)
            {

                Console.WriteLine("ele é par:");

            }else 
            {
                Console.WriteLine("Ele é impar:");
            
            }

            Console.ReadKey();  

        }
    }
}
