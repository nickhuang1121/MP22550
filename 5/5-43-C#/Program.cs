List<string> juices = new List<string> { " 葡萄多多", " 紅牛綠茶", " 冰淇淋紅茶" };
string newJuice = " 布丁奶茶";
juices.Insert(2, newJuice);
Console.WriteLine(" 所有的飲料:");
foreach (string juice in juices)
{
    Console.Write(juice + "、");
}