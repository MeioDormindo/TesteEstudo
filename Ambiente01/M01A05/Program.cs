using System;

namespace M01A05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            Console.WriteLine("A variavel \"N\" possui o valor: " + n);
            Console.WriteLine("N é do tipo " + n.GetType());
            Console.WriteLine();
            byte a = 255;
            Console.WriteLine("A variavel \"A\" possui o valor: " + a);
            Console.WriteLine("A é do tipo " + a.GetType());
            Console.WriteLine();
            var nome = "Siryus";
            Console.WriteLine("A variavel \"Nome\" possui o valor: " + nome);
            Console.WriteLine("Nome é do tipo " + a.GetType());
            Console.ReadKey();
            

            byte idade = 25;
            ushort publico = 45_239;
            float media = 4.5F;
            decimal estrela = 4.123456789M;
            bool aprovado = false;

            const float pi = 3.1415f;
            Console.WriteLine("O valor de pi em float é: "+ pi);
            Console.WriteLine("O valor de pi em biblioteca math é: " + Math.PI);
            Console.ReadKey();



        }
    }
}
