List<string> juices = new List<string> { "葡萄多多", "紅牛綠茶", "冰淇淋紅茶" };
List<string> moreJuices = new List<string> { "甘蔗清茶", "錫蘭奶茶", "布丁奶茶" };
Console.WriteLine("List目前長度:" + juices.Count);
juices.AddRange(moreJuices);
foreach (string juice in juices)
{
    Console.Write(juice + "、");
}
Console.WriteLine("");
Console.WriteLine("add後長度:" + juices.Count);