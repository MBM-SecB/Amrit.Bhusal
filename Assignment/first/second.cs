using System;


class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetInitials();
        }
        void GetInitials()
        {
        Program obj1 = new Program();
        Console.Write("Enter the number of wins: ");
        int wins = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of draws: ");
        int draws = Int32.Parse(Console.ReadLine());
        Console.Write("Enter the number of loss: ");
        int loss = Int32.Parse(Console.ReadLine());
        int res = obj1.CalculateTeamPoint(wins, draws, loss);
        Console.WriteLine($"Team earned {res} point in the session");
    }

    
    int CalculateTeamPoint(int wins, int draws, int loss)
    {
        int totalPoint = 0;
        for (int i=1; i<=wins; i++)
        {
            totalPoint += 5;
        }

        for (int i=1; i<=draws; i++)
        {
            totalPoint += 2;
        }
        return totalPoint;
    }
}