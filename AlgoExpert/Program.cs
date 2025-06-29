using AlgoExpert;
using AlgoExpert.Easy;
using AlgoExpert.Hard;
using AlgoExpert.Medium;
using AlgoExpert.Sorting;
using AlgoExpert.VeryHard;
using System.Text.Json;
using System.Text.Json.Nodes;

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


Console.WriteLine(new NonConstrutibleChange().NonChangeableAmout(new[] { 5, 7, 1, 1, 2, 3, 22 }));

Console.WriteLine(new ReverseWordsInString().Reverse("test        "));

PrettyPrint.Print(new MatrixTranspose().Transpose(new int[,] { { 1, 2 } }));

Console.WriteLine(new ClosetValueInBST().GetClosest(rootNode,12));

PrettyPrint.Print(new SpiralTraverse().Traverse(new int[,] { { 1, 2, 3, 4 }, { 10, 11, 12, 5 }, { 9, 8, 7, 6 } }));

var treeNode = BinaryTree.Create(new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },null);
PrettyPrint.Print(new BranchSum().CalculateAll(treeNode));

var triplets = new ThreeNumberSum().FindAllTriplet(new int[]{12, 3, 1, 2, -6, 5, -8, 6},0);
PrettyPrint.Print(triplets);
Console.WriteLine();
PrettyPrint.Print(new SmallestDifference().CalculateDifference(new int[] { -1, 5, 10, 20, 28, 3 }, new int[] { 26, 134, 135, 15, 17 }).ToList());

PrettyPrint.Print(new MoveElementToEnd().MoveElements(new() { 1, 2, 3, 4, 5 }, 3));

Console.WriteLine(new MonotonicArray().OptimalIsMonotonic(new int[] { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 }));

PrettyPrint.Print(new ArrayOfProducts().GetProducts(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }).ToList());

Console.WriteLine(new FirstDuplicateValue().FindDuplicate(new int[] { 1 } ));

Console.WriteLine(new NodeDepth().FindDepth(treeNode));




var powerSet = new PowerSet().GeneratePowerSetRecursive(new() { 1, 2, 3 });
PrettyPrint.Print(powerSet);

Console.WriteLine("Balanced Brackets: " + new BalancedBrackets().IsBalancedBrackets("adfd[]abcf"));

PrettyPrint.Print(new BinarySearch().Find(new int[,] {
  {1, 4, 7, 12, 15, 1000},
  {2, 5, 19, 31, 32, 1001},
  {3, 8, 24, 33, 35, 1002},
  {40, 41, 42, 44, 45, 1003},
  {99, 100, 103, 106, 128, 1004}
}, 44).ToList());

new CommonCharcters().Find(new List<string> { "ab&cdef!", "f!ed&cba", "a&bce!d", "ae&fb!cd", "efa&!dbc", "eff!&fff&fffffffbcda", "eeee!efff&fffbbbbbaaaaaccccdddd", "*******!***&****abdcef************", "*******!***&****a***********f*", "*******!***&****b***********c*" }).ToList().ForEach(Console.WriteLine);

new Semordnilap().Find(new string[] { "ab", "ba", "abc", "cba", "ab", "ba" }).ForEach(x => Console.WriteLine(string.Join(",", x)));

Console.WriteLine(new RunLengthEncoding().Encode("AAAAAAAAAAAAABBCCCCDD"));

GraphNode graph = new("A");
graph.AddChild("B").AddChild("C").AddChild("D");
graph.children[0].AddChild("E").AddChild("F");
graph.children[2].AddChild("G").AddChild("H");
graph.children[0].children[1].AddChild("I").AddChild("J");
graph.children[2].children[0].AddChild("K");

PrettyPrint.Print(graph.DepthFirstSearch(new List<string>()));
Console.WriteLine("BFS: ");
PrettyPrint.Print(graph.BreadthFirstSearch(new List<string>()));

head = new DSCreator().CreateLinkedList(new int[] { 1, 3, 4, 4, 4, 5, 6, 6 });
new LLDeleteDuplicates().DeleteDuplicates(head).Print();

PrettyPrint.Print(new MinimumCharactersForWords().GetMinChars(new string[] { "this", "that", "did", "deed", "them!", "a" }).ToList());

Console.WriteLine(new CeaserCipher().Encrypt("xyz",2));

