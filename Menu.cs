
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
                    Console.WriteLine($"Now going to {AlgorithemOptions.BinarySearch}.");
                    break;
                case 1:
                    Console.WriteLine($"Now going to {AlgorithemOptions.BranchSums}.");
                    break;
                case 2:
                    Console.WriteLine($"Now going to {AlgorithemOptions.NodeDepths}.");
                    break;
                case 3:
                    Console.WriteLine($"Now going to {AlgorithemOptions.NonConstructibleChange}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    NonConstructableChangeRoutine.RunNonConstructableChangeRoutine();
                    break;

                case 4:
                    Console.WriteLine($"Now going to {AlgorithemOptions.ProductSum}.");
                    break;
                case 5:
                    Console.WriteLine($"Now going to {AlgorithemOptions.SortedSquaredArray}.");
                    break;
                case 6:
                    Console.WriteLine($"Now going to {AlgorithemOptions.TrounamentWinner}.");
                    break;
                case 7:
                    Console.WriteLine($"Now going to {AlgorithemOptions.TwoNumberSumFromArray}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    TwoNumbersSumFromArrayRoutine.RunTwoNumberSumFromArrayRoutine();
                    break;

                case 8:
                    Console.WriteLine($"Now going to {AlgorithemOptions.ValidateSubsequence}.");
                    break;
                default:
                    Console.WriteLine("Not a valid selection. Please try again.");
                    break;
            }
            Console.WriteLine("\n\n");
        }
    }
}
