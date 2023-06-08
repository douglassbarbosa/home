using System;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime + "s");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Contador finalizado!");
            Thread.Sleep(2500);

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Informe o tempo com uma das unidades abaixo:");
            Console.WriteLine("Para 10 segundos informe: 10s");
            Console.WriteLine("Para 10 minutos informe: 10m");
            Console.WriteLine("Para SAIR digite: 0");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja contar?");
            String data = Console.ReadLine();


            if (ValidaEntrada(data))
            {

                int time = int.Parse(data.Substring(0, data.Length - 1));
                char type = char.Parse(data.Substring(data.Length - 1, 1).ToLower());

                if (type.Equals('m'))
                {
                    Start(time * 60);
                    Console.WriteLine("");
                    Console.ReadKey();
                    Menu();
                }

                Start(time);
                Console.WriteLine("");
                Console.ReadKey();
                Menu();
            }
        }
        static bool ValidaEntrada(String entrada)
        {
            if (entrada.Length > 1)
            {
                char type = char.Parse(entrada.Substring(entrada.Length - 1, 1).ToLower());
                if ((type.Equals('s')) || (type.Equals('m')))
                {
                    return true;
                }
                Console.WriteLine("Formato não aceito. Siga o exemplo: 10s ou 10m");
                Thread.Sleep(1000);
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(2000);
                Menu();
            }
            if ((entrada == null) || (entrada.Contains('0')))
            {
                Console.WriteLine("Encerrando a aplicação...");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
            Console.WriteLine("Formato não aceito. Siga o exemplo: 10s ou 10m");
            Thread.Sleep(1000);
            Console.WriteLine("Reiniciando...");
            Thread.Sleep(2000);
            Menu();
            return false;
        }
    }
}