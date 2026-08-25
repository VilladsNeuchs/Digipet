using System.Diagnostics;

namespace Digipet;

public class Enemy : IStats
{
    string EnemyName;
    public static int EHP;
    public static int EATK;
    public static int ESPE;
    public static int EnemyType;
    public static int CobatEHP = EHP;

    public void SHealth()
    {
        EHP = 0;
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
            EHP += Pet.HP;
            ESPE += Pet.SPE;
            EATK += Pet.ATK; 

            break;
        
        case 2:
            EnemyName = "incomplete mimic ";
            EHP += Pet.HP;
            ESPE += Pet.ATK;
            EATK += Pet.SPE; 

            break;
        
        case 3:
            EnemyName = "incomplete mimic ";
            EHP += Pet.SPE;
            ESPE += Pet.HP ;
            EATK += Pet.ATK; 

            break;
        
        case 4:
            EnemyName = "incomplete mimic ";
            EHP += Pet.SPE;
            ESPE += Pet.ATK;
            EATK += Pet.HP; 

            break;
        
        case 5:
            EnemyName = "incomplete mimic ";
            EHP += Pet.ATK;
            ESPE += Pet.HP;
            EATK += Pet.SPE; 

            break;
        
        case 6:
            EnemyName = "incomplete mimic ";
            EHP += Pet.ATK;
            ESPE += Pet.SPE;
            EATK += Pet.HP; 

            break;
        
            
    }
    Console.WriteLine(EnemyName);
    Console.WriteLine("Health " + EHP);
    Console.WriteLine("Speed " + ESPE);
    Console.WriteLine("Attack " + EATK);
    }



    void Cekeenemyalive()
    {
        if (EHP <= 0)
        {
            OnEnemyDeath.Invoke(this);
        }
    }

    public event Action<Enemy> OnEnemyDeath;
}