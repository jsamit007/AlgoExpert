namespace AlgoExpert.Medium;

internal class MinHeap
{
    public readonly List<int> _heap;

    public MinHeap(List<int> heap)
    {
        _heap = buildHeap(heap);
    }

    public List<int> buildHeap(List<int> array)
    {
        var lastParentIdx = (int)((array.Count - 1) / 2);
        for (int currentIdx = lastParentIdx; currentIdx >= 0; currentIdx--)
        {
            siftDown(currentIdx, array.Count, array);
        }
        return array;
    }

    public void siftDown(int currentIdx, int endIdx, List<int> heap)
    {
        int leftChildIdx = currentIdx * 2 + 1;
        int rightChildIdx = currentIdx * 2 + 2;

        while ((leftChildIdx < endIdx && heap[leftChildIdx] < heap[currentIdx]) || (rightChildIdx < endIdx && heap[rightChildIdx] < heap[currentIdx]))
        {
            if (rightChildIdx >= endIdx || heap[leftChildIdx] < heap[rightChildIdx])
            {
                swap(currentIdx, leftChildIdx, heap);
                currentIdx = leftChildIdx;
                leftChildIdx = currentIdx * 2 + 1;
                rightChildIdx = currentIdx * 2 + 2;
            }
            else
            {
                swap(currentIdx, rightChildIdx, heap);
                currentIdx = rightChildIdx;
                leftChildIdx = currentIdx * 2 + 1;
                rightChildIdx = currentIdx * 2 + 2;
            }
        }
    }

    public void swap(int i, int j, List<int> heap)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    public void siftUp(int currentIdx, List<int> heap)
    {
        var parentIdx = (int)((currentIdx - 1) / 2);
        while(currentIdx > 0 && heap[currentIdx] < heap[parentIdx])
        {
            swap(currentIdx, parentIdx, heap);
            currentIdx = parentIdx;
            parentIdx = (int)((currentIdx - 1) / 2);
        }
    }

    public int Peek()
    {
       return _heap.Count > 0 ? _heap[0] : -1;
    }

    public int Remove()
    {
        if(_heap.Count == 0)
            return -1;
        int value = _heap[0];
        swap(0, _heap.Count-1, _heap);
        _heap.RemoveAt(_heap.Count - 1);
        siftDown(0, _heap.Count - 1, _heap);
        return value;
    }

    public void Insert(int value)
    {
        _heap.Add(value);
        siftUp(_heap.Count - 1, _heap); 
    }
}
