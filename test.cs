class Test
{
    public static int AddNumber(int x, int y)
    {       
        return x + y;
    } 
    static void Main()
    {
        int x = 10;
        int y = 20;
        int result = AddNumber(x, y);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}