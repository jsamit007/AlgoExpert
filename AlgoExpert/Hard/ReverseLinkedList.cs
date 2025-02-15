namespace AlgoExpert.Hard;

internal class ReverseLinkedList
{
    public LinkedList Reverse(LinkedList head)
    {
        var last = head;
        var current = head.next;

        while(current != null)
        {
            var temp = current.next;
            current.next = last;
            last = current;
            current = temp;
        }
        head.next = null;
        return last;
    }
}
