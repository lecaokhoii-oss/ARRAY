using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        // 1. Khởi tạo mảng 1 chiều
        int[] A = new int[] { 1, 2, 3, 4, 5 };

        // 2. Khởi tạo mảng 2 chiều
        int[,] m3 = new int[,]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
        int N = m3.GetLength(0); // Số hàng
        int M = m3.GetLength(1); // Số cột
        int tongVien = 0;
        for ( int i = 0; i < N; i++)
            for ( int j = 0; j < M; j++ )
                if ( i == 0 || i == N -1 || j == 0 || j == M - 1)
                {
                    tongVien += m3[i, j];
                }  
        Console.WriteLine($"Tổng các phần tử trên đường viền: {tongVien}");

        int N2 = A.Length;
        int[,] c = new int[N2, N2];
        for (int i = 0; i < N2; i++)
            for (int j = 0; j < N2; j++)
                c[i, j] = A[i] - A[j];
        Console.WriteLine("Mảng 2 chiều C[N2, N2] (c[i,j] = A[i] - A[j]):");
        for (int i = 0; i < N2; i++)
        {
            for (int j = 0; j < N2; j++)
                Console.Write($"{c[i, j], 5}");
            Console.WriteLine();
        }

        int k = 1;
        int value = 76;
        int[] A_new = new int[A.Length + 1];
        
        for (int i = 0; i < A_new.Length; i++)
        {
            if (i < k)
                A_new[i] = A[i];
            else if (i == k)
                A_new[i] = value;
            else
                A_new[i] = A[i - 1];

            Console.Write($"{A_new[i],5}");
        }

        int[] A_xoa = new int[A.Length - 1];
        for (int i = 0; i < A_xoa.Length; i++)
        {
            if (i < k)
                A_xoa[i] = A[i];
            else
                A_xoa[i] = A[i + 1]; // vì nó sẽ xóa khi i = k, nên các phần tử sau sẽ bị dịch sang trái 1 vị trí A_xoa[2] = A[2+1] để bù vào vị trí 2 của A_xoa
        }
        Console.WriteLine(string.Join(", ", A_xoa));

    }

}