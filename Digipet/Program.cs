namespace Digipet;

class Program
{
    static void Main(string[] args)
    {
        Pet pet = new Pet();
        pet.GiveName();
        pet.SAttack();
        pet.SHealth();
        pet.SSpeed();
        pet.GiveStats();

        Enemy enemy = new Enemy(pet);
        enemy.SAttack();
        enemy.SHealth();
        enemy.SSpeed();
        enemy.MakeEnemyType();
        Combat combat = new Combat();
        combat.InCombat(pet, enemy);
    }
}