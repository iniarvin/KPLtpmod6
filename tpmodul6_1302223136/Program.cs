// See https://aka.ms/new-console-template for more information


using tpmodul6_1302223136;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo v = new SayaTubeVideo("New Vid", 0);
        for (int i = 0; i < 10; i++)
        {
            v.IncreasePlayCount(10000000);
            v.PrintVideoDetails();
        }
    }
}
