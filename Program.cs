using System;
using System.Text;

public class Baitap22
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số phần tử của mảng: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Nhập phần tử cần xoá: ");
        int X = int.Parse(Console.ReadLine());
        int index_del = -1;
        for (int i = 0; i < N; i++)
        {
            if (array[i] == X)
            {
                index_del = i;
                break;
            }
        }

        if (index_del != -1)
        {
            for (int i = index_del; i < N - 1; i++)
            {
                array[i] = array[i + 1];
            }
            N--; 
        }
        else
        {
            Console.WriteLine("Phần tử không tồn tại trong mảng.");
        }
        Console.WriteLine("Mảng sau khi xoá:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
