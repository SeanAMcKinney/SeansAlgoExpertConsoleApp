
namespace SeansAlgoExpertConsoleApp
{
    public static class Messages
    {
        public static void OpeningMessage()
        {
            Console.WriteLine($"Welcome to Sean's Algorithem Utility!\n\n" +
                    $"Which algorithem would you like to use?\n");
            foreach (string option in Enum.GetNames(typeof(AlgorithemOptions)))
            {
                Console.WriteLine(option);
            }
            Console.WriteLine("\n");
        }

        public static void EnterYourDataMessage()
        {
            Console.WriteLine($"Please enter your data: \n");
        }

        public static void HowManyNumbersMessage()
        {
            Console.WriteLine($"How may coins will you be entering?");
        }

        public static void NonConstructableChangeInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithemOptions.NonConstructibleChange} algoithem.\n\n" + 
                $"The purpose of this algorithem is to take a given an array of positive integers representing\n" + 
                $"the values of coins in your possession. The function will return the minimum sum of money that\n" + 
                $"you CANNOT create. Coins must be a positive integer and do not have to be unique.\n" + 
                $"Parameter Example: new int[] {{ 1, 4, 2, 7 }}\n\n" + 
                $"When prompted, put in the number of coins you wish to add to the array.\n" + 
                $"Then add any positive integer and press enter.  Do this as many times as you chose.\n");
        }
    }
}
