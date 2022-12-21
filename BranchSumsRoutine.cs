using AlgoExpertAlgorithmsLibrary;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeansAlgoExpertConsoleApp
{
    public class BranchSumsRoutine
    {
        public static void RunBranchSumsRoutine()
        {
            Messages.BranchSumsInfo();
            Messages.HowManyNodesInYourBinaryTree();
            int numberOfNodes = Convert.ToInt32(Console.ReadLine());
            List<BranchSumsAlgorithem.BinaryTree[]> nodes = new List<BranchSumsAlgorithem.BinaryTree[]>();

            for (int i = 0; i < numberOfNodes; i++)
            {
                Messages.EnterNodeId();
                string id = Console.ReadLine()!;
                Messages.EnterNodeValue();
                int value = Convert.ToInt32(Console.ReadLine());
                Messages.BinaryTreeLeftValue();
                string left =  Console.ReadLine();
                Messages.BinaryTreeRightValue();
                string right = Console.ReadLine();

                //BranchSumsAlgorithem.BinaryTree[] node = { id, value, left, right };
                //nodes.Add(node);
                i++;
            }

            Messages.EnterYourRoot();
            var root = Console.ReadLine();
            


        }
    }
}



