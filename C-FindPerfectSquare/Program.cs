using System;

class Program
{
    static void Main()
    {
        int[] sampleData = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int num in sampleData)
        {
            Console.WriteLine($"Is {num} a perfect square? {IsPerfectSquare(num)}");
        }
    }

    public static bool IsPerfectSquare(int num)
    {
        if (num < 0)
        {
            return false;
        }

        if (num == 0)
        {
            return true;
        }

        long dummy = num;

        while (dummy * dummy > num)
        {
            dummy = (dummy + num / dummy) / 2;
        }

        return dummy * dummy == num;
    }
}
