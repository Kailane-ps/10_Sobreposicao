using System;

namespace _10_Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Mario:");
            Mario mario = new Mario();
            mario.correr();
            mario.pular();
            Console.ResetColor();
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Luigi:");
            Luigi luigi = new Luigi();
            luigi.correr();
            luigi.pular();
            Console.ResetColor();
            
        }
    }
}
