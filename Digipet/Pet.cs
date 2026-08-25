namespace Digipet;

public class Pet : IStats
{
    string PetName;
    public static int HP;
    public static int ATK;
    public static int SPE;
    public static int CobatHP = HP; //temp HP for combat

    public static int PlusStat;

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
        string PetName = "";

        for (int i = 1; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine("give your pet a name");
            PetName = Console.ReadLine();
            Console.Clear();
            if (PetName != (""))
            {
                break;
            }
        }

        if (PetName == (""))
        {
            PetName = "titicaca frog";
            Console.WriteLine("your pets name is now " + PetName + "\n clik enter to contenyou");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("your pets name is now " + PetName);
            Console.Write("clik enter to contenyou");
            Console.ReadKey();
            Console.Clear();
        }
    }


    public void GiveStats()
    {
        while (LevelUp.Statpol >= 0)
        {
            int SelectedStat = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("you have " + LevelUp.Statpol + " Stat points and get 20 more per Level Up");
                Console.WriteLine("what stat do you want to increase ");
                Console.WriteLine("1.Health " + HP);
                Console.WriteLine("2.Speed " + SPE);
                Console.WriteLine("3.Attack " + ATK);
                if (int.TryParse(Console.ReadLine(), out SelectedStat))
                {
                    if (SelectedStat != 1 && SelectedStat != 2 && SelectedStat != 3)
                    {
                        Console.WriteLine("You have to entere a number between 1 and 3 ");
                    }

                    if (SelectedStat == 1 || SelectedStat == 2 || SelectedStat == 3)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }

            if (SelectedStat > 0 || SelectedStat < 3)
            {
                if (SelectedStat == 1)
                {
                    Console.WriteLine("how meni points do you want to use on HP numbers onli op to " + LevelUp.Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    HP += PlusStat;
                    LevelUp.Statpol -= PlusStat;
                    Console.Clear();

                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else if (SelectedStat == 2)
                {
                    Console.WriteLine("how meni points do you want to use on SPE numbers onli op to " + LevelUp.Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    SPE += PlusStat;
                    LevelUp.Statpol -= PlusStat;
                    Console.Clear();
                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else if (SelectedStat == 3)
                {
                    Console.WriteLine("how meni points do you want to use on ATK numbers onli op to " + LevelUp.Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    ATK += PlusStat;
                    LevelUp.Statpol -= PlusStat;
                    Console.Clear();
                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                    Console.ReadKey();
                }

                if (LevelUp.Statpol <= 0)
                {
                    break;
                }
            }

            {
            }
        }
    }
}