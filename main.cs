using System;

class Program
{
    public static void Main(string[] args)
    {
        string Word;
        string PrevWord = "";
        do
        {
            Console.Write("Enter word: ");
            Word = Console.ReadLine();
            if (Word == "exit" || Word == "Exit") break;
            
            PrevWord = PrevWord + " " +Word;
            Console.WriteLine(PrevWord.Trim());
        } while (Word != "exit" && Word != "Exit");
        Console.WriteLine(" ");
        Console.WriteLine("Closing Program... ");
    }
}