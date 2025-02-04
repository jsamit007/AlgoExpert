namespace AlgoExpert;

internal class LinkedList
{
    public int value;
    public LinkedList next;

    public LinkedList(int value)
    {
        this.value = value;
        this.next = null;
    }

    public void Print()
    {
        var temp = this;
        while (temp != null)
        {
            Console.Write(temp.value + " ");
            temp = temp.next;
        }
    }
}
