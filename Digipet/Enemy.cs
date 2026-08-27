using System.Diagnostics;

namespace Digipet;

public class Enemy(Pet pet) : IStats
{
    public string EnemyName;
    public  int EHP;
    public  int EATK;
    public  int ESPE;
    public  int EnemyType;
    public int CobatEHP;

    public void SHealth()
    {
        EHP = 0;
        CobatEHP = EHP;
    }

    public void SAttack()
    {
        EATK = 0;
    }

    public void SSpeed()
    {
        ESPE = 0;
    }

    public void MakeEnemyType()
    {
     EnemyType = RNG.Range(1, 7);

    switch(EnemyType)
    {
        case 1:
            EnemyName = "true mimic ";
            EHP += pet.HP;
            ESPE += pet.SPE;
            EATK += pet.ATK; 

            break;
        
        case 2:
            EnemyName = "incomplete mimic ";
            EHP +=  pet.HP;
            ESPE += pet.ATK;
            EATK += pet.SPE; 

            break;
        
        case 3:
            EnemyName = "incomplete mimic ";
            EHP += pet.SPE;
            ESPE += pet.HP ;
            EATK += pet.ATK; 

            break;
        
        case 4:
            EnemyName = "incomplete mimic ";
            EHP +=  pet.SPE;
            ESPE += pet.ATK;
            EATK += pet.HP; 

            break;
        
        case 5:
            EnemyName = "incomplete mimic ";
            EHP +=  pet.ATK;
            ESPE += pet.HP;
            EATK += pet.SPE; 

            break;
        
        case 6:
            EnemyName = "incomplete mimic ";
            EHP += pet.ATK;
            ESPE += pet.SPE;
            EATK += pet.HP; 

            break;
        
            
    }
    Console.WriteLine(EnemyName);
    Console.WriteLine("Health " + EHP);
    Console.WriteLine("Speed " + ESPE);
    Console.WriteLine("Attack " + EATK);
    }

    public void InvokeTheEvent()
    {
        OnEnemyDeath.Invoke(this, pet);
    }


    public event Action<Enemy, Pet> OnEnemyDeath;
}