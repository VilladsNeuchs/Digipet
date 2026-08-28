
namespace Digipet;
public class Pet(Meny meny ) : IStats
{
    public string PetName;
    public  int HP;
    public  int ATK;
    public  int SPE;
    public int Statpol = 20;
    public  int PlusStat;
    public int CobatHP; //temp HP for combat
    public int hapines = 100;
    public int clenlines = 100;
    public int hunger = 100;
    public int Age = 0;

    
    public void SHealth()
    {
        HP = 1;
        CobatHP = HP;
    }

    public void SAttack()
    {
        ATK = 1;
    }

    public void SSpeed()
    {
        SPE = 1;
    }
    public void Hapines()
    {
         hapines = 100;
        Console.WriteLine("your pet have ben sadent in the fite clike p to pet it wen in meny");
        hapines -= 20;

        if (hapines == 0)
        {
            Console.WriteLine("your pet have lorst the while to live"); 
            meny.GameOver = true;
        }
    }

    public void PetThePet()
    {
        Console.WriteLine("your pet is hapin naw"); 
         hapines = 100;
        
    }
    public void Clenlines()
    {
         clenlines = 100;
        clenlines -= 20;
        Console.WriteLine("your pet have ben dortid in the fite clike c to clen wen in meny");
        if (clenlines == 0)
        {
            Console.WriteLine("your pet have diait of an infecion");
            meny.GameOver = true;
        }
    }
    public void ClenThePet()
    {
        Console.WriteLine("yor pet hav ben clend");
        clenlines = 100;
    }

    public void Huger()
    {
         
        
            hunger -= 20;
        Console.WriteLine("your pet got hungri form the fite clike c to clen wen in meny");
            if (hunger == 0)
            {
             Console.WriteLine("your pet have diait of hunger");
                 meny.GameOver = true;
            }
        
    }

    public void FetPhePet()
    {
             Console.WriteLine("your pet have ben fet");
        hunger = 100;
    }


    public void GiveName()
    {
        PetName= "";

        for ( int i = 1; i < 10; i++)
        {
            Console.WriteLine("give your pet a name");
            PetName = Console.ReadLine();
            Console.WriteLine("\n" +
                              "\n" +
                              "\n" +
                              "\n" +
                              "\n" +
                              "\n");
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
            
        }
    }

    public void Levelup()
    {
        Age += 1;
        Statpol = 20;
        if (Statpol == 20)
        {
            GiveStats();
        }
    }
                  
    public void GiveStats()
    {
        while (Statpol >= 0)
        {
            int SelectedStat = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("you have " + Statpol + " Stat points and get 20 more per Level Up");
                Console.WriteLine("what stat do you want to increase ");
                Console.WriteLine(" ");
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
                    Console.WriteLine("how meni points do you want to use on HP numbers onli op to " + Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    while (PlusStat > Statpol || PlusStat < 0)
                    {
                        if (PlusStat > Statpol)
                        {
                          Console.WriteLine("you dont have that meni stat points you have " + Statpol);  
                        }
                        else if (PlusStat < 0)
                        {
                            Console.WriteLine("you cant have les then 0 HP " ); 
                        }

                       int.TryParse(Console.ReadLine(), out PlusStat);
                    }

                    HP += PlusStat;
                    Statpol -= PlusStat;
                    Console.WriteLine("\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n");
                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else if (SelectedStat == 2)
                {
                    Console.WriteLine("how meni points do you want to use on SPE numbers onli op to " + Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    while (PlusStat > Statpol)
                    {
                        Console.WriteLine("you dont have that meni stat points you have " + Statpol); 
                        int.TryParse(Console.ReadLine(), out PlusStat);
                    }
                    SPE += PlusStat;
                    Statpol -= PlusStat;
                    Console.WriteLine("\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n" +
                                      "\n");                    
                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                    
                }
                else if (SelectedStat == 3)
                {
                    Console.WriteLine("how meni points do you want to use on ATK numbers onli op to " +Statpol);
                    int.TryParse(Console.ReadLine(), out PlusStat);
                    while (PlusStat > Statpol)
                    {
                        Console.WriteLine("you dont have that meni stat points you have " + Statpol); 
                        int.TryParse(Console.ReadLine(), out PlusStat);
                    }
                    ATK += PlusStat;
                    Statpol -= PlusStat;
                    Console.WriteLine(PetName);
                    Console.WriteLine("1.Health " + HP);
                    Console.WriteLine("2.Speed " + SPE);
                    Console.WriteLine("3.Attack " + ATK);
                    Console.WriteLine("");
                }

                if (Statpol <= 0)
                {
                    break;
                }
            }

            {
            }
        }
    }
}