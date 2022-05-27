using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine("Comparador de Números");
           int num1 = 0;
           int aux1 = 0;
           for(int contador = 1; contador <= 5; contador++)
           {
               Console.Write("Digite um Número:");
               num1 = int.Parse(Console.ReadLine());
               if (num1 > aux1 )
               {
                   aux1 = num1;
               }
           }
           Console.WriteLine("O maior Número foi: " + aux1);
           Console.ReadLine();
        }
    }
}