using System;
class rotate
{
    public static void Main()
    {
        int[] arr = { 1, 2, 8 };
        int arr2 = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = arr2;
        Console.WriteLine(string.Join(", ", arr));
        Console.ReadKey(true);
}
}