List<object> test = new List<object>() {
      5,
      2,
      new List<object>() { 7, -1 },
      3,
      new List<object>() {
        6,
        new List<object>() { -13, 8 },
        4,
      },
    };

Console.WriteLine(new ProductSum().CalculateProductSum(test));

var exprRootNode = BinaryTree.Create(new() {-1,-2,-3,-4,2,8,3,2,3 },null);
//var exprRootNode = BinaryTree.Create(new() { -3, 3, 2 }, null);
Console.WriteLine("Expression: " + new EvaluateExpressionTree().Evaluate(exprRootNode));

Console.WriteLine(new FirstNonRepeatingCharacter().Find("faadabcbbebdf"));

PrettyPrint.Print(new TaskAssignment().AssignTasks(3, new() { 1, 3, 5, 3, 1, 4 }));

//Console.WriteLine(new LongestPeak().FindLongestPeak(new int[] { 1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3 }));
Console.WriteLine(new LongestPeak().FindLongestPeak(new int[] { 1,2,3,4,5,1 }));

Console.WriteLine(new BestSeat().Find(new int[] { 1, 1, 0, 1,1, 1, 1,0,1}));

Console.WriteLine(new ZeroSumSubArray().Exist(new int[] { -5, -5, 2, 3, -2 }));

PrettyPrint.Print(new MissingNumbers().FindUsingSum(new int[] { 4, 5, 1, 3 }).ToList());

Console.WriteLine(new BestDigits().Calculate("321",1));

PrettyPrint.Print(new TopologicalSort().DAGMethod(
    new List<int> { 1, 2, 3, 4 },
    new List<int[]>
    {
        new[] { 1, 2 },
        new[] { 1, 3 },
        new[] { 3, 2 },
        new[] { 4, 2 },
        new[] { 4, 3 }
    }
));

Console.WriteLine(new SingleCycleCheck().IsCycleExist(new int[] { 0,1,1 }));

BinaryTreeSccessor.BinaryTree root = new BinaryTreeSccessor.BinaryTree(1);
root.left = new BinaryTreeSccessor.BinaryTree(2);
root.left.parent = root;
root.right = new BinaryTreeSccessor.BinaryTree(3);
root.right.parent = root;
root.left.left = new BinaryTreeSccessor.BinaryTree(4);
root.left.left.parent = root.left;
root.left.right = new BinaryTreeSccessor.BinaryTree(5);
root.left.right.parent = root.left;
root.left.left.left = new BinaryTreeSccessor.BinaryTree(6);
root.left.left.left.parent = root.left.left;
root = root.left.right;

Console.WriteLine(new BinaryTreeSccessor().FindSuccessor(root, root.left.right).value);

var node20 = new BinaryTreeSccessor.BinaryTree(20);
var node10 = new BinaryTreeSccessor.BinaryTree(10);
var node30 = new BinaryTreeSccessor.BinaryTree(30);
var node5 = new BinaryTreeSccessor.BinaryTree(5);
var node15 = new BinaryTreeSccessor.BinaryTree(15);
var node25 = new BinaryTreeSccessor.BinaryTree(25);
var node35 = new BinaryTreeSccessor.BinaryTree(35);

// Establishing the relationships
node20.left = node10;
node20.right = node30;
node10.parent = node20;
node30.parent = node20;

node10.left = node5;
node10.right = node15;
node5.parent = node10;
node15.parent = node10;

node30.left = node25;
node30.right = node35;
node25.parent = node30;
node35.parent = node30;

Console.WriteLine(new BinaryTreeSccessor().FindSuccessor(node20,node15).value);

head = new DSCreator().CreateLinkedList(new int[] {0,1,2,3,4,5 });
new ShiftLinkedList().Shift(head, 2).Print();

int[][] intervals = new int[][]
{
    new int[] {20, 21},
    new int[] {22, 23},
    new int[] {0, 1},
    new int[] {3, 4},
    new int[] {23, 24},
    new int[] {25, 27},
    new int[] {5, 6},
    new int[] {7, 19}
};

intervals = new MergeOverlappingInterval().Merge(intervals);

PrettyPrint.Print(intervals.ToList());

int[][][] edges = {
      new int[][] { new int[] { 1, 7 } },
      new int[][] {
        new int[] { 2, 6 }, new int[] { 3, 20 }, new int[] { 4, 3 }
      },
      new int[][] { new int[] { 3, 14 } },
      new int[][] { new int[] { 4, 2 } },
      new int[][] {},
      new int[][] {}
    };

