namespace Digipet;

public class Enemy
{
    private int enemyph = 1;

    
    void Cekeenemyalive()
    {
        if (enemyph <= 0)
        {
         OnEnemyDeath.Invoke(this);
        }
    }
    public event Action<Enemy> OnEnemyDeath;
}