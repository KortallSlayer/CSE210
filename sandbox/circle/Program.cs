using System;

class Program
{
    static void Main(string[] args)
    {
        circle myCircle = new circle();

        myCircle.setRadius(10);
    
        double area = myCircle.GetArea();
        
        Console.WriteLine(area);

    }   
}
