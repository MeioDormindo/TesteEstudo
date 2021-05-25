using System;
using System.Threading;


namespace M01A09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, tudo bom? Qual o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Prazer em lhe conhecer " + nome) ;
            Thread.Sleep(2500);
            Console.WriteLine("Qual ano voce nasceu ?"); 

            int anoNasc = 0;
            int.TryParse(Console.ReadLine(), out anoNasc );
            int idade = DateTime.Now.Year - anoNasc;

            Console.WriteLine("Legal, entao voce tem " + idade+ " anos e nasceu em " + anoNasc);

            Random ger = new Random();
            int incricao = ger.Next(9999);

            Console.Write("O numero da sua inscrição é: ");
            Thread.Sleep(2500);
            Console.Write( incricao);
            Console.ReadKey();
            
        }
    }
}
