namespace Digipet;

public class Meny
{
    public string Onkeypres;

    public bool GameOver = false;
    public void meny()
    {
        Pet pet = new Pet(this);
        pet.GiveName();
        pet.SAttack();
        pet.SHealth();
        pet.SSpeed();
        pet.GiveStats();
        while (GameOver == false)
        {
            Console.WriteLine("to inter combat pres e");
            Console.WriteLine("to clene " + pet.PetName + " pres c");
            Console.WriteLine("to pet " + pet.PetName + " pres p");
            Console.WriteLine("to fete " + pet.PetName + " pres f");
            Console.WriteLine("to se age " + pet.PetName + " pres a");
            Onkeypres = Console.ReadLine();
            if (Onkeypres == "e")
            {
               
                Combat combat = new Combat();
                combat.InCombat(pet ,this);
            }
            else if (Onkeypres == "c")
            {
                pet.ClenThePet();
            }
            else if (Onkeypres == "p")
            {
                pet.PetThePet();
            }
            else if (Onkeypres == "f")
            {
                pet.FetPhePet();
            }
            else if (Onkeypres == "a")
            {
                Console.WriteLine(pet.Age);
            }
        }
    }
}