using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Número Primo()
    {
    	   int cont = 2;
           int x = int.Parse(Console.ReadLine());
           while(x >= cont)
           {
           	if(cont == x)
           	Console.WriteLine("O Número é Primo.");
           if(x % cont == 0)
           {
           	Console.WriteLine("O Número não é Primo.");
           }
           else
           {
           	cont++;
           }
        }
        Console.ReadLine();
    }
}