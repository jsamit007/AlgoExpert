namespace AlgoExpert;

internal class ArrayOfProducts
{
    internal int[] GetProducts(int[] array)
    {
        int zerosCount = 0;
        int products = 1;
        foreach(int num in array)
        {
            if(num != 0)
                products *= num;
            else
            {
                zerosCount++;
                if (zerosCount > 1)
                {
                    products = 0;
                    break;
                }
            }
                
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                if (zerosCount == 1)
                    array[i] = 0;
                else
                    array[i] = products / array[i];
            }
            else
                array[i] = products;
        }
        return array;
    }
}
