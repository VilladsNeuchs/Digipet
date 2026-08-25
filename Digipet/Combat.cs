namespace Digipet;

public class Combat
{
   public void InCombat()
   {
      while (Pet.CobatHP > 0 || Enemy.CobatEHP > 0)
      {
         if (Pet.SPE > Enemy.ESPE)
         {
            Enemy.EHP -= Pet.ATK;
            if (Enemy.EHP > 0 )
            {
               Pet.HP -= Enemy.EATK;
 
            }
         }
         else if (Enemy.ESPE > Pet.SPE)
         {
               Pet.HP -= Enemy.EATK;
               if (Pet.HP > 0 )
               {
                  Enemy.EHP -= Pet.ATK;

               }
               else
               {
                  
               }
           
         }
         {
            
         }
      }
   }

}