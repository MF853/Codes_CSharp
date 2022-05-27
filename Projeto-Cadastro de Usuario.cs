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
           Console.WriteLine("Digite seu nome:");
           string a;
           a = Console.ReadLine();
           Console.WriteLine("Digite seu telefone");
           string b;
           b = Console.ReadLine();
           Console.WriteLine("Digite o ano do seu nascimento:");
           string c = Console.ReadLine();
           int x = 2019;
           int y = Int32.Parse(c);
           int z = x-y;
           Console.WriteLine("Olá " + a);
           Console.WriteLine("Confira se as informações abaixo estão Corretas:");
           Console.WriteLine("Telefone:" +b);
           Console.WriteLine("Idade: Aproximadamente " + z + " anos.");
           Console.WriteLine("Se estiver tudo correto digite Sim, e se algo estiver errado digite Não: ");
           string m = Console.ReadLine();
           if(m == "Sim" || m == "sim"){
           Console.WriteLine("Usuário Cadastrado!");}
           else if(m == "Não" || m == "não" || m == "nao"){
           Console.WriteLine("Erro será reportado!");
           Console.ReadLine();
           }
        }
    }
}