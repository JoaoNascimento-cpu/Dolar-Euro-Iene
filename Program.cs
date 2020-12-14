using System;
using DolarEuroLibra.Classes;
namespace Dolar__Euro__Libra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(1));
            Console.WriteLine(Conversor.RealParaDolar(3));
        }
    }
}
