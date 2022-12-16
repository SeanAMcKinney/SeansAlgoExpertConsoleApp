
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


        // Messages that ask you to do something. TODO: Construct an interface
        public static void EnterYourDataMessage()
        {
            Console.WriteLine($"Please enter your data: \n");
        }
        public static void TargetSum()
        {
            Console.WriteLine($"What is your target sum? \n");
        }

        //Messages asking about how many **** you need. TODO: Construct interface

        public static void HowManyIntsInArray()
        {
            Console.WriteLine($"How many integers are in your array?\n");
        }


        public static void HowManyCoinsNumbersMessage()
        {
            Console.WriteLine($"How many coins will you be entering?\n");
        }

        //Algorithem Direction Messages:  TODO: Construct Interface for directions

        public static void TwoNumberSumInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithemOptions.TwoNumberSumFromArray} algorithem.\n\n" +
                $"The purpose of this algorithem is to take a target integer and find out if\n" +
                $"any of two integers entered by you into an array will add up to the target integer.\n" +
                $"If so, retrun the equation to you. It will return all possible combinations of\n" +
                $"two integers that sum up to your target integer\n" +
                $"When propmpted, you will enter a target sum that must be an integer, then you will" +
                $"be asked how many numbers are in your array? Enter a positive integer. again, you will\n" +
                $"be prompted and will enter in your positive or negagtive integers one at a time.\n");
        }

        public static void NonConstructableChangeInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithemOptions.NonConstructibleChange} algorithem.\n\n" +
                $"The purpose of this algorithem is to take a given an array of positive integers representing\n" +
                $"the values of coins in your possession. The function will return the minimum sum of money that\n" +
                $"you CANNOT create. Coins must be a positive integer and do not have to be unique.\n" +
                $"Parameter Example: new int[] {{ 1, 4, 2, 7 }}\n\n" +
                $"When prompted, put in the number of coins you wish to add to the array.\n" +
                $"Then add any positive integer and press enter.  Do this as many times as you chose.\n");
        }
    }
}
