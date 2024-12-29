namespace AlgoExpert;

internal class MiddleNode
{
    internal LinkedList FindMiddle(LinkedList head)
    {
        var temp = head;
        var count = 0;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        int mid = count / 2 + 1;
        count = 1;
        temp = head;
        while (count++ != mid)
            temp = temp.next;
        return temp;
    }
}
