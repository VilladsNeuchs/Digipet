namespace Digipet;

public static class RNG
{
    private static Random Random = new Random();
    public static int Range(int a, int b)
    {
        return Random.Next(a, b);


    }
}