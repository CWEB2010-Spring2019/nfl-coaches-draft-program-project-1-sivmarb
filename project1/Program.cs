using System;
using System.Collections.Generic;

namespace sportproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Schools =
            {
                { "Ohio State", "Oklahoma", "Missouri", "Duke", "West Virginia" },
                { "Alabama", "Alabama", "Iowa State", "Oklahoma State", "FAU" },
                { "Ole Miss", "Ole Miss", "Arizona State", "Oklahoma", "NC State" },
                { "Ohio State", "Alabama", "Houston", "Miss. State", "Clemson" },
                { "LSU", "Georgia", "Washington", "Alabama", "Penn State" },
                { "Iowa", "Alabama", "Iowa", "Stanford", "San Jose State" },
                { "Kentucky", "LSU", "Miss. State", "Alabama", "Michigan" },
                { "Alabama", "Ole Miss", "Oklahoma", "Florida", "West Virginia" }
            };

            string[,] Players =
            {
                { "Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier" },
                { "Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary" },
                { "D.K. Metcalf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon" },
                { "Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell" },
                { "Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye" },
                { "Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver" },
                { "Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush" },
                { "Jonah Williams", "Greg Little", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste" }
            };

            int[,] salaryPay =
            {
                {26400100, 20300100, 17420300, 13100145, 10300000},
                {24500100, 19890200, 18700800, 15000000, 11600400},
                {23400000, 21900300, 19300230, 13400230, 10000000},
                {26200300, 22000000, 16000000, 18000000, 13000000},
                {24000000, 22500249, 20000100, 16000200, 11899999},
                {27800900, 21000800, 17499233, 27900200, 14900333},
                {22900300, 19000590, 18000222, 12999999, 10000100},
                {23000000, 20000000, 19400000, 16200700, 15900000}
            };

            string[,] Positions =
            {
                {"Quarter-backs"},
                {"Running-backs"},
                {"Wide-receivers"},
                {"Defensive Linemen"},
                {"Defensive-backs"},
                {"Tight-ends"},
                {"Line-backers"},
                {"Offensive Tackles"}
            };


            List<Players> PlayersList = new List<Players>();
            List<Players> salaryPayList = new List<Players>();

            for (var i = 0; i < 8; i++)
            {
                for (var x = 0; x < 5; x++)
                {
                    Players aPlayers = new Players(Players[i, x], salaryPay[i, x]);
                    PlayersList.Add(aPlayers);
                }

            }

            PlayersList.ForEach(x => Console.WriteLine(x.ToString()));
            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}

public class Players
{
    public string name { get; set; }
    public int salaryPay { get; set; }

    public Players(string name, int salaryPay)
    {
        this.name = name;
        this.salaryPay = salaryPay;
    }

    public override string ToString()
    {
        return string.Format("" + name + "$" + salaryPay);
    }

}
