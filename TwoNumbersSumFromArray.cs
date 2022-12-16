using AlgoExpertAlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeansAlgoExpertConsoleApp
{
    public class TwoNumbersSumFromArray
    {
        public static void RunTwoNumberSumFromArrayRoutine()
        {
            Messages.TwoNumberSumInfo();
            Messages.TargetSum();
            int targetSum = Convert.ToInt32(Console.ReadLine());
            Messages.HowManyIntsInArray();
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] array = new int[size];
            Messages.EnterYourDataMessage();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            TwoNumberSum.FindTwoNumberSum(array, targetSum);
            Console.ReadLine();
        }
    }
}
