
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("Array vorwärts");
        ArrayAusgabe(numbers, 0);
        ArrayReverse(numbers);
    }

    static void ArrayAusgabe(int[] arr, int index)
    {
        
        if (index < arr.Length)
        {
            Console.WriteLine("ArrayIndex[" + index + "]: " + arr[index]);
            ArrayAusgabe(arr, index + 1);
        }
    }

    static void ArrayReverse(int[] arr)
    {
        Array.Reverse(arr);
        Console.WriteLine("Array umgekehrt");
        ArrayAusgabe(arr, 0);
    }
}

