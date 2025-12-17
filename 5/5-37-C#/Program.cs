bool[] newBool = { true, true, true, true };
Array.Clear(newBool, 1, 2);
Console.WriteLine("Clear 之後:");
foreach (bool b in newBool)
{
    Console.Write(b + " ");
}