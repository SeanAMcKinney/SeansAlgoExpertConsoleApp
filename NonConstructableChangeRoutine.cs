using AlgoExpertAlgorithmsLibrary;
using System;
using System.Drawing;
using System.Linq;

namespace SeansAlgoExpertConsoleApp
{
    public class NonConstructableChangeRoutine
    {
        public static void RunNonConstructableChangeRoutine()
        {
            Messages.NonConstructableChangeInfo();
            Messages.HowManyNumbersMessage();
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] data = new int[size];
            Messages.EnterYourDataMessage();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] coins = data;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    coins = data;
            //}
            NonConstructibleChangeAlgorithem.NonConstructibleChange(coins);
            Console.WriteLine($"The first amount of change you can't produce is: {""}");
            Console.ReadLine();
        }
    }
}
