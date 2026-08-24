namespace Digipet;

class Program
{
    static void Main(string[] args)
    {
        string petName = "";
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine("give your pet a name");
            petName = Console.ReadLine();
            if (petName != (""))
            {
                break;
            }
        }

        if (petName == (""))
        {
            petName = "titicaca frog";
            Console.WriteLine("your pets name is now " + petName);
        }

    }
}