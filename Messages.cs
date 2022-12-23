
namespace SeansAlgoExpertConsoleApp
{
    public static class Messages
    {
        public static void OpeningMessage()
        {
            Console.WriteLine($"Welcome to Sean's Algorithm Utility!\n\n" +
                    $"Which Algorithm would you like to use?\n");
            int selection = 0;
            foreach (string option in Enum.GetNames(typeof(AlgorithmOptions)))
            {
                Console.WriteLine($"Choose {selection++} for {option}.");
            }
            Console.WriteLine("\n");
        }


        // Messages that ask you to do something. TODO: Construct an interface

        public static void EnterTarget()
        {
            Console.WriteLine($"Please enter your target: \n");
        }

        public static void EnterMatches()
        {
            Console.WriteLine($"Now enter your matches.\n");
        }

        public static void EnterYourSequenceArray()
        {
            Console.WriteLine($"Now enter your sequence array.\n");
        }

        public static void EnterYourDataMessage()
        {
            Console.WriteLine($"Please enter your data: \n");
        }
        public static void TargetSum()
        {
            Console.WriteLine($"What is your target sum? \n");
        }

        public static void EnterNodeId()
        {
            Console.WriteLine($"Enter the ID:\n");
        }
        
        public static void EnterNodeValue()
        {
            Console.WriteLine($"Enter the Value:\n");
        }

        public static void BinaryTreeLeftValue()
        {
            Console.WriteLine($"Enter left value:\n");
        }
        
        public static void BinaryTreeRightValue()
        {
            Console.WriteLine($"Enter right value:\n");
        }

        public static void EnterYourRoot()
        {
            Console.WriteLine($"Enter your root node by id.\n");
        }

        //Messages asking about how many **** you need. TODO: Construct interface

        public static void EnterHomeTeam()
        {
            Console.WriteLine($"Enter the home team:\n");
        }
        
        public static void EnterAwayTeam()
        {
            Console.WriteLine($"Enter the away team:\n");
        }

        public static void WinnerOfMatch()
        {
            Console.WriteLine($"Who won?\n" +
                $" Enter a 1 for the the home team and 0 for the away team.\n");
        }

        public static void TheNumberOfMatches()
        {
            Console.WriteLine($"The number of matches you will enter is: ");
        }

        public static void HowManyTeams()
        {
            Console.WriteLine($"How many teams will be participating?\n");
        }

        public static void HowManyNodesInYourBinaryTree()
        {
            Console.WriteLine($"How many nodes are in your binary tree?\n");
        }

        public static void HowManyIntsInArray()
        {
            Console.WriteLine($"How many integers are in your array?\n");
        }


        public static void HowManyCoinsNumbersMessage()
        {
            Console.WriteLine($"How many coins will you be entering?\n");
        }

        //Algorithm Direction Messages:  TODO: Construct Interface for directions

