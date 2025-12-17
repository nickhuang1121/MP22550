int[] numbers = { 1, 2, 3, 4, 5 };
Array.Clear(numbers, 1, 3);
Console.WriteLine("Clear 之後:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}