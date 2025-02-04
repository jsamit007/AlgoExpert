namespace AlgoExpert.Easy;

internal class LLDeleteDuplicates
{
    public LinkedList DeleteDuplicates(LinkedList head)
    {
        var temp = head;
        while(temp != null)
        {
            var current = temp.value;
            var next = temp.next;
            while (next != null && next.value == current)
                next = next.next;
            temp = temp.next = next;
        }
        return head;
    }
}
