int n = 10;
int[] arr = new int[n];

Console.Write(arr);

void MakeArray(int[] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = i + 1; // Initialize with values from 1 to n
    }
}
void FillArray(int[] arr, int n)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = arr[i]+1;
    }
}

static int GetSumOfElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

static int GetProductOfElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product *= arr[i];
    }
    return product;
}

MakeArray(arr);
FillArray(arr, n);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(GetSumOfElements(arr));
Console.WriteLine(GetProductOfElements(arr));

