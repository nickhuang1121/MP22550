List<string> juices = new List<string> { "布丁奶茶", "錫蘭紅茶", "布丁奶茶" };
bool findJuices = juices.Contains("布丁奶茶");
Console.WriteLine("是否有布丁奶茶?");
if (findJuices)
{
    Console.WriteLine("有找到");
}
else
{
    Console.WriteLine("沒有找到");
}