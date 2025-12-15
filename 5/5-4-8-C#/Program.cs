List<string> juices = new List<string> { "葡萄多多", "布丁奶茶", "紅牛綠茶", "冰淇淋紅茶" };
juices.RemoveAt(0);
Console.WriteLine("所有的飲料:");
foreach (string juice in juices)
{
    Console.Write(juice + "、");
}