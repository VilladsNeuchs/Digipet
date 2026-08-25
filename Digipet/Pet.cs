namespace Digipet;

public class Pet : IStats
{
    string name;
    int HP;
    int ATK;
    int SPE;

    public void SHealth()
    {
        HP = 1;
    }

    public void SAttack()
    {
        ATK = 1;
    }

    public void SSpeed()
    {
        SPE = 1;
    }


    public void GiveName()
    {
        string petName = "";

        for (int i = 1; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine("give your pet a name");
            petName = Console.ReadLine();
            Console.Clear();
            if (petName != (""))
            {
                break;
            }
        }

        if (petName == (""))
        {
            petName = "titicaca frog";
            Console.WriteLine("your pets name is now " + petName + "\n clik enter to contenyou");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("your pets name is now " + petName);
            Console.Write("clik enter to contenyou");
            Console.ReadKey();
        }

        name = petName;
    }


    public void GiveStats()
    {
        while (LevelUp.Statpol >=0)
        {
            Console.WriteLine("you have 20 Stat points and get 20 more per Level Up");
            Console.WriteLine("1.Health " + HP);
            Console.WriteLine("2.Speed " + SPE);
            Console.WriteLine("3.Attack " + ATK);
            int SelectedStat = 0;
            SelectedStat = Convert.ToInt32(Console.ReadLine());
            if (SelectedStat <= 0 || SelectedStat > 3)
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.Clear();
                    Console.Write("You have to entere a number between 1 and 3 ");
                    Console.Clear();
                    if (SelectedStat >= 0 || SelectedStat < 3)
                    {
                        break;
                    }
                }

                if (SelectedStat == 1)
                {
                    Console.Write("how meni points do you want to use on HP numbers onli op to = statpol");
                    Console.ReadLine();
                }
                else if (SelectedStat == 2)
                {
                }
                else if (SelectedStat == 3)
                {
                }
            }

            {
            }
        }
    }
}