        public static void ProcuctSumInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.ProductSum} Algorithm.\n" +
                $"The purpose is to take in any array or a nested (\"Special\" array\n" +
                $"where the product sum of the array is the sum of its integers, where\n" +
                $"\"special\" arrays inside it our summed themselves and multiplied by\n" +
                $"their level of depth. For each [] inside of the initial array is a\n" +
                $"level deeper, like Russian nesting dolls.\n" +
                $"Example array: \n" +
                $"1 level depth:  [ 1, 2, 3, 4 ]\n" +
                $"2 level depth:  [ 1, 2,[ 3, 4, ] 5 ]\n" +
                $"3 level depth:  [ 1, [2, 3, [ 4, 5, ] 6,] 7 ]\n" +
                $"And so on.\n");
        }

        public static void BinaySearchInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.BinarySearch} Algorithm.\n" +
                $"The purpose of this Algorithm is to take in an array of integers and\n" +
                $"a target integer, then determine if the target is in the array.\n" +
                $"Firt you will be propmted for the number of integers in you array.\n" +
                $"Next you will enter the in the integers in your array.\n" +
                $"Lastly you will enter in your target integer. You will then recieve\n" +
                $"the index in the array of your target back giving you your targets\n" +
                $"location. If your target is not in the array you will be informed.\n");
        }


        public static void TournamentWinnerInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.TournamentWinner} Algorithm.\n" +
                $"The purpose of this Algorithm is to take in a list of matches between teams\n" +
                $"and then a list of outcomes for those matches generating an overall winner.\n" +
                $"You will be prompted for the number of teams playing. You will be told how many\n" +
                $"matches that is and be prompted to enter each match. First the home team, then\n" +
                $"the away team. Every team must play all teams.\n" +
                $"Finally you will be asked for the outcomes of each match. A \"0\" means the away\n" +
                $"team is the winner, a \"1\" means the home team won. Enter a 1 or 0 for each match.\n" +
                $"There are NO ties. It will then display the winner.\n");
        }

        public static void ValidateSubsequenceInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.ValidateSubsequence} Algorithm.\n" +
                $"The purpose of this Algorithm is to take in TWO non-empty arrays of integers and\n" +
                $"return a true or false answer on the question, \"is the second array a subsequence\n" +
                $"of the first array?\".\n" +
                $"You will be prompted for the number of integers in your array.\n" +
                $"Next you will enter each integer in the array one at a time.\n" +
                $"You will then do this process again for the second array.\n" +
                $"Then the routine will return to you a true or false on the question of the second\n" +
                $"array being a subsequence of the first.\n");
        }

        public static void SortedSquaresInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.SortedSquaredArray} Algorithm.\n\n" +
                $"The purpose of this Algorithm is to take in a non-empty array of integers and\n" +
                $"return them in a new sorted array that displays the squares of the original array.\n" +
                $"From lowest to highest.\n" +
                $"You will be prompted for the number of integers in your array.\n" +
                $"Next you will enter each integer in the array one at a time.\n" +
                $"Then the array you have entered will be returned but all values will be squared.\n");
        }


        public static void TwoNumberSumInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.TwoNumberSumFromArray} Algorithm.\n\n" +
                $"The purpose of this Algorithm is to take a target integer and find out if\n" +
                $"any of two integers entered by you into an array will add up to the target integer.\n" +
                $"If so, retrun the equation to you. It will return all possible combinations of\n" +
                $"two integers that sum up to your target integer\n" +
                $"When propmpted, you will enter a target sum that must be an integer, then you will" +
                $"be asked how many numbers are in your array? Enter a positive integer. again, you will\n" +
                $"be prompted and will enter in your positive or negagtive integers one at a time.\n");
        }

        public static void NonConstructableChangeInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.NonConstructibleChange} Algorithm.\n\n" +
                $"The purpose of this Algorithm is to take a given an array of positive integers representing\n" +
                $"the values of coins in your possession. The function will return the minimum sum of money that\n" +
                $"you CANNOT create. Coins must be a positive integer and do not have to be unique.\n" +
                $"Parameter Example: new int[] {{ 1, 4, 2, 7 }}\n\n" +
                $"When prompted, put in the number of coins you wish to add to the array.\n" +
                $"Then add any positive integer and press enter.  Do this as many times as you chose.\n");
        }

        public static void BranchSumsInfo()
        {
            Console.WriteLine($"Welcome to the {AlgorithmOptions.BranchSums} Algorithm.\n\n" +
                $"The purpose of this Algorithm is to take in a binary tree which houses a\n" +
                $"list of nodes. Each node must have an id which must be unique.\n" +
                $"Each node must have a value.\n" +
                $"Each  node must have aleft node and a right node that are integers or null.\n" +
                $"If a value equals a previous value it must be listed as such.\n" +
                $"The same is true for any left or right nodes." +
                $"Example:\n" +
                $"id == 1, value = 1, left node = 1-2, right node = 4\n" +
                $"id == 2, value = 1-2, left node = 1-3, right node = 4-2\n" +
                $"id == 3, value = 1-3, left node = null, right node = null\n" +
                $"id == 4, value = 4, left node = null, right node = null\n" +
                $"The second instance of 1 is labled as 1-2.  The third instance as 1-3, and so on.\n" +
                $"The same is true for the value 4. The second time it shows up it is listed as 4-2.\n");
        }
    }
}
