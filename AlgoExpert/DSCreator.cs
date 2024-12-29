namespace AlgoExpert;

internal class DSCreator
{
    internal LinkedList CreateLinkedList(int[] list)
    {
        LinkedList head = null;
        LinkedList temp = null;
        foreach (int i in list)
        {
            if (head == null)
                head = temp = new LinkedList(i);
            else
                temp = temp.next = new LinkedList(i);
        }
        return head;
    }
}
