using System.Net.WebSockets;
using System.Runtime.Intrinsics.X86;

var array = new int[10];

var str = System.Console.ReadLine();
if (str is null)
{
    Console.WriteLine("ВСЕ ПЛОХО");
    return -1;
}

var массив = str.Split(' ');

var array2 = массив.Select(x => int.Parse(x)).ToArray();

for (int i = 0; i < array2.Length; i++)
{
    if (int.TryParse(массив[i], out int result))
    {
        array2[i] = result;
    }
}

array2.ToList().ForEach(x => Console.Write($"{x} "));
Console.WriteLine();

for (var i = array.Length - 1; i >= 0; i--)
{
    array[i] = i * i;
}

BubbleSort(array);

for (var i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]} ");
}

var (mean, dispertion) = Math(array);

System.Console.WriteLine($"\nМат ожидание: {mean}\nДисперсия: {dispertion}");

(double Mean, double Dispertion) Math(int[] array)
{
    double mean = calcMean(array);
    double dispersion = 1;
    for (var i = 0; i < array.Length; i++)
    {
        dispersion += System.Math.Pow((array[i] - mean), 2.0);
    }
    dispersion = dispersion / (array.Length - 1);

    return (mean, dispersion);

    float calcMean (int[] array) => array.Sum() / (float)array.Length;
}
void BubbleSort(int[] array)
{
    bool isArraySorted = false;
    while (!isArraySorted)
    {
        isArraySorted = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                isArraySorted = false;
            }
        }
    }
}

return 0;