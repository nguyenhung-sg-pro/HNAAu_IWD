using System;
using System.Diagnostics;
// Ví dụ 01
// class Program
// {
//     static void Main(string[] args)
//     {
//         int size = 9999;
//         int[] data = new int[size];
//         Build(data, size);
//         var startTime = DateTime.Now;
//         Print(data);
//         var time = DateTime.Now.Subtract(startTime);
//         Console.WriteLine($"\r\nExecution time: {time.Ticks} (ticks) =     {time.Milliseconds}(ms)");
//         Console.ReadKey();
//     }
//     static void Build(int[] array, int size)
//     {
//         for (var i = 0; i < size; i++)
//         {
//             array[i] = i;
//         }
//     }
//     static void Print(int[] array)
//     {
//         foreach (var i in array)
//             Console.Write($"{i} ");
//     }
// }

//Ví dụ 02
class Timing
{
    TimeSpan _start = new TimeSpan(0);
    TimeSpan _duration = new TimeSpan(0);
    public TimeSpan Duration => _duration;
    public void Stop()
    {
        _duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(_start);
    }
    public void Start()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        _start = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int size = 9999;
        int[] data = new int[size];
        Build(data, size);
        var timing = new Timing();
        timing.Start();
        Print(data);
        timing.Stop();
        Console.WriteLine($"\r\nExecution time: {timing.Duration.Ticks} (ticks) = {timing.Duration.Milliseconds} (ms)");
        Console.ReadLine();
    }
    static void Build(int[] array, int size)
    {
        for (var i = 0; i < size; i++)
        {
            array[i] = i;
        }
    }
    static void Print(int[] array)
    {
        foreach (var i in array)
            Console.Write($"{i} ");
    }
}