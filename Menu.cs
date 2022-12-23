
using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public static class Menu
    {
        public static void SelectedAlgorithem()
        {
            int userInput = Convert.ToInt32(Console.In.ReadLine()!);

            switch (userInput)
            {
                case 0:
                    Console.WriteLine($"Now going to {AlgorithmOptions.BinarySearch}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    BinarySearchRoutine.RunBinarySearchRoutine();
                    break;
                case 1:
                    Console.WriteLine($"Now going to {AlgorithmOptions.BranchSums}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    BranchSumsRoutine.RunBranchSumsRoutine();
                    break;
                case 2:
                    Console.WriteLine($"Now going to {AlgorithmOptions.NodeDepths}.");
                    break;
                case 3:
                    Console.WriteLine($"Now going to {AlgorithmOptions.NonConstructibleChange}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    NonConstructableChangeRoutine.RunNonConstructableChangeRoutine();
                    break;

                case 4:
                    Console.WriteLine($"Now going to {AlgorithmOptions.ProductSum}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ProductSumRoutine.RunProductSumRoutine();
                    break;
                case 5:
                    Console.WriteLine($"Now going to {AlgorithmOptions.SortedSquaredArray}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    SortedSquaresRoutine.RunSortedSquaresRoutine();
                    break;
                case 6:
                    Console.WriteLine($"Now going to {AlgorithmOptions.TournamentWinner}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    TournamentWinnerRoutine.RunTournamentWinnerRoutine();
                    break;
                case 7:
                    Console.WriteLine($"Now going to {AlgorithmOptions.TwoNumberSumFromArray}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    TwoNumbersSumFromArrayRoutine.RunTwoNumberSumFromArrayRoutine();
                    break;

                case 8:
                    Console.WriteLine($"Now going to {AlgorithmOptions.ValidateSubsequence}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ValidateSubsequenceRoutine.RunValidateSubsequenceRoutine();
                    break;
                default:
                    Console.WriteLine("Not a valid selection. Please try again.");
                    break;
            }
            Console.WriteLine("\n\n");
        }
    }
}
