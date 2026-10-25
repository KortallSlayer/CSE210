using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("moses", 1, 39,
            "behold this is my work and my glory to bring to pass the immortality and eternal life of man.");
        string response = "";
        while(response != "quit")
        {
            // Word myWord = new Word("Secret");

            // myWord.Display();
            // myWord.Hide();
            // Console.WriteLine();
            // myWord.Display();
            Console.Clear();
            
            myScripture.showScripture();
            myScripture.hideWord();
            Console.WriteLine("\npress enter to continue or type 'quit' to exit");
            response = Console.ReadLine();
        }
    }
}