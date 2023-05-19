using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] dp = new int[n, m];
        dp[0, 0] = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i - 1 >= 0 && j - 2 >= 0)
                    dp[i, j] += dp[i - 1, j - 2];

                if (i - 2 >= 0 && j - 1 >= 0)
                    dp[i, j] += dp[i - 2, j - 1];
            }
        }

        Console.WriteLine(dp[n - 1, m - 1]);
    }
}
