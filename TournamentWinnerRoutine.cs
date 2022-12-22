using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class TournamentWinnerRoutine
    {
        public static void RunTournamentWinnerRoutine()
        {
            Messages.TournamentWinnerInfo();
            int numberOfTeams;
            int matches = 0;
            bool isValid;
            do
            {
                Messages.HowManyTeams();
                numberOfTeams = Convert.ToInt32(Console.ReadLine());
                if (numberOfTeams > 0)
                {
                    Messages.TheNumberOfMatches();
                    for (int i = numberOfTeams; i > 0; i--)
                    {
                        matches += --numberOfTeams;
                    }
                    Console.WriteLine(matches);
                    Console.WriteLine();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                    isValid = false;
                }
            } while (!isValid);

            Messages.EnterMatches();
            List<List<string>> competitions = new ();
            List<int> results = new ();
            for (int i = 0; i < matches; i++)
            {
                List<string> match = new();
                Messages.EnterHomeTeam();
                string home = Console.ReadLine()!.ToLower();
                match.Add(home);
                Messages.EnterAwayTeam();
                string away = Console.ReadLine()!.ToLower();
                match.Add(away);
                competitions.Add(match);
                Messages.WinnerOfMatch();
                int winner = Convert.ToInt32(Console.ReadLine());
                results.Add(winner);
            }
            TournamentWinnerAlgorithm.TournamentWinner(competitions, results);
            Console.ReadLine();
        }
    }
}