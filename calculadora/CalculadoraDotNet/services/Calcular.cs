using System;

class Calcular : ICalcular
{
 public double resultado;
 // somar
 public double Somar(double valor1, double valor2)
 {
  return resultado = valor1 + valor2;
 }
 // Subtrair
 public double Subtrair(double valor1, double valor2)
 {
  return resultado = valor1 - valor2;
 }
 //Multiplicar
 public double Multiplicar(double valor1, double valor2)
 {
  return resultado = valor1 * valor2;
 }
 // Divisão 
 public double Dividir(double valor1, double valor2)
 {
  if (valor2 != 0)
  {
   return resultado = valor1 / valor2;
  }
  else
  {
   Console.WriteLine("Não é possível efetuar divisão por Zero. Tente novamente.");
   return resultado = 0;
  }
 }
 public Calcular()
 {

 }
}