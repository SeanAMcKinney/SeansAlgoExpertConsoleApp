﻿
namespace SeansAlgoExpertConsoleApp
{
    public static class Menu
    {
        public static void SelectedAlgorithem()
        {
            string userInput = Console.ReadLine()!.ToLower();

            switch (userInput)
            {
                case "binarysearch":
                    Console.WriteLine($"Now going to {AlgorithemOptions.BinarySearch}.");
                    break;
                case "branchsums":
                    Console.WriteLine($"Now going to {AlgorithemOptions.BranchSums}.");
                    break;
                case "nodedepths":
                    Console.WriteLine($"Now going to {AlgorithemOptions.NodeDepths}.");
                    break;
                case "nonconstructiblechange":
                    Console.WriteLine($"Now going to {AlgorithemOptions.NonConstructibleChange}.");
                    Thread.Sleep( 2000 );
                    Console.Clear();
                    NonConstructableChangeRoutine.RunNonConstructableChangeRoutine();
                    break;

                case "productsum":
                    Console.WriteLine($"Now going to {AlgorithemOptions.ProductSum}.");
                    break;
                case "sortedsquaredarray":
                    Console.WriteLine($"Now going to {AlgorithemOptions.SortedSquaredArray}.");
                    break;
                case "tournamentwinner":
                    Console.WriteLine($"Now going to {AlgorithemOptions.TrounamentWinner}.");
                    break;
                case "twonumbersumfromarray":
                    Console.WriteLine($"Now going to {AlgorithemOptions.TwoNumberSumFromArray}.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    TwoNumbersSumFromArray.RunTwoNumberSumFromArrayRoutine();
                    break;

                case "validatesubsequence":
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
