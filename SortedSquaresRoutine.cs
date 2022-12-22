using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class SortedSquaresRoutine
    {
        public static void RunSortedSquaresRoutine()
        {
            Messages.SortedSquaresInfo();
            Messages.HowManyIntsInArray();
            int numberInts = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberInts];
            Messages.EnterYourDataMessage();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            SortedSquaredArrayAlgorithm.SortedSquaredArray(array);
            Console.ReadLine();
        }
    }
}