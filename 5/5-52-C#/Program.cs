List<int> numbers = new List<int> { 4, 5, 1, 2, 3 };
Console.Write("Sort 前：");
foreach (int num in numbers)
{
    Console.Write(num);
}
numbers.Sort();
Console.WriteLine();
Console.Write("Sort 後：");
foreach (int num in numbers)
{
    Console.Write(num);
}