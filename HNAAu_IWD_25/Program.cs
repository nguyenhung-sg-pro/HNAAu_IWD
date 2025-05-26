using System;
using System.Collections.Generic;
using static System.Console;
// namespace P01_SequentialSearch
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Title = "SEQUENTIAL SEARCH";
//             var data = new[] { 1, 3, 9, 2, 4, 5, 7, 6, 8 };
//             var value = 5;
//             Print(data);
//             //var found = SequentialSearch.Search(data, value); 
//             var found = SequentialSearch.Search(data, value, (a, b) => a == b);
//             //var found = data.Search(value, (a, b) => a == b); 
//             //var found = data.Search(value);
//             //var index = SequentialSearch.IndexOf(data, value); 
//             //var index = SequentialSearch.IndexOf(data, value, (a, b) => a == b); 
//             //var index = data.IndexOf(value, (a, b) => a == b); 
//             var index = data.IndexOf(value);
//             WriteLine($"Searching for {value} : {(found ? $"found at {index.ToString()}" : "not found")}");

//         }
//         public static void Print<T>(IEnumerable<T> array)
//         {
//             ForegroundColor = ConsoleColor.Red;
//             foreach (var i in array)
//             {
//                 Write($"{i}    ");
//             }
//             ResetColor();
//             WriteLine();
//         }
//     }
//     public static class SequentialSearch
//     {
//         public static bool Search<T>(this IEnumerable<T> data, T value) where T : IComparable
//         {
//             foreach (var i in data)
//             {
//                 if (i.CompareTo(value) == 0) return true;
//             }
//             return false;
//         }
//         public static bool Search<T>(this IEnumerable<T> data, T value, Func<T, T, bool> equal)
//         {
//             foreach (var i in data)
//             {
//                 if (equal(i, value)) return true;
//             }
//             return false;
//         }
//         public static int IndexOf<T>(this IList<T> data, T value) where T : IComparable
//         {
//             for (var i = 0; i < data.Count; i++)
//             {
//                 if (data[i].CompareTo(value) == 0) return i;
//             }
//             return -1; // không tìm thấy 
//         }
//         public static int IndexOf<T>(this IList<T> data, T value, Func<T, T, bool> equal)
//         {
//             for (var i = 0; i < data.Count; i++)
//             {
//                 if (equal(data[i], value)) return i;
//             }
//             return -1; // không tìm thấy 
//         }
//     }
// }


// namespace P02_BinarySearch
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Title = "BINARY SEARCH";
//             var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 53, 67, 775 };
//             Print(data);
//             var value = 30;
//             var found = data.Search(value);
//             //var found = data.SearchRecursive(value);
//             WriteLine($"Searching for {value} : {(found > -1 ? $"found at {found.ToString()}" : "not found")}");
//         }
//         public static void Print<T>(IEnumerable<T> array)
//         {
//             ForegroundColor = ConsoleColor.Green;
//             foreach (var i in array)
//             {
//                 Write($"{i}    ");
//             }
//             ResetColor();
//             WriteLine();
//         }
//     }
//     public static class BinarySearch
//     {
//         // sử dụng vòng lặp 
//         public static int Search<T>(this IList<T> data, T value) where T : IComparable
//         {
//             int upper = data.Count - 1, lower = 0, mid;
//             while (lower <= upper)
//             {
//                 mid = (upper + lower) / 2;
//                 if (data[mid].CompareTo(value) == 0) return mid;
//                 else if (value.CompareTo(data[mid]) < 0)
//                     upper = mid - 1;
//                 else
//                     lower = mid + 1;
//             }
//             return -1; // không tìm thấy 
//         }

//         // sử dụng đệ quy 
//         public static int SearchRecursive<T>(this IList<T> data, T value) where T : IComparable
//         {
//             int Recursive(int lower, int upper)
//             {
//                 if (lower > upper)
//                     return -1; // không tìm thấy 
//                 else
//                 {
//                     int mid = (upper + lower) / 2;
//                     if (value.CompareTo(data[mid]) < 0)
//                         return Recursive(lower, mid - 1);
//                     else if (value.CompareTo(data[mid]) == 0)
//                         return mid;
//                     else
//                         return Recursive(mid + 1, upper);
//                 }
//             }

//             return Recursive(0, data.Count - 1);
//         }
//     }
// }


namespace P03_SearchSupport
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print(data);
            WriteLine("Enter a number to search:");
            long value;
            try
            {
                value = long.Parse(ReadLine() ?? "0");
            }
            catch
            {
                WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            var index0 = Array.BinarySearch(data, value);
            WriteLine($"Searching for {value} : {(index0 > -1 ? $"found at {index0.ToString()}" : "not found")}");
            var index1 = Array.FindIndex(data, i => i == value);
            WriteLine($"Searching for {value} : {(index1 > -1 ? $"found at {index1.ToString()}" : "not found")}");
            var index2 = data.ToList().IndexOf(value);
            WriteLine($"Searching for {value} : {(index2 > -1 ? $"found at {index2.ToString()}" : "not found")}");

            data = new long[] { 1, 3, 9, 2, 4, 5, 7, 6, 8 };
            Print(data);
            var found = data.Contains(value);
            WriteLine($"Searching for {value} : {(found ? "found" : "not found")}");
            var min = data.Min();
            var max = data.Max();
            WriteLine($"Min value: {min}");
            WriteLine($"Max value: {max}");
        }
        public static void Print<T>(IEnumerable<T> array)
        {
            ForegroundColor = ConsoleColor.Green;
            foreach (var i in array)
            {
                Write($"{i}    ");
            }
            ResetColor();
            WriteLine();
        }
    }
}