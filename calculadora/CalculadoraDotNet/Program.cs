using System;

namespace CalculadoraDotNet
{
 class Program
 {
  static void Main(string[] args)
  {
   // Console.WriteLine("Hello World!");
   Calcular calc = new Calcular();
   double result = calc.Somar(1, 10);
   Console.WriteLine("\n " + result);

   result = calc.Subtrair(30, 8);
   Console.WriteLine("\n " + result);

   result = calc.Multiplicar(8, 3);
   Console.WriteLine("\n " + result);

   result = calc.Dividir(100, 4);
   Console.WriteLine("\n " + result);
  }
 }
}
