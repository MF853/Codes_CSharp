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
           int cont = 2;
           int x = int.Parse(Console.ReadLine());
           while(x >= cont)
           {
           	if(cont == x)
           	{
           		Console.WriteLine("O Número é Primo.");
           		break;
           	}
           	else if(x % cont == 0)
           	{
           		Console.WriteLine("O Número não é Primo.");
           		break;
           	}
           	cont++;
           }
        }
    }
}