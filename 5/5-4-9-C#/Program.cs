List<string> juices = new List<string> { "葡萄多多", "布丁奶茶", "紅牛綠茶", "冰淇淋紅茶" };
Console.WriteLine("清空前-所有的飲料:");
foreach (string juice in juices)
{
    Console.Write(juice + "、");
}
juices.Clear();
Console.WriteLine("");
Console.WriteLine("清空後-所有的飲料:");
foreach (string juice in juices)
{
    Console.Write(juice + "、");
}
