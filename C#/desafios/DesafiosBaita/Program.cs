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


        static void DesafioTwo()
        {
            Console.Clear();
            double altura = 0.00f;
            double peso = 0.00f;
            double massaCorporal = 0.00f;
            double imc = 0.00f;

            Console.WriteLine("Informe sua altura (com vírgula): ");
            altura = Double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double CalculaIndice(double altura, double peso)
            {
                return massaCorporal = peso / (altura * altura);
            }

            (string classificacao, string risco) StatusIMC(double imc)
            {
                if (imc < 16) return ("Magreza Grau III", "N/A");
                if (imc < 17) return ("Magreza Grau II", "N/A");
                if (imc < 18.5) return ("Magreza Grau I", "N/A");
                if (imc < 25) return ("Eutrofia", "N/A");
                if (imc < 30) return ("Sobrepeso", "Aumentado");
                if (imc < 35) return ("Obesidade Grau I", "Moderado");
                if (imc <= 40) return ("Obesidade Grau II", "Grave");
                return ("Obesidade Grau III", "Muito Grave");
            }

            imc = CalculaIndice(altura, peso);
            (var classificacao, var risco) = StatusIMC(imc);
            Console.WriteLine($"O IMC calculado para a altura de {string.Format("{0:N}", altura)}m e o peso de {peso}kg é:");
            Console.WriteLine("");
            Console.WriteLine($"Seu IMC é {string.Format("{0:N}", imc)} kg/m²");
            Console.WriteLine($"Classificação: {classificacao}");
            Console.WriteLine($"Risco: {risco}");

            Console.ReadKey();
            MenuDesafios();
        }
        static void DesafioTree()
        {
            Console.Clear();
            decimal etanol = 0;
            decimal gasolina = 0;
            decimal indiceCalculado = 0;


            Console.WriteLine("APLICAÇÃO PARA ESCOLHER QUAL CONBUSTÍVEL ABASTECER. ");
            Console.WriteLine("");
            Console.WriteLine("Informe o valor do Etanol: ");
            etanol = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da Gasolina: ");
            gasolina = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");

            decimal CalculaIndice(decimal etanol, decimal gasolina)
            {
                return (etanol / gasolina);
            }

            indiceCalculado = CalculaIndice(etanol, gasolina);
            if (indiceCalculado >= 0.75m)
            {
                Console.WriteLine($"Abasteça com Gasolina");
                Console.ReadKey();
                MenuDesafios();
            }
            Console.WriteLine($"Abasteça com Etanol");

            Console.ReadKey();
            MenuDesafios();
        }

        static void MenuDesafios()
        {
            Console.Clear();
            Console.WriteLine("1. Desafio 1");
            Console.WriteLine("2. Desafio 2");
            Console.WriteLine("3. Desafio 3");
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
                case 2: DesafioTwo(); break;
                case 3: DesafioTree(); break;
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