using AlgoExpertAlgorithmsLibrary;
using SeansAlgoExpertConsoleApp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace SeansAlgoExpertConsoleApp
{
    public class BranchSumsRoutine
    {
        public static void RunBranchSumsRoutine()
        {


            BranchSumsNodeShape node1 = new("1", "2", "3", 1);
            BranchSumsNodeShape node2 = new("2", "4", "3", 2);
            BranchSumsNodeShape node3 = new("3", "6", "3", 3);
            BranchSumsNodeShape node4 = new("4", "8", "3", 4);
            BranchSumsNodeShape node5 = new("5", "10", null, 5);
            BranchSumsNodeShape node6 = new("6", null, null, 6);
            BranchSumsNodeShape node7 = new("7", null, null, 7);
            BranchSumsNodeShape node8 = new("8", null, null, 8);
            BranchSumsNodeShape node9 = new("9", null, null, 9);
            BranchSumsNodeShape node10 = new("10", null, null, 10);

            LinkedList<BranchSumsNodeShape> nodes = new LinkedList<BranchSumsNodeShape>();
            nodes.AddLast(node1);
            nodes.AddLast(node2);
            nodes.AddLast(node3);
            nodes.AddLast(node4);
            nodes.AddLast(node5);
            nodes.AddLast(node6);
            nodes.AddLast(node7);
            nodes.AddLast(node8);
            nodes.AddLast(node9);
            nodes.AddLast(node10);

            List<int>? sums = null;
            BranchSumsAlgorithm.BinaryTree root = new BranchSumsAlgorithm.BinaryTree(node1.Value);
            BranchSumsAlgorithm.BranchSums(root);
            //foreach (BranchSumsNodeShape node in nodes)
            //{
            //    BranchSumsAlgorithm.CalculateBranchSums(node, 0, sums);

            //}
            Console.WriteLine(sums);
        }
    }
}


// ***** First attempt at creating a routine to take in data and us algorithm *****


//int numberOfNodes = Convert.ToInt32(Console.ReadLine());
//BranchSumsAlgorithm.BinaryTree[] nodes = new BranchSumsAlgorithm.BinaryTree[numberOfNodes].ToArray();

//for (int i = 0; i < numberOfNodes; i++)
//{
//    //Messages.EnterNodeId();
//    //string id = i.ToString();

//    Messages.BinaryTreeLeftValue();
//    string? left = Console.ReadLine();
//    Messages.BinaryTreeRightValue();
//    string? right = Console.ReadLine();
//    Messages.EnterNodeValue();
//    int value = Convert.ToInt32(Console.ReadLine());

//    object node = new
//    {
//        Left = left,
//        Right = right,
//        Value = value,
//    };

//    //nodes[i] = node.ToString();

//    i++;
//}

//Messages.EnterYourRoot();
//var root = Console.ReadLine();


//  *** secondish try *** 

//Messages.BranchSumsInfo();
//Messages.HowManyNodesInYourBinaryTree();
//SingleLinkedListCreator.SingleLinkedList linkedList = new SingleLinkedListCreator.SingleLinkedList();
//int numberOfNodes = Convert.ToInt32(Console.ReadLine());
//BranchSumsAlgorithm.BinaryTree[] nodes = new BranchSumsAlgorithm.BinaryTree[numberOfNodes].ToArray();

//for (int i = 0; i < numberOfNodes; i++)
//{
//    Messages.EnterNodeId();
//    string id = i.ToString();

//    Messages.BinaryTreeLeftValue();
//    string? left = Console.ReadLine();
//    Messages.BinaryTreeRightValue();
//    string? right = Console.ReadLine();
//    Messages.EnterNodeValue();
//    int value = Convert.ToInt32(Console.ReadLine());

//    LinkedList<object> node = new()
//                {
//                    node.AddLast
//                    //Left =  left,
//                    //Right = right,
//                    //Value = value,
//                };

//    //nodes[i] = node.ToString();

//    i++;
//}

//Messages.EnterYourRoot();
//var root = Console.ReadLine();

