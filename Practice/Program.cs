using Practice.Objects;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printer printer = new Printer("hello",3);
            //Console.WriteLine(printer.Value);
            //printer.Value = "Isaschar";
            //Console.WriteLine(printer.Value);  
            Printer printer2 = new Printer(3);
            printer2.Number = -22;
            Console.WriteLine(printer2.Number);
            Console.WriteLine("----------------");
            printer2.Number = 42;
            Console.WriteLine(printer2.Number);
            Console.WriteLine("----------------");

        }
    }
}
