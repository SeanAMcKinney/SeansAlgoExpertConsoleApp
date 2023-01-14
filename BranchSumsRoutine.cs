using AlgoExpertAlgorithmsLibrary;

namespace SeansAlgoExpertConsoleApp
{
    public class BranchSumsRoutine
    {
        public static void RunBranchSumsRoutine()
        {
            Messages.BranchSumsInfo();
            Messages.HowManyNodesInYourBinaryTree();
            int numberOfNodes = Convert.ToInt32(Console.ReadLine());
            BranchSumsAlgorithm.BinaryTree[] nodes = new BranchSumsAlgorithm.BinaryTree[numberOfNodes].ToArray();

            for (int i = 0; i < numberOfNodes; i++)
            {
                //Messages.EnterNodeId();
                //string id = i.ToString();
                
                Messages.BinaryTreeLeftValue();
                string? left = Console.ReadLine();
                Messages.BinaryTreeRightValue();
                string? right = Console.ReadLine();
                Messages.EnterNodeValue();
                int value = Convert.ToInt32(Console.ReadLine());

                object node = new {
                    Left = left,
                    Right = right,
                    Value = value,
                };

                nodes[i] = node.ToString();

                i++;
            }

            Messages.EnterYourRoot();
            var root = Console.ReadLine();



        }
    }
}



