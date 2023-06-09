using System;

class URI
{

    static void Main(string[] args)
    {
        double raio, area;
        double pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        area = (raio * raio) * pi;
        Console.WriteLine($"A={area:F4}");

    }

}