using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class ProductSumRoutine
    {
        public static void RunProductSumRoutine()
        {
            Messages.ProcuctSumInfo();
            Messages.EnterYourDataMessage();
            List<object> array = new();
            int input = Convert.ToInt32(Console.ReadLine());
            array.Add(input!);
            ProductSumAlgorithm.ProductSum(array);
            Console.ReadLine();
        }
    }
}