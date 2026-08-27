namespace Digipet;

public class Combat
{
   public int togofost = 0;
   public void InCombat(Pet pet , Enemy enemy)
   {
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
               Console.WriteLine("you and " + pet.PetName + "have wone agenst " + enemy.EnemyName + "and whele LevelUp" );
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
                 Console.WriteLine("you pet is Deat "); 
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
                  Console.WriteLine("you and" + pet.PetName + " have wone agenst " + enemy.EnemyName + "and whele LevelUp" );
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
                  Console.WriteLine("you pet is Deat "); 

               }
            }
         }
         {
             
         }
         {
            
         }
      }
   }

   private void EnemyOnEnemyDeath(Enemy enemy, Pet pet)
   {
     pet.Levelup(); 
   }
}