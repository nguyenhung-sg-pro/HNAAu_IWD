
class Program
{
    // Đệ quy
    // Tính giai thừa
    static int GiaiThua(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * GiaiThua(n - 1);
    }


    static int TinhTong(int n)
    {
        if (n == 0)
            return 0;
        else
            return n + TinhTong(n - 1);
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static bool IsEven(int n)
    {
        if (n == 0)
            return true;
        else return IsOdd(n - 1);
    }

    static bool IsOdd(int n)
    {
        if (n == 0)
            return false;
        else return IsEven(n - 1);
    }

    static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine($"Giai thua cua {n} la: {GiaiThua(n)}");
        Console.WriteLine($"Tong tu 1 den {n} la: {TinhTong(n)}");
        Console.WriteLine($"Fibonacci cua {n} la: {Fibonacci(n)}");
        Console.WriteLine($"{n} la so chan: {IsEven(n)}");
        Console.WriteLine($"{n} la so le: {IsOdd(n)}");
        Console.ReadLine();
    }
}