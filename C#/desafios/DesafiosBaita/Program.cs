using System;

namespace DesafiosBaita
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuDesafios();
        }

        static void DesafioOne()
        {
            Console.Clear();
            var textoEstrada = "";
            var numCaracteres = 0;
            var numPalavras = 0;

            Console.WriteLine("Digite um texto:");
            textoEstrada = Console.ReadLine();

            if (string.IsNullOrEmpty(textoEstrada))
            {
                Console.WriteLine("Nenhum texto digitado, encerrando a aplicação.");
                Console.ReadKey();
                MenuDesafios();
            }
            numCaracteres = textoEstrada.Length;

            string[] palavras = textoEstrada.Split(new Char[] { '.', '?', '!', ' ', ';', ':', ',', '%', '$', '@', '*', '#', '-', '_', '+', '=' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in palavras)
            {
                numPalavras++;
            }

            Console.WriteLine($"{numCaracteres} caracteres, {numPalavras} palavras");
            Console.ReadKey();
            MenuDesafios();
        }
        static void MenuDesafios()
        {
            Console.Clear();
            Console.WriteLine("1. Desafio 1");
            // Console.WriteLine("2. Desafio ");
            // Console.WriteLine("3. Desafio ");
            // Console.WriteLine("4. Desafio ");
            Console.WriteLine("0. Sair");
            Console.WriteLine("");
            Console.WriteLine(" ----------- ");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice: ");

            short choice = short.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: DesafioOne(); break;
                // case 2: ; break;
                // case 3: ; break;
                // case 4: ; break;
                // case 5: ; break;
                // case 6: ; break;
                case 0: System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Opção inválida. Escolha outra Opção!");
                    break;
            }

        }
    }

}