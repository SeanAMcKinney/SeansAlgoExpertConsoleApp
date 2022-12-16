using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class NonConstructableChangeRoutine
    {
        public static void RunNonConstructableChangeRoutine()
        {
            Messages.NonConstructableChangeInfo();
            Messages.HowManyCoinsNumbersMessage();
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] coins = new int[size];
            Messages.EnterYourDataMessage();
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = Convert.ToInt32(Console.ReadLine());
            }
            NonConstructibleChangeAlgorithem.NonConstructibleChange(coins);
            Console.ReadLine();
        }
    }
}