PrettyPrint.Print(new DijkstraAlgorithm().FindAllShortestPath(0, edges).ToList());


var heap = new MinHeap(new List<int> { 544, -578, 556, 713, -655, -359, -810, -731, 194, -531, -685, 689, -279, -738, 886, -54, -320, -500, 738, 445, -401, 993, -753, 329, -396, -924, -975, 376, 748, -356, 972, 459, 399, 669, -488, 568, -702, 551, 763, -90, -249, -45, 452, -917, 394, 195, -877, 153, 153, 788, 844, 867, 266, -739, 904, -154, -947, 464, 343, -312, 150, -656, 528, 61, 94, -581 } );
heap.Insert(76);

List<int> sorted = new List<int>();

while (heap._heap.Count > 0)
{
    sorted.Add(heap.Remove());
}
PrettyPrint.Print(sorted);

Console.WriteLine(new MaximizeExpression().Calculate(new int[] { 3, 6, 1, -3, 2, 7 }));

Console.WriteLine(new KadanesAlgo().FindMaxSum(new int[]{ 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 }));

Console.WriteLine(new MinimumWaitingTime().Calculate(new[] { 3,2,1,2,6 }));


PrettyPrint.Print(new FindThreeLargestNumber().Find(new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 }).ToList());

List<List<int>> array = new List<List<int>>();
/*array.Add(new List<int>() { 1, 3, 4, 10 });
array.Add(new List<int>() { 2, 5, 9, 11 });
array.Add(new List<int>() { 6, 8, 12, 17 });
array.Add(new List<int>() { 7, 13, 16, 18 });
array.Add(new List<int>() { 14, 15, 19, 20 });*/

/*array.Add(new List<int>() { 0,2,3 });
array.Add(new List<int>() { 1,4,5 });*/

array.Add(new List<int>() { 1 });
array.Add(new List<int>() { 2 });
array.Add(new List<int>() { 6 });
array.Add(new List<int>() { 8 });

PrettyPrint.Print(new ZigZagMatrix().Traverse(array));

PrettyPrint.Print(new SearchForRange().Find(new int[] { 1}, 1).ToList());

Console.WriteLine(new LongestSubstringWithoutDuplication().Find("aaaaabbbccdef"));

Console.WriteLine(new LongestBalancedsubstring().Calculate("((((((()()()())()))((())))()"));

Console.WriteLine(new ShortestPath().Calculate("foo/../.."));

List<int> redShirtHeights = new List<int> { 5, 8, 1, 3, 4 }; // 8 5 4 1 3
List<int> blueShirtHeights = new List<int> { 6, 9, 2, 4, 5 }; // 9 6 5 4 2
Console.WriteLine(new ClassPhotos().IsPhotoPossible(redShirtHeights,blueShirtHeights));

Console.WriteLine(new UnderscorifyString().Operate("testthis is a testtest to see if testestest it works", "test"));
Console.WriteLine(new UnderscorifyString().Operate("", ""));
//Console.WriteLine(new UnderscorifyString().Operate("eeeee eee eeee", "eee"));

List<int[]> input = new List<int[]>();
input.Add(new int[] { 2, 1, 2 });
input.Add(new int[] { 3, 2, 3 });
input.Add(new int[] { 2, 2, 8 });
input.Add(new int[] { 2, 3, 4 });
input.Add(new int[] { 2, 2, 1 });
input.Add(new int[] { 4, 4, 5 });


DiskStacking.CalculateOrderWithMaxHeight(input).ForEach(x => Console.WriteLine(string.Join(",", x)));

Console.WriteLine(LevenshteinDistance.Find("abc","yabd"));

Console.WriteLine(MinimunCoinDP.CalculateMinCoins(13, new int[] { 1,10,5,8 }));

Console.WriteLine(MaxSubsetSum.Calculate(new int[] { 75, 105, 120, 75, 90, 135 }));

Console.WriteLine(TraverseGridGraph.FormulaWay(4,3));

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

Console.WriteLine(JsonSerializer.Serialize(LongestCommonSubsequence.Find("ZXVVYZW", "XKYKZPW")));

Console.WriteLine(QuickSelect.Find(new int[] { 8, 5, 2, 9, 7, 6, 3 }, 3));

Console.WriteLine(JsonSerializer.Serialize(BubbleSort.Sort(new int[] { 7,4,6,11,17,21,15})));