partial class Program
{
    //Đệ quy đuôi
    //Tính tổng từ 1 đến n
    //Tham số n: số nguyên đầu vào, là số cần tính tổng từ 1 đến n.
    //Tham số acc: biến tích lũy (accumulator), mặc định là 0, dùng để lưu tổng tạm thời.
    //Lời gọi đệ quy SumTail(n - 1, n + acc) là câu lệnh cuối cùng trong hàm. Không có phép toán nào sau lời gọi này.
    static int SumTail(int n, int acc = 0)
    {
        if (n == 0)
            return acc;
        else
            return SumTail(n - 1, n + acc);// Gọi rồi done, không làm gì nữa!
    }


    //Đệ quy lồng nhau
    static int ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return ackermann(m - 1, 1);
        //Nếu m > 0 và n > 0, gọi đệ quy lồng nhau  
        return ackermann(m - 1, ackermann(m, n - 1));
    }

    static void DuyetMang(int[,] matrix, int i, int j)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        if (i >= rows) return;
        if (j >= cols)
        {
            DuyetMang(matrix, i + 1, 0);
            return;
        }
        Console.Write(matrix[i, j] + " ");
        DuyetMang(matrix, i, j + 1);
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int n = 5;
        Console.WriteLine($"Tổng từ 1 đến {n} là: {SumTail(n)}");
        Console.WriteLine($"Giá trị hàm Ackermann với m = 2 và n = 2 là: {ackermann(2, 2)}");
        int[,] matrix = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 2, 38, 49 }
        };
        DuyetMang(matrix, 0, 0);
        Console.ReadLine();
    }
}