using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class BinarySearchRoutine
    {
        public static void RunBinarySearchRoutine()
        {
            Messages.BinaySearchInfo();
            Messages.HowManyIntsInArray();
            int numberInts = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberInts];
            Messages.EnterYourDataMessage();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Messages.EnterTarget();
            int target = Convert.ToInt32(Console.ReadLine());
            BinarySearchAlgorithm.BinarySearch(array, target);
            Console.ReadLine();
        }
    }
}
