using System;

namespace Operatorler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (x, y, z) toplamının mod 3' ü kaçtır?
            int x = 10, y = 20, z = 27;

            int sonuc = (x + y + z) % 3;

            Console.WriteLine("Sonuç :" + sonuc);
            
        }
    }
}
