using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.Beep();
            Console.Clear();
            Console.WriteLine("Olá usuário, irei traduzir sua mensagem para Leet");
            Console.Write("\nDigite a mensagem a ser traduzida : ");
            texto = Console.ReadLine();

            texto = texto.Replace("a" , "4")
            .Replace("A" , "4")
            .Replace("e" , "3")
            .Replace("E" , "3")
            .Replace("i" , "1")
            .Replace("I" , "1")
            .Replace("l" , "1")
            .Replace("L" , "1")
            .Replace("o" , "0")
            .Replace("O" , "0")
            .Replace("t" , "7")
            .Replace("T" , "7")
            .Replace("s" , "5")
            .Replace("S" , "5");

            Console.Beep();
            Console.Beep();
            Console.WriteLine("\nSua mensagem traduzida em Leet é : ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(texto);
            Console.ResetColor();

        }
    }
}
