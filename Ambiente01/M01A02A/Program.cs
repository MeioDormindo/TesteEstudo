using System;

namespace M01A02A
{
    class Program
    {
        /// <summary>
        /// Métdo principal para execução automatica
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           /*Testes Básicos DE
            * C* para aprender
            * O Básico do Básico
            */
            Console.SetCursorPosition(50, 1);// Lugar que aparece o os dados no console  
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Oi,");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Tudo");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("bem?");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Cyan;
          
            Console.WriteLine("C# é\n\"Super\"\nFácil!\a");
            Console.ReadKey();
        }
    }
}
