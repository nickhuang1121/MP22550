List<string> juices = new List<string> { " 葡萄多多" };
Console.WriteLine("List 目前長度:" + juices.Count);
juices.Add(" 紅牛綠茶");
juices.Add(" 冰淇淋紅茶");
Console.WriteLine(" 水果清單:");
foreach (string juice in juices)
{
    Console.WriteLine(juice);
}
Console.WriteLine("add 後長度:" + juices.Count);