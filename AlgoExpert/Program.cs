﻿using AlgoExpert;

var result = new TwoNumberSum().FindPairs(new int[] { 5, 3, 6, 4, 8 }, 10);
foreach (var item in result)
{
    Console.WriteLine(item);
}


var validateSubsequenceResult = new ValidateSubsequence().IsValidSubsequence(new() { 1, 5, 8 , 9, 11}, new() {5,9,11 });
Console.WriteLine(validateSubsequenceResult);

var sortedSquareArray = new SortedSquareArray().OptimalSolution(new int[] { -5, 1, 4, 8, 9, 11 });
foreach (var item in sortedSquareArray)
{
    Console.WriteLine(item);
}


var list = new List<int>() { 5, 11, 8, 7, 15, 26, 22, 18 };
var rootNode = new BinarySearchTree<int>().Create(list);
PrettyPrint.Print(new BSTTraversal().PreOrder(rootNode,new()));
PrettyPrint.Print(new BSTTraversal().InOrder(rootNode,new()));
PrettyPrint.Print(new BSTTraversal().PostOrder(rootNode,new()));


PrettyPrint.Print(new BSTTraversal().InOrder(new ReconstructBST<int>().Create(new int[] { 10, 4, 2 }), new()));

Console.WriteLine("Is Doc Generation Possible: " + new GenerateDocument().IsDocGenerationPossible("Bste!hetsi ogEAxpelrt x ", "AlgoExpert is the Best!"));

var head = new DSCreator().CreateLinkedList(new int[] { 5,7,8 });
var middle = new MiddleNode().FindMiddle(head);
Console.WriteLine("Middle Node: " + middle.value);

var teams = new List<List<string>>
{
    new() { "HTML", "C#" },
    new() { "C#", "Python"},
    new () { "Python", "HTML" }
};

List<int> teamsResult = new() { 0, 0, 1 };

Console.WriteLine(new TournamentWinner().FindWinner(teams,teamsResult));