namespace AlgoExpert.Hard;

internal class ShiftLinkedList
{
    public LinkedList Shift(LinkedList head, int k)
    {
        if(k == 0)
            return head;
        
        int length = 1;
        var last = head;
        while (last.next != null)
        {
            length++;
            last = last.next;
        }  

        if(k < 0)
            k = length + k%length;
        k = k % length;

        if (k == 0)
            return head;
        k = length - k;
        var next = head;
        var prev = head;
        while (k != 0)
        {
            prev = next;
            next = next.next;
            k--;
        }

        last.next = head;
        prev.next = null;

        return next;
    }
}
