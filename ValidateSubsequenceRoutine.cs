using AlgoExpertAlgorithmsLibrary;
using System;

namespace SeansAlgoExpertConsoleApp
{
    public class ValidateSubsequenceRoutine
    {
        public static void RunValidateSubsequenceRoutine()
        {
            Messages.ValidateSubsequenceInfo();
            Messages.HowManyIntsInArray();
            int firstIntArray = Convert.ToInt32(Console.ReadLine());
            List<int> array = new();
            Messages.EnterYourDataMessage();
            for (int i = 0; i < firstIntArray; i++)
            {
                int item = Convert.ToInt32(Console.ReadLine());
                array.Add(item);
            }

            Messages.EnterYourSequenceArray();
            Messages.HowManyIntsInArray();
            int secondIntArray = Convert.ToInt32(Console.ReadLine());
            List<int> sequence = new(); ;
            Messages.EnterYourDataMessage();
            for (int i = 0; i < secondIntArray; i++)
            {
                int item = Convert.ToInt32(Console.ReadLine());
                sequence.Add(item);
            }
            ValidateSubsequenceAlgorithem.IsValidSubsequence(array, sequence);
            Console.ReadLine();
        }
    }
}