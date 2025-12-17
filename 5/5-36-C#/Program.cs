string[] newString = { "Hello", "World", "Day", "Nice" };
Array.Clear(newString, 1, 2);
Console.WriteLine("Clear 之後:");
foreach (string str in newString)
{
    Console.Write(str + " ");
}