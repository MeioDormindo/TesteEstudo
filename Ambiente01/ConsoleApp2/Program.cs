using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversao implicita int para float
            int a = 8;
            float b = a;

            Console.WriteLine("O valor de A é: "+ a + " do tipo: " +a.GetType());
            Console.WriteLine("O valor de B é: "+ b+ " do tipo: "+ b.GetType()) ;
            Console.ReadKey();

            // Conversao implicita float para int
            // float a1 = 8;
            // int b1 = a1;  da erro

            // Conversao explicita float para int

            float a1 = 8.9999f;
            int b1 = (int)a1; // sem arrendondamento
            Console.WriteLine("O valor de A1 é: " + a1 + " do tipo: " + a1.GetType());
            Console.WriteLine("O valor de B1 é: " + b1 + " do tipo: " + b1.GetType());
            Console.ReadKey();

            // Conversao por classes auxiliares
            float a2 = 8.9999f;
            int b2 = Convert.ToInt16(a2); // Arrendondamento 
            Console.WriteLine("O valor de A2 é: " + a2 + " do tipo: " + a2.GetType());
            Console.WriteLine("O valor de B2 é: " + b2 + " do tipo: " + b2.GetType());
            Console.ReadKey();


        }
    }
}
