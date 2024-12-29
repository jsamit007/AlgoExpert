namespace AlgoExpert;

internal class TreeNode<T> where T: IComparable<T>
{
    internal T Value { get; set; } = default!;
    internal TreeNode<T> left { get; set; } = default!;
    internal TreeNode<T> right { get; set; } = default!;
}
