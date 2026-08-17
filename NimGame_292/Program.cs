internal class Program
{
    private static void Main(string[] args)
    {
        var result = CanWinNim(4);
        Console.WriteLine(result);
    }

    private static bool CanWinNim(int n)
    {
        return n % 4 != 0; //раз мы ходим первыми, мы можем выиграть только тогда, когда число не кратно 4
    }
}