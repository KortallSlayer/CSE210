class Menu
{
    public int ProcessMenu()
    {
        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("please select one.");
            Console.WriteLine("1. Write.");
            Console.WriteLine("2. Display.");
            Console.WriteLine("3. Load.");
            Console.WriteLine("4. Save.");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}