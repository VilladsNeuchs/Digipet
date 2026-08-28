namespace Digipet;

public class Combat
{
   public int togofost = 0;
   public void InCombat(Pet pet,Meny meny )//, Enemy enemy)
   {
      Enemy enemy = new Enemy(pet);
      enemy.SAttack();
      enemy.SHealth();
      enemy.SSpeed();
      enemy.MakeEnemyType();
      
      Console.WriteLine(pet.PetName);
      Console.WriteLine("1.Health " + pet.HP);
      Console.WriteLine("2.Speed " + pet.SPE);
      Console.WriteLine("3.Attack " + pet.ATK);
      Console.WriteLine("");

      enemy.OnEnemyDeath += EnemyOnEnemyDeath;
      while (pet.CobatHP > 0 || enemy.CobatEHP > 0)
      {
         if (pet.SPE > enemy.ESPE)
         {
            enemy.CobatEHP -= pet.ATK;
            if (enemy.CobatEHP > 0 )
            {
               pet.CobatHP -= enemy.EATK;
 
            }
            else if (enemy.CobatEHP <= 0)
            {
               Console.WriteLine("you and " + pet.PetName + " have wone agenst " + enemy.EnemyName + " and whele LevelUp" );
               Console.WriteLine();
               enemy.InvokeTheEvent();    
            }
         }
         else if (enemy.ESPE > pet.SPE)
         {
               pet.CobatHP -= enemy.EATK;
               if (pet.CobatHP > 0 )
               {
                  enemy.CobatEHP -= pet.ATK;

               }
               else if (pet.CobatHP <= 0)
               {
                  Console.WriteLine("your pet has didet in battel  \n game over "); 

                 meny.GameOver = true;

               }
           
         }
         else if (enemy.ESPE == pet.SPE)
         {        
            togofost = RNG.Range(1, 3);
            if (togofost == 1)
            {
               enemy.CobatEHP -= pet.ATK;
               if (enemy.CobatEHP > 0 )
               {
                  pet.CobatHP -= enemy.EATK;
 
               }
               else if (enemy.CobatEHP <= 0)
               {
                  Console.WriteLine("you and " + pet.PetName + " have wone agenst " + enemy.EnemyName + " and whele LevelUp" );
                  Console.WriteLine();
                  enemy.InvokeTheEvent();    
               }
            }
            else if (togofost == 2)
            {
               pet.CobatHP -= enemy.EATK;
               if (pet.CobatHP > 0 )
               {
                  enemy.CobatEHP -= pet.ATK;

               }
               else if (pet.CobatHP <= 0)
               {
                  Console.WriteLine("your pet has didet in battel  \n game over "); 
                  meny.GameOver = true;

               }
            }
        
            
         }
         break;
      }
   }

   private void EnemyOnEnemyDeath(Enemy enemy, Pet pet)
   {
     pet.Levelup();
     pet.Clenlines();
     pet.Hapines();
     pet.Huger();
   }
}