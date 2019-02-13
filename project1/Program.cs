using System;
using System.Collections.Generic;

namespace sportproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] playerNum =
{
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25},
                {26, 27, 28, 29, 30},
                {31, 32, 33, 34, 35},
                {36, 37, 38, 39, 40}
            };

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
                {"Quarter-backs","Quarter-backs","Quarter-backs","Quarter-backs","Quarter-backs"},
                {"Running-backs","Running-backs","Running-backs","Running-backs","Running-backs"},
                {"Wide-receivers","Wide-receivers","Wide-receivers","Wide-receivers","Wide-receivers"},
                {"Defensive Linemen","Defensive Linemen","Defensive Linemen","Defensive Linemen","Defensive Linemen"},
                {"Defensive-backs","Defensive-backs","Defensive-backs","Defensive-backs","Defensive-backs"},
                {"Tight-ends","Tight-ends","Tight-ends","Tight-ends","Tight-ends"},
                {"Line-backers","Line-backers","Line-backers","Line-backers","Line-backers"},
                {"Offensive Tackles","Offensive Tackles","Offensive Tackles","Offensive Tackles","Offensive Tackles"}
            };

            List<Players> PlayersList = new List<Players>();
            List<Players> salaryPayList = new List<Players>();

            for (var i = 0; i < 8; i++)
            {
                for (var x = 0; x < 5; x++)
                {
                    Players aPlayers = new Players(playerNum[i, x], Players[i, x], Positions[i, x], Schools[i, x], salaryPay[i, x]);
                    PlayersList.Add(aPlayers);
                }

            }

            Console.WriteLine("");
            Console.ReadKey();
        }


        public string start = "";
        public string EXIT = "x";
        int maxExpenses = 95000000;
        int moneyAmount = 0;

        StartProgram(); //start the program
        while (start != EXIT) {

        Console.Clear();

        PlayersList.ForEach(x => Console.WriteLine(x.ToString()));
        Console.WriteLine("Please enter a number of which player you'd like to select: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                 for (int i = PlayersList.Count - 1; i >= 0; i--)
                        {
                            if (PlayersList[i].playerNum == choice)
                            {
                                salaryPayList.Add(PlayersList[i]);
                                maxExpenses = maxExpenses - PlayersList[i].salary;
                                moneyAmount = moneyAmount + PlayersList[i].salary;
                                PlayersList.RemoveAt(i);
                            }


}

                        if (maxExpenses <= 0)
                        {
                            Console.Clear();

                            Console.WriteLine("The max amount has exceeded, please try again and stay under the $95,000,000 budget this time.");
                            Console.WriteLine("Now you must restart the program!");
                            start = "x";
                            Console.ReadLine();

                        }else{

                            if (salaryPayList.Count >= 5)
                            {
                                start = "x";

                            }else{

                                Console.Clear();

                                Console.WriteLine("You have drafted: ");
                                foreach (Players i in salaryPayList)
                                {
                                    Console.WriteLine(i.ToString());
                                }
                                Console.WriteLine("Current cost of drafted players is $" + moneyAmount + ".");
                                Console.WriteLine("Current budget is $" + maxExpenses + ".");
                                Console.WriteLine("To continue drafting players, please press <ENTER>.");
                                Console.WriteLine("To exit the program, please press <X>.");
                                start = Console.ReadLine();
                            }
                        }

                    }
                        // while loop ends here

                    Console.Clear();
                    Console.WriteLine("You have selected the following: ");
                    foreach (Players i in salaryPayList)
                    {
                        Console.WriteLine(i.ToString());
                    }

                    Console.WriteLine("The total cost is $" + moneyAmount + ".");
                    Console.WriteLine("Amount of budget that has been left over is $" + maxExpenses + ".");
                    EndProgram();
Console.ReadLine();


                }
                    // end of EndProgram();

            public static void StartProgram();
            {
                Console.WriteLine("Welcome to the NFL Drafting Program!");
                Console.WriteLine("This program will help you draft players under a budget of $95,000,000.");
                Console.WriteLine("To get started with the program, please press <ENTER>.");
            }
            public static void EndProgram();
            {
                Console.WriteLine("The program has ended! Thank you for using the program.");
            }
    }

    }
        
}

    public class Players
{
    public int playerNum { get; set; }
    public string name { get; set; }
    public string Positions { get; set; }
    public string Schools { get; set; }
    public int salaryPay { get; set; }

    public Players(int playerNum, string name, string Positions, string Schools, int salaryPay)
    {
        this.playerNum = playerNum;
        this.name = name;
        this.Positions = Positions;
        this.Schools = Schools;
        this.salaryPay = salaryPay;
    }

    public override string ToString()
    {
        return string.Format(playerNum + "" + name + " plays " + Positions + " at " + Schools + " with a salary of $" + salaryPay + ".");
    }

}
}
