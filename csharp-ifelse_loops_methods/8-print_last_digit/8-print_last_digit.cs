class Program
{
    static void Main(string[] args)
    {  public static int PrintLastDigit(int number)
    {
        int x = number % 10;
        if (x < 0)
            x = x * -1;
        Console.Write(x);
        return x; 
    }


    }
}