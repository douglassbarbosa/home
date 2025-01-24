namespace DesafiosBaita;
class DesafioOne
{
    public static void CountChar()
    {
        var text = "";
        var NumCaracteres = 0;
        var NumPalavras = 0;

        Console.WriteLine("Digite um texto:");
        text = Console.ReadLine();

        if (!(text == null))
        {
            NumCaracteres = text.Length;
            NumPalavras = NumCaracteres > 0 ? text.Split(" ").Length : 0;

        }
        Console.WriteLine($"{NumCaracteres} caracteres, {NumPalavras} palavras");
        Console.ReadKey();
    }
}
