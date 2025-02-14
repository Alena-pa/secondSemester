var array = new int[10];
for (var i = array.Length - 1; i >= 0; i--)
{
    array[i] = i * i;
}

for (var i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}

void BubbleSort(int[] array)
{
    bool isArraySorted = false;
    while (!isArraySorted)
    {
        isArraySorted = true;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                (array[i - 1], array[i]) = (array[i], array[i - 1]);
                isArraySorted = false;
            }
        }
    }
}