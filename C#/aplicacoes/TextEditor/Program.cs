using System;

namespace TextEditor // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar Arquivo");
            Console.WriteLine("0 - SAIR");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;

            }
        }
        static void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para abrir o arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
        static void EditFile()
        {
            Console.WriteLine("Digite seu texto abaixo. Pressione ESC para sair.");
            Console.WriteLine("-----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            SaveFile(text);
        }
        static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo.");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso.");
            Console.ReadKey();
            Menu();
        }

    }
}