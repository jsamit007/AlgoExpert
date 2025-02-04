using AlgoExpert;
using AlgoExpert.Easy;
using AlgoExpert.Medium;
using System.Xml.Linq;

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

//var exprRootNode = BinaryTree.Create(new() {-1,-2,-3,-4,2,8,3,2,3 },null);
var exprRootNode = BinaryTree.Create(new() {-3,3,2 },null);
Console.WriteLine(new EvaluateExpressionTree().Evaluate(exprRootNode));


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

head = new DSCreator().CreateLinkedList(new int[] { 1, 3, 4, 4, 4, 5, 6, 6 });
new LLDeleteDuplicates().DeleteDuplicates(head).Print();

PrettyPrint.Print(new MinimumCharactersForWords().GetMinChars(new string[] { "this", "that", "did", "deed", "them!", "a" }).ToList());

Console.WriteLine(new CeaserCipher().Encrypt("xyz",2));

