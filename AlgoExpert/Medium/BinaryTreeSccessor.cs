namespace AlgoExpert.Medium;

internal class BinaryTreeSccessor
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;
        public BinaryTree parent = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
    {
        if(node.right == null)
        {
            var temp = node.parent;
            while(temp != null && node != temp.left)
            {
                node = temp;
                temp = temp.parent;
            }
            return temp;
        }
        else
        {
            var temp = node.right;
            while (temp != null && temp.left != null) 
                temp = temp.left;
            return temp;
        }
    }


    
}
