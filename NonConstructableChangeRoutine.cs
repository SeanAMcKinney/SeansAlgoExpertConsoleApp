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

            for (int i = 0; i < data.Length; i++)
            {
                int[] coins = data;
                NonConstructibleChangeAlgorithem.NonConstructibleChange(coins);
            }

            
            //ChangeStringToIntArray(data);
        }



        //public static void ChangeStringToIntArray(string data)
        //{
        //    if (data != null && data != string.Empty)
        //    {
        //        char[] ch = new char[];

        //        for (int i = 0; i < data.Length; i++)
        //        {
        //            ch[i] = data[i];
        //        }

        //        int[] change = new int[];
        //        foreach (int item in data)
        //        {
        //            int dataToInt = Convert.ToInt32(item);
        //            if (dataToInt > 0)
        //            {
        //                change.Add(dataToInt);
        //            }
        //        }
        //        int[] coins = change.ToArray();
        //        NonConstructibleChangeAlgorithem.NonConstructibleChange(coins);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"You entered a empty or incorrect format.  Please try again.");
        //    }
        //}


    }
}
