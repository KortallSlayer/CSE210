using System;

class Program
{
    static void Main(string[] args)
    {
        string grade;
        Console.WriteLine("what grade did you get in this class? ");
        grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        if (numGrade >= 90)
        {
            Console.WriteLine("you got an A");
        }
        else if (numGrade >= 80)
        {
            Console.WriteLine("you got a B");
        }
        else if (numGrade >= 70)
        {
            Console.WriteLine("you got a C");
        }
        else if (numGrade >= 60)
        {
            Console.WriteLine("you got a D");
        }
        else
        {
            Console.WriteLine("you got an F");
        }
        if (numGrade >= 70)
        {
            Console.WriteLine("congradulations you passed");
        }
        else
        {
            Console.WriteLine("you failed, better luck next time");
        }
    }
